
using Microsoft.Data.SqlClient;

namespace CSHARP260422;

public partial class FrmDetails : Form
{
    private string contactId;

    public FrmDetails(string function, string contactId)
    {
        this.contactId = contactId;

        InitializeComponent();

        if (function == "details" || function == "delete")
        {
            txtName.Enabled = false;
            txtEmail.Enabled = false;
            txtPhone.Enabled = false;
        }
        if (function == "details")
        { 
            btnButton.Text = "Close";
            btnButton.Click += BtnCloseClick;
        }
        else if (function == "update")
        {
            btnButton.Text = "Update";
            btnButton.Click += BtnUpdateClick;
        }
        else if (function == "delete")
        {
            btnButton.Text = "Delete";
            btnButton.Click += BtnDeleteClick;
        }
        else if(function == "new")
        {
            btnButton.Text = "Create";
            btnButton.Click += BtnCreateClick;
        }

        this.Load += FrmDetailsLoad;
    }

    private void BtnCreateClick(object? sender, EventArgs e)
    {
        using SqlConnection connection = new(Program.ConnectionString);
        connection.Open();

        SqlDataAdapter adapter = new()
        {
            InsertCommand = new($"INSERT INTO contacts VALUES ('{txtName.Text}', '{txtEmail.Text}', '{txtPhone.Text}');", connection),
        };

        adapter.InsertCommand.ExecuteNonQuery();

        this.Dispose();
    }

    private void BtnDeleteClick(object? sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show(
            caption: "DELETE",
            text: "are you sure?",
            icon: MessageBoxIcon.Warning,
            buttons: MessageBoxButtons.YesNo);

        if (result != DialogResult.Yes) return;

        using SqlConnection connection = new(Program.ConnectionString);
        connection.Open();

        SqlDataAdapter adapter = new()
        {
            DeleteCommand = new($"DELETE FROM contacts WHERE id = {contactId};", connection),

        };

        adapter.DeleteCommand.ExecuteNonQuery();

        this.Dispose();

    }

    private void BtnUpdateClick(object? sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show(
            caption: "MODIFY",
            text: "save changes?",
            icon: MessageBoxIcon.Question,
            buttons: MessageBoxButtons.YesNo);

        if (result != DialogResult.Yes) return;

        using SqlConnection connection = new(Program.ConnectionString);
        connection.Open();

        SqlDataAdapter adapter = new()
        {
            UpdateCommand = new($"UPDATE contacts SET " +
            $"name = '{txtName.Text}', " +
            $"email = '{txtEmail.Text}', " +
            $"phone = '{txtPhone.Text}' " +
            $"WHERE id = {contactId};", connection),
        };

        adapter.UpdateCommand.ExecuteNonQuery();

        this.Dispose();
    }

    private void BtnCloseClick(object? sender, EventArgs e) => this.Dispose();

    private void FrmDetailsLoad(object? sender, EventArgs e)
    {
        if (contactId is null) return;

        using SqlConnection connection = new(Program.ConnectionString);
        connection.Open();

        SqlDataReader reader = new SqlCommand(
            $"SELECT * FROM contacts WHERE id = {contactId};",
            connection).ExecuteReader();

        reader.Read();

        txtId.Text = $"{reader["id"]}";
        txtName.Text = $"{reader["name"]}";
        txtEmail.Text = $"{reader["email"]}";
        txtPhone.Text = $"{reader["phone"]}";

    }
}

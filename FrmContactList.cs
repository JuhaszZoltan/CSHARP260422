using Microsoft.Data.SqlClient;

namespace CSHARP260422;

public partial class FrmContactList : Form
{
    public FrmContactList()
    {
        InitializeComponent();
        this.Load += FrmContactListLoad;
        dgvContacts.CellContentClick += DgvContactsCellContentClick;
        btnNew.Click += BtnNewContactClick;
        txtSearch.TextChanged += TxtSearchTextChanged;
        timer.Tick += TimerTick;
    }

    private void TimerTick(object? sender, EventArgs e)
    {
        LoadAllContact(txtSearch.Text);
        timer.Stop();
    }

    private void TxtSearchTextChanged(object? sender, EventArgs e)
    {
        timer.Start();
    }

    private void BtnNewContactClick(object? sender, EventArgs e)
    {
        _ = new FrmDetails(function: "new", contactId: null).ShowDialog();
        LoadAllContact();
    }

    private void DgvContactsCellContentClick(object? sender, DataGridViewCellEventArgs e)
    { 
        if (e.ColumnIndex == 2) //details
        {
            _ = new FrmDetails(function: "details", $"{dgvContacts[0, e.RowIndex].Value}").ShowDialog();
        }
        else if (e.ColumnIndex == 3) //update
        {
            _ = new FrmDetails(function: "update", $"{dgvContacts[0, e.RowIndex].Value}").ShowDialog();
            LoadAllContact();
        }
        else if (e.ColumnIndex == 4) //delete
        {
            _ = new FrmDetails(function: "delete", $"{dgvContacts[0, e.RowIndex].Value}").ShowDialog();
            LoadAllContact();
        }
    }

    private void FrmContactListLoad(object? sender, EventArgs e)
    {
        LoadAllContact(string.Empty);
    }

    //PM> Install-Package Microsoft.Data.SqlClient

    private void LoadAllContact(string search = null!)
    {
        dgvContacts.Rows.Clear();
        using SqlConnection connection = new(Program.ConnectionString);
        connection.Open();

        SqlDataReader reader = new SqlCommand(
            $"SELECT id, name FROM contacts WHERE name LIKE '{search}%' ORDER BY name ASC;",
            connection).ExecuteReader();
        while(reader.Read())
        {
            int ri = dgvContacts.Rows.Add(
                reader["id"],
                reader["name"]);
        }

    }
}

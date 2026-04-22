namespace CSHARP260422
{
    partial class FrmDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            btnButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(116, 64);
            label1.Name = "label1";
            label1.Size = new Size(42, 32);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 137);
            label2.Name = "label2";
            label2.Size = new Size(79, 32);
            label2.TabIndex = 0;
            label2.Text = "name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 210);
            label3.Name = "label3";
            label3.Size = new Size(87, 32);
            label3.TabIndex = 0;
            label3.Text = "e-mail:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 283);
            label4.Name = "label4";
            label4.Size = new Size(88, 32);
            label4.TabIndex = 0;
            label4.Text = "phone:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(190, 61);
            txtId.Name = "txtId";
            txtId.Size = new Size(77, 39);
            txtId.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(190, 134);
            txtName.Name = "txtName";
            txtName.Size = new Size(287, 39);
            txtName.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(190, 207);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(287, 39);
            txtEmail.TabIndex = 1;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(190, 280);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(287, 39);
            txtPhone.TabIndex = 1;
            // 
            // btnButton
            // 
            btnButton.Location = new Point(116, 378);
            btnButton.Name = "btnButton";
            btnButton.Size = new Size(336, 46);
            btnButton.TabIndex = 2;
            btnButton.Text = "#default button#";
            btnButton.UseVisualStyleBackColor = true;
            // 
            // FrmDetails
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 454);
            Controls.Add(btnButton);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "FrmDetails";
            Text = "FrmDetails";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private Button btnButton;
    }
}
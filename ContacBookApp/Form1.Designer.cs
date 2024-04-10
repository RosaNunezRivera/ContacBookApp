namespace ContacBookApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            Name = new DataGridViewTextBoxColumn();
            ContactId = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPhoneNumber = new TextBox();
            txtDob = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            BtnSave = new Button();
            BtnCancel = new Button();
            BtnDelete = new Button();
            BtnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Name, ContactId, Email, PhoneNumber });
            dataGridView1.Location = new Point(627, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(458, 290);
            dataGridView1.TabIndex = 0;
            dataGridView1.MouseClick += dataGridView1_MouseClick;
            // 
            // Name
            // 
            Name.DataPropertyName = "Name";
            Name.HeaderText = "Contact Name";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.Width = 125;
            // 
            // ContactId
            // 
            ContactId.DataPropertyName = "ContactId";
            ContactId.HeaderText = "ContactId";
            ContactId.MinimumWidth = 6;
            ContactId.Name = "ContactId";
            ContactId.Visible = false;
            ContactId.Width = 125;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.Width = 125;
            // 
            // PhoneNumber
            // 
            PhoneNumber.DataPropertyName = "PhoneNumber";
            PhoneNumber.HeaderText = "Phone Number";
            PhoneNumber.MinimumWidth = 6;
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Width = 125;
            // 
            // txtName
            // 
            txtName.Location = new Point(134, 75);
            txtName.Name = "txtName";
            txtName.Size = new Size(187, 27);
            txtName.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(134, 136);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(187, 27);
            txtEmail.TabIndex = 2;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(137, 197);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(184, 27);
            txtPhoneNumber.TabIndex = 3;
            // 
            // txtDob
            // 
            txtDob.Location = new Point(139, 257);
            txtDob.Name = "txtDob";
            txtDob.Size = new Size(182, 27);
            txtDob.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 78);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 5;
            label1.Text = "Contact Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 136);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 6;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 197);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 7;
            label3.Text = "Phone Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 260);
            label4.Name = "label4";
            label4.Size = new Size(96, 20);
            label4.TabIndex = 8;
            label4.Text = "Date Of Birth";
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(12, 353);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(114, 45);
            BtnSave.TabIndex = 9;
            BtnSave.Text = "Add Contact";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(173, 353);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(114, 45);
            BtnCancel.TabIndex = 10;
            BtnCancel.Text = "Cancel";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(334, 353);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(110, 45);
            BtnDelete.TabIndex = 11;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnUpdate
            // 
            BtnUpdate.Location = new Point(15, 421);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(111, 39);
            BtnUpdate.TabIndex = 12;
            BtnUpdate.Text = "Update";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 541);
            Controls.Add(BtnUpdate);
            Controls.Add(BtnDelete);
            Controls.Add(BtnCancel);
            Controls.Add(BtnSave);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDob);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(dataGridView1);
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPhoneNumber;
        private TextBox txtDob;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn ContactId;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn PhoneNumber;
        private Button BtnSave;
        private Button BtnCancel;
        private Button BtnDelete;
        private Button BtnUpdate;
    }
}

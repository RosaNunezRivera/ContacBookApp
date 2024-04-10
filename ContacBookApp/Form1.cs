using ContacBookApp.Context;
using ContacBookApp.Entity;

namespace ContacBookApp
{
    public partial class Form1 : Form
    {
        ContactContext context = new ContactContext();
        Contact contact = new Contact();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadGridView();
        }

        public void LoadGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = context.Contacts.ToList();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            int contactId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ContactId"].Value);
            contact = context.Contacts.FirstOrDefault(x => x.ContactId == contactId);
            txtName.Text = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();  //contact.Name;
            txtEmail.Text = contact.Email;
            txtPhoneNumber.Text = contact.PhoneNumber.ToString();
            txtDob.Text = contact.DateOfBirth.ToString();

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Contact contactAdd = new Contact();
            contactAdd.Name = txtName.Text;
            contactAdd.Email = txtEmail.Text;
            contactAdd.PhoneNumber = long.Parse(txtPhoneNumber.Text);
            contactAdd.DateOfBirth = Convert.ToDateTime(txtDob.Text);

            context.Contacts.Add(contactAdd);
            context.SaveChanges();

            ClearTextBoxes();

            LoadGridView();

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        public void ClearTextBoxes()
        {
            txtName.Text = txtEmail.Text = txtPhoneNumber.Text = txtDob.Text = string.Empty;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            contact.Name = txtName.Text;
            contact.Email = txtEmail.Text;
            contact.PhoneNumber = long.Parse(txtPhoneNumber.Text);
            contact.DateOfBirth = Convert.ToDateTime(txtDob.Text);
            context.Entry(contact).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();

            LoadGridView();
        }
    }
}

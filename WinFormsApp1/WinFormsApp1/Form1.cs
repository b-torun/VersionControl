using System.ComponentModel;
using UserMaintenance.Entities;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();

        public Form1()
        {
            InitializeComponent();
            lblLastName.Text = UserMaintenance.Resource1.LastName;// label1
            lblFirstName.Text = UserMaintenance.Resource1.FirstName; // label2
            btnAdd.Text =  UserMaintenance.Resource1.Add; // button1
                                                          // listbox1
            listUsers.DataSource = users;
            listUsers.ValueMember = "ID";
            listUsers.DisplayMember = "FullName";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var u = new User()
            {
                LastName = txtLastName.Text,
                FirstName = txtFirstName.Text
            };
            users.Add(u);
        }
    }

}
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
            lblFullName.Text = UserMaintenance.Resource1.FullName;// label1           
            btnList.Text =  UserMaintenance.Resource1.List; // button1
                                                            // listbox1
            btnWriteToFile.Text = UserMaintenance.Resource1.WriteToFile;
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
                FullName = txtFullName.Text,
                
            };
            users.Add(u);
        }

        private void btnWriteToFile_Click(object sender, EventArgs e)
        
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt";
            saveFileDialog.Title = "Save Users List";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {                  
                    foreach (User user in users)
                    {
                        writer.WriteLine($"{user.ID}\t{user.FullName}");
                    }
                }
            }
        }
    }

}
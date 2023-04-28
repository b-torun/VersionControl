namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblLastName.Text = UserMaintenance.Resource1.LastName;// label1
            lblFirstName.Text = UserMaintenance.Resource1.FirstName; // label2
            btnAdd.Text =  UserMaintenance.Resource1.Add; // button1
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
namespace ExamApp
{
    public partial class Form1 : Form
    {
        public UserService userService = new UserService();
        public Form1()
        {
            InitializeComponent();
        }



        private void loadUsersButton_Click(object sender, EventArgs e)
        {
            initUserData();
        }

        private void saveUserButton_Click(object sender, EventArgs e)
        {
            saveUserData();
            if (!string.IsNullOrEmpty(userIdTextBox.Text))
            {
                updateUserData(int.Parse(userIdTextBox.Text));
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridView dvg = sender as DataGridView;
                var data = dvg.Rows[e.RowIndex].DataBoundItem as User;
                userIdTextBox.Text = data.Id.ToString();
                userAgeTextBox.Text = data.Age.ToString();
                userNameTextBox.Text = data.Name;


            }
        }

        public void updateUserData(int id)
        {
            User user = userService.GetUser(id);
            user.Name = userNameTextBox.Text;
            user.Age = int.Parse(userAgeTextBox.Text);

            userService.UpdateUser(user);
        }

        public void initUserData()
        {

            dataGridView1.DataSource = userService.GetAllUsers();
        }

        public void saveUserData()
        {
            User user = new User();
            user.Name = userNameTextBox.Text;
            user.Age = int.Parse(userAgeTextBox.Text);

            userService.SaveUser(user);
            initUserData();
        }
    }
}

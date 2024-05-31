namespace Assignment_4._1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person newPerson = new Person();

            if (firstNameTextBox.Text != "")
            {
                newPerson.FirstName = firstNameTextBox.Text;

            }
            else
            {
                MessageBox.Show("Please enter first name");
            }
            if (lastNameTextBox.Text != "")
            {
                newPerson.LastName = lastNameTextBox.Text; ;

            }
            else
            {
                MessageBox.Show("Please enter last name");
            }
            if (mobilePhoneTextBox.Text != "")
            {
                newPerson.MobilePhone = mobilePhoneTextBox.Text;

            }
            else
            {
                MessageBox.Show("Please enter mobile phone number");
            }
            if (workPhoneTextBox.Text != "")
            {
                newPerson.WorkPhone = workPhoneTextBox.Text;

            }
            else
            {
                MessageBox.Show("Please enter work phone");
            }
            if (emailTextBox.Text != "")
            {
                newPerson.Email = emailTextBox.Text;

            }
            else
            {
                MessageBox.Show("Please enter email");
            }
            if (addressTextBox.Text != "")
            {
                newPerson.Address = addressTextBox.Text;

            }
            else
            {
                MessageBox.Show("Please enter address");
            }






            
                

        }
    }
}

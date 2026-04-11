using System;
using System.Collections;
using System.Windows.Forms;

namespace StudentRegistrationApplication
{
    public partial class backgound : Form
    {
        public backgound()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string lastName = textBox1.Text;
            string firstName = textBox2.Text;
            string middleName = textBox3.Text;
            string gender = radioButton1.Checked ? "Male" : "Female";
            string dateOfBirth = $"{comboBox2.SelectedItem}/{comboBox1.SelectedItem}/{comboBox3.SelectedItem}";
            string program = comboBox4.SelectedItem?.ToString() ?? "Not selected";

            
            ShowStudentInfo(firstName, middleName, lastName, gender, dateOfBirth, program); 
            ShowStudentInfo(firstName, lastName, gender); 
            ShowStudentInfo(firstName, lastName); 
        }

        private void backgound_Load(object sender, EventArgs e)
        {
            ArrayList programs = new ArrayList
            {
                "Bachelor of Science in Computer Science",
                "Bachelor of Science in Information Technology",
                "Bachelor of Science in Information Systems",
                "Bachelor of Science in Computer Engineering"
            };

            foreach (string program in programs)
            {
                comboBox4.Items.Add(program);
            }

            for (int day = 1; day <= 31; day++)
            {
                comboBox1.Items.Add(day);
            }

         
            string[] months = {
                "January", "February", "March", "April", "May", "June",
                "July", "August", "September", "October", "November", "December"
            };

            foreach (string month in months)
            {
                comboBox2.Items.Add(month);
            }

            for (int year = 1900; year <= DateTime.Now.Year; year++)
            {
                comboBox3.Items.Add(year);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMiddleName_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtLastName_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
      
        private void ShowStudentInfo(string firstName, string middleName, string lastName, string gender, string dateOfBirth, string program)
        {
            string message =
                $"Student name: {firstName} {middleName} {lastName}\n" +
                $"Gender: {gender}\n" +
                $"Date of birth: {dateOfBirth}\n" +
                $"Program: {program}";
            MessageBox.Show(message, "Student Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

      
        private void ShowStudentInfo(string firstName, string lastName, string gender)
        {
            string message =
                $"Student name: {firstName} {lastName}\n" +
                $"Gender: {gender}";
            MessageBox.Show(message, "Student Basic Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
        private void ShowStudentInfo(string firstName, string lastName)
        {
            string message = $"Student name: {firstName} {lastName}";
            MessageBox.Show(message, "Student Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select an image file";
                openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;)|*.jpg;*.jpeg;*.png;";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
              
                    MessageBox.Show("Selected image: " + openFileDialog.FileName, "Image Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    pictureBox1.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; 
                }
            }
        

    }






        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtGender_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstName_Click(object sender, EventArgs e)
        {

        }

        private void txtlabel1_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;
using System.Collections;

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
            string message =
                $"Student name: {firstName} {middleName} {lastName}\n" +
                $"Gender: {gender}\n" + 
                $"Date of birth: {dateOfBirth}\n" +
            $"Program: {program}";

            MessageBox.Show(message, "Student Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            // Add months using array and foreach loop
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
    }
}


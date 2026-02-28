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
            string message =
                $"Student name: {firstName} {middleName} {lastName}\n" +
                $"Gender: {gender}\n" + $"Date of birth: {dateOfBirth}";

            MessageBox.Show(message, "Student Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void backgound_Load(object sender, EventArgs e)
        {



            for (int day = 1; day <= 31; day++)
            {
                comboBox1.Items.Add(day);
            }


            for (int month = 1; month <= 12; month++)
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

       

        
    }
}


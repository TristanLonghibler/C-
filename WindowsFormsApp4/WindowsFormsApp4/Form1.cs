using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int count = 0;
            yearEntered.Text = "0";
            answerBox.Text = "Please enter a starting year.";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            int yearToCheck = 0;
            listBoxYears.Items.Clear();
            

            if(int.TryParse(yearEntered.Text,out yearToCheck) && yearToCheck > 0)
            {
                answerBox.Text = "Thank you!";
                yearToCheck++;
                while (listBoxYears.Items.Count < 10)
                {
                    if (yearToCheck % 4 == 0)
                    {
                        if (yearToCheck % 100 != 0 || yearToCheck % 400 == 0)
                        {
                            listBoxYears.Items.Add(yearToCheck.ToString());
                        }
                    }
                    yearToCheck++;
                }
            }
            else
            {
                answerBox.Text = "Please enter a valid year, ex.(2020)";
            }
        }

        private void yearEntered_TextChanged(object sender, EventArgs e)
        {

        }

        private void answerBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

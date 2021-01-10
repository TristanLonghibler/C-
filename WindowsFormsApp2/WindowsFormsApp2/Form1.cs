using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        int randomNum;
        int userGuess;
        int count = 0;
        Random myRandomNumGenerator;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if(count == 0)
            {
                newRandomNum();
            }

            if (!int.TryParse(userGuessBox.Text, out userGuess))
            {
                textBoxAnswer.Text = "Please enter a valid integer 1 - 100";
            }

            else {

                if (userGuess != randomNum)
                {
                    if (userGuess > randomNum)
                    {
                        textBoxAnswer.Text = "Guessed Too High. Please Try again";
                    }
                    else textBoxAnswer.Text = "Guessed Too Low. Please Try Again.";
                    count++;
                    userGuessBox.Text = "";
                    userGuessBox.Focus();
                }
                else textBoxAnswer.Text = ("Your guess is spot on! It only took " + count + " times to get it!");
            }
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            newRandomNum();
            count = 0;
            textBoxAnswer.Text = "Welcome, please enter a number 1-100 above.";
            userGuessBox.Text = "";
        }


        private void newRandomNum()
        {
            myRandomNumGenerator = new Random();
            randomNum = myRandomNumGenerator.Next(100);
        }
    }
}

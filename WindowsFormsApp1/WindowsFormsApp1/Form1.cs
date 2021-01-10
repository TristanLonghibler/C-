using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Welcome To Buisiness Application Development");
			textBox1.Text = "Hi";
			//string textBoxText = textBox1.Text.ToString();
			//MessageBox.Show(textBoxText);
			//if (textBoxText == "Hi")
			//{
			//	MessageBox.Show("It's correct");
			//}

			//For Loop 
			//for (int i = 0; i < 5; i++)
			//{
			//	MessageBox.Show(i.ToString());
			//}


			//While Loop
			int myInt = 0;

			while (myInt < 5)
			{
				MessageBox.Show("My Int is now: " + myInt.ToString());

				myInt++;
			}


		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{

		}
	}
}

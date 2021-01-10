using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double charges;
            double tax;
            double tip;
            double total;

            if (!double.TryParse(textBoxCharges.Text, out charges))
            {
                MessageBox.Show("Please enter a valid charge, example: 100.99");
            }
            if (!double.TryParse(textBoxTax.Text, out tax))
            {
                MessageBox.Show("Please enter a valid tax %, example: 9.85");
            }
            if (!double.TryParse(textBoxTip.Text, out tip))
            {
                MessageBox.Show("Please enter a valid tip %, example: 20.00");
            }

            
            total = charges + (charges * tax * 0.01) + (charges * tip * 0.01);
            labelTotalValue.Text = "$" + decimal.Round((decimal)total, 2).ToString();

            if(tip > 10.00)
            {
                MessageBox.Show("Thank You!");
            }
        }
    }
}

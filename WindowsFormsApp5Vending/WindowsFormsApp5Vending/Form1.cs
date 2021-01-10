using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5Vending
{

    struct DrinkEntry
    {

        public string name;
        public string cost;
        public int numDrink;

    }


    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
        }

        string[,] drinks = new string[,]
        {
            {"Baja Blast", "1.25", "20" },
            {"Code Red", "1.25", "20" },
            {"LiveWire", "1.50", "20" },
            {"Pitch Black", "1.50", "20" },
            {"SuperNova", "1.75", "20" }
        };

        double total = 0.00;
        DrinkEntry entry = new DrinkEntry();
        int index;

        private void updateDrink()
        {
            entry.name = drinks[index, 0];
            entry.cost = drinks[index, 1];
            entry.numDrink = int.Parse(drinks[index, 2]);

            if (entry.numDrink == 0)
            {
                MessageBox.Show(entry.name + " sold out.");
            }
            else
            {
                entry.numDrink--;
                drinks[index, 2] = entry.numDrink.ToString();

                switch(index)
                {
                    case 0: bajaBlast.Text = entry.numDrink.ToString(); break;
                    case 1: codeRed.Text = entry.numDrink.ToString(); break;
                    case 2: liveWire.Text = entry.numDrink.ToString(); break;
                    case 3: pitchBlack.Text = entry.numDrink.ToString(); break;
                    case 4: superNova.Text = entry.numDrink.ToString(); break;
                }
                total += double.Parse(entry.cost);

                totalSales.Text = "$" + total;
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bajaBlast.Text = drinks[index, 2];
            codeRed.Text = drinks[index, 2];
            liveWire.Text = drinks[index, 2];
            pitchBlack.Text = drinks[index, 2];
            superNova.Text = drinks[index, 2];
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            index = 0;
            updateDrink();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            index = 1;
            updateDrink();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            index = 2;
            updateDrink();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            index = 3;
            updateDrink();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            index = 4;
            updateDrink();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}

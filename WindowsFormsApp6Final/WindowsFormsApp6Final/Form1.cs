using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApp6Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PopulateAnimalList();
        }

        List<Animal> myAnimalList = new List<Animal>();

        public void PopulateAnimalList()
        {
            myAnimalList.Add(new Animal("Hyena", @"C:\Users\longh\source\repos\WindowsFormsApp6Final\hyena.wav"));
            myAnimalList.Add(new Animal("Sea Lion", @"C:\Users\longh\source\repos\WindowsFormsApp6Final\sealion.wav"));
            myAnimalList.Add(new Animal("Bear", @"C:\Users\longh\source\repos\WindowsFormsApp6Final\Bear3.wav"));
            myAnimalList.Add(new Animal("Whale", @"C:\Users\longh\source\repos\WindowsFormsApp6Final\whalesurfaces.wav"));
            myAnimalList.Add(new Animal("Baboon", @"C:\Users\longh\source\repos\WindowsFormsApp6Final\baboon_monkey.wav"));

            listBoxAnimals.DataSource = myAnimalList;
            listBoxAnimals.DisplayMember = "userName";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Play animal sound here 
            Animal selectedItem = (Animal)listBoxAnimals.SelectedItem;
            selectedItem.playAnimalSound();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            char[] f = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', };
            var index = 0;
          //  for (int i = 0; i < f.Length; i++) 
            //{ 
              //  if (f[i] == 'I') 
                //{ 
                  //  index = i; 
                //} 
            //}
            MessageBox.Show("Index is " + f[8]);
        }
    }
}

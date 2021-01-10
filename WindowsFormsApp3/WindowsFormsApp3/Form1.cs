using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        //Array of floats to store hours for each day of the week
        float[] hoursWorked = new float[7];

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Ternary Operator for error handling.  (Item to check true or false) ? (Return value if true) : (Return value if false)
            errorTextBox.Text = float.TryParse(sundayHours.Text, out hoursWorked[0]) && hoursWorked[0] != 0 ? "Thanks for updating your hours!" : (hoursWorked[0] == 0) ? errorTextBox.Text : "Please enter valid hours for Sunday" ;
            errorTextBox.Text = float.TryParse(mondayHours.Text, out hoursWorked[1]) && hoursWorked[1] != 0 ? "Thanks for updating your hours!" : (hoursWorked[1] == 0) ? errorTextBox.Text : "Please enter valid hours for Monday";
            errorTextBox.Text = float.TryParse(tuesdayHours.Text, out hoursWorked[2]) && hoursWorked[2] != 0 ? "Thanks for updating your hours!" : (hoursWorked[2] == 0) ? errorTextBox.Text : "Please enter valid hours for Tuesday";
            errorTextBox.Text = float.TryParse(wednesdayHours.Text, out hoursWorked[3]) && hoursWorked[3] != 0 ? "Thanks for updating your hours!" : (hoursWorked[3] == 0) ? errorTextBox.Text : "Please enter valid hours for Wednesday";
            errorTextBox.Text = float.TryParse(thursdayHours.Text, out hoursWorked[4]) && hoursWorked[4] != 0 ? "Thanks for updating your hours!" : (hoursWorked[4] == 0) ? errorTextBox.Text : "Please enter valid hours for Thursday";
            errorTextBox.Text = float.TryParse(fridayHours.Text, out hoursWorked[5]) && hoursWorked[5] != 0  ? "Thanks for updating your hours!" : (hoursWorked[5] == 0) ? errorTextBox.Text : "Please enter valid hours for Friday";
            errorTextBox.Text = float.TryParse(saturdayHours.Text, out hoursWorked[6]) && hoursWorked[6] != 0 ? "Thanks for updating your hours!" : (hoursWorked[6] == 0) ? errorTextBox.Text : "Please enter valid hours for Saturday";

            //reset text box hours to 0, to avoid parsing NULL values on submit
            sundayHours.Text = "0";
            mondayHours.Text = "0";
            tuesdayHours.Text = "0";
            wednesdayHours.Text = "0";
            thursdayHours.Text = "0";
            fridayHours.Text = "0";
            saturdayHours.Text = "0";

        }

        private void lookUpDays_Click(object sender, EventArgs e)
        {
            //Get the number associated with currently selected day in combobox.
            int currVal = (int)dayToFindCB.SelectedValue; 
            //Get the hours associated with that number from the hours array. (0 through 6)
            hourDisplayTextBox.Text = hoursWorked[currVal].ToString();
        }


        //New class for combox datasource
        public class DayPair
        {
            public string Day { get; set; }
            public int Value { get; set; }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            //reset text box hours to 0, to avoid parsing NULL values on submit
            sundayHours.Text = "0";
            mondayHours.Text = "0";
            tuesdayHours.Text = "0";
            wednesdayHours.Text = "0";
            thursdayHours.Text = "0";
            fridayHours.Text = "0";
            saturdayHours.Text = "0";

            //Build a list for new combobox datasource
            var dataSource = new List<DayPair>();
            dataSource.Add(new DayPair() { Day = "Sunday", Value = 0 });
            dataSource.Add(new DayPair() { Day = "Monday", Value = 1 });
            dataSource.Add(new DayPair() { Day = "Tuesday", Value = 2 });
            dataSource.Add(new DayPair() { Day = "Wednesday", Value = 3 });
            dataSource.Add(new DayPair() { Day = "Thursday", Value = 4 });
            dataSource.Add(new DayPair() { Day = "Friday", Value = 5 });
            dataSource.Add(new DayPair() { Day = "Saturday", Value = 6 });

            //Setup data binding to combobox, assign datasource 
            dayToFindCB.DataSource = dataSource;
            dayToFindCB.DisplayMember = "Day";
            dayToFindCB.ValueMember = "Value";

            // make it readonly
            dayToFindCB.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}

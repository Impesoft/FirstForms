using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _20210112Dag1AdvandedC
{
    public partial class HowOld : Form
    {
        public static DateTime Today = DateTime.Now;
        public DateTime MinimalAgeBirthday = Today.AddYears(-18);
        
       

        public  HowOld()
        {
            InitializeComponent();
        }


        private void HowOld_Load(object sender, EventArgs e)
        {

            DateOfBirth.MaxDate = MinimalAgeBirthday;
        }

        private void DateOfBirth_CloseUp(object sender, EventArgs e)
        {

            if ((DateOfBirth.Value.ToString() != DateOfBirth.MaxDate.ToString()))
            {
                TimeSpan span = (DateTime.Now - DateOfBirth.Value);
                DateTime zeroTime = new DateTime(1, 1, 1);
                int leeftijd = (zeroTime + span).Year - 1;
                ChangeProgresBar(); 
                MessageBox.Show($"Ok, dus jouw leeftijd is {leeftijd}.");
                
            }
        
        }

        private void geslacht_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeProgresBar();
            if (geslacht.SelectedItem.ToString()=="Male")
            {
                Male.Visible = true;
                Female.Visible = false;
            }
            if (geslacht.SelectedItem.ToString() == "Female")
            {
                Male.Visible = false;
                Female.Visible = true;
            }

        }

        private void Name_TextChanged(object sender, EventArgs e)
        {
            ChangeProgresBar();
        }
        private void ChangeProgresBar()
        {
            double progres = 0;
            if (Name.Text != "") { progres += 33.3; }
            if (geslacht.SelectedIndex != -1) { progres += 33.3; }
            if (DateOfBirth.Value != MinimalAgeBirthday) { progres += 33.3; }
            progressBar1.Value = Convert.ToInt32( progres);
        }
    }
}

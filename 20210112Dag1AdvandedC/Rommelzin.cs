using System;
using System.Windows.Forms;

namespace _20210112Dag1AdvandedC
{
    public partial class Rommelzin : Form
    {
        public Rommelzin()
        {
            InitializeComponent();
        }

        private void EnableButtonCheck()
        {
            if (Naam.Text != "" && FavoFilm.Text != "" && FavoKleur.Text != "" && leeftijd.Text!="") 
            { 
                DisplayLabels.Enabled = true;
                DisplayLabels.Text = "Ok, Click Me";
            } else
            {
                DisplayLabels.Text = "Info missing";
            }
            
        }

        private void Naam_TextChanged(object sender, EventArgs e)
        {
            EnableButtonCheck();
        }

        private void FavoFilm_TextChanged(object sender, EventArgs e)
        {
            EnableButtonCheck();
        }

        private void FavoKleur_TextChanged(object sender, EventArgs e)
        {
            EnableButtonCheck();
        }

        private void leeftijd_TextChanged(object sender, EventArgs e)
        {
            EnableButtonCheck();
        }

        private void DisplayLabels_Click(object sender, EventArgs e)
        {
            CorrecteZin.Text = $"Hallo {Naam.Text}, je Favoriete kleur is {FavoKleur.Text}, " +
                $"je favoriete film is {FavoFilm.Text} en je leeftijd is {leeftijd.Text}.";
            RommelZin.Text = $"Hallo {Naam.Text}, je Favoriete kleur is {FavoFilm.Text}, " +
                $"je favoriete film is {leeftijd.Text} en je leeftijd is {FavoKleur.Text}.";
        }
    }
}
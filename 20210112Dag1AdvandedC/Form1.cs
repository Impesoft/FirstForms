using System;
using System.Windows.Forms;

namespace _20210112Dag1AdvandedC
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           var FormChosen = new Rommelzin();
            FormChosen.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
         var   FormChosen = new HowOld();
            FormChosen.ShowDialog();
        }

        private void NummbersQuiz_Click(object sender, EventArgs e)
        {
           var FormChosen = new NumbersQuiz();
            FormChosen.ShowDialog();
        }
    }
}
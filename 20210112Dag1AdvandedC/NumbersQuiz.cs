using System;
using System.Windows.Forms;
namespace _20210112Dag1AdvandedC
{
    public partial class NumbersQuiz : Form
    {
        static int CountDown = 10;

        //public static Label MyTimer;
        static System.Windows.Forms.Timer myTicker = new System.Windows.Forms.Timer();
        static bool done = false;

        public NumbersQuiz()
        {
            InitializeComponent();
        }

        private void NumbersQuiz_Load(object sender, EventArgs e)
        {

            int Min = 1;
            int Max = 60;

            int[] rnd = new int[8];

            Random randNum = new Random();
            for (int i = 0; i < rnd.Length; i++)
            {
                rnd[i] = randNum.Next(Min, Max);
            }
            rnd[3] %= rnd[2];
            if (rnd[3] == 0)
            {
                rnd[3] = randNum.Next(1, rnd[2]);
            }
            rnd[4] %= 15;
            rnd[5] %= 15;
            rnd[7] %= 9;
            rnd[6] *= rnd[7];
            add1.Text = rnd[0].ToString();
            add2.Text = rnd[1].ToString();
            subtract1.Text = rnd[2].ToString();
            subtract2.Text = rnd[3].ToString();
            multiply1.Text = rnd[4].ToString();
            multiply2.Text = rnd[5].ToString();
            divide1.Text = rnd[6].ToString();
            divide2.Text = rnd[7].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetTimer();
            myTicker.Start();
        }

        private  void SetTimer()
        {
            // Create a timer with a two second interval.
            myTicker.Interval = 1000;
            // Hook up the Elapsed event for the timer.
            myTicker.Tick += new EventHandler(OnTimedEvent);
            myTicker.Enabled = true;
            myTimer.Text = Convert.ToString(CountDown);
        }

        private  void OnTimedEvent(Object myObject, EventArgs myEventArgs)
        {

            myTicker.Stop();

           SetMyTime(Convert.ToString(CountDown));
            // Restarts the timer and increments the counter.
            CountDown--;
                myTicker.Enabled = true;
 
        }

        private void SetMyTime(string v)
        {
            myTimer.Text = v;        }

        private void myTimer_TextChanged(object sender, EventArgs e)
        {
            if (myTimer.Text=="0")
            {
                myTicker.Stop();
                myTicker.Enabled = false;
                AnswerAdd.Enabled = false;
                AnswerDivide.Enabled = false;
                AnswerMultiply.Enabled = false;
                AnswerSubtract.Enabled = false;
                MessageBox.Show("Times Up!");
                MessageBox.Show("Checking Answers!");
                CheckAnswers();
            }
        }

        private void CheckAnswers()
        {
            int correctAnswers = 0;
            bool good;
            int addSum = Convert.ToInt32(add1.Text) + Convert.ToInt32(add2.Text);
            good = (addSum == AnswerAdd.Value);
            correctAnswers += (good ? 1 : 0);
            MessageBox.Show(good ? "Right!" : $"Only off by {Math.Abs(addSum - AnswerAdd.Value)}")  ;
        }        
    }
}
﻿using System;
using System.Windows.Forms;

namespace _20210112Dag1AdvandedC
{
    public partial class NumbersQuiz : Form
    {
        private static int CountDown = 60;

        //public static Label MyTimer;
        private static System.Windows.Forms.Timer myTicker = new System.Windows.Forms.Timer();

        public NumbersQuiz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
            if ((rnd[7] %= 9) == 0)
            {
                rnd[7] = 9;
            }
            else
            {
                rnd[7] %= 9;
            }
            rnd[6] *= rnd[7];

            add1.Text = rnd[0].ToString();
            add2.Text = rnd[1].ToString();
            subtract1.Text = rnd[2].ToString();
            subtract2.Text = rnd[3].ToString();
            multiply1.Text = rnd[4].ToString();
            multiply2.Text = rnd[5].ToString();
            divide1.Text = rnd[6].ToString();
            divide2.Text = rnd[7].ToString();
            SetTimer();
            myTicker.Start();
            checkSum.Enabled = true;
            checkSubtract.Enabled = true;
            checkMultiply.Enabled = true;
            checkDivision.Enabled = true;
        }

        private void SetTimer()
        {
            // Create a timer with a two second interval.
            myTicker.Interval = 1000;
            // Hook up the Elapsed event for the timer.
            myTicker.Tick += new EventHandler(OnTimedEvent);
            myTicker.Enabled = true;
            myTimer.Text = Convert.ToString(CountDown);
        }

        private void OnTimedEvent(Object myObject, EventArgs myEventArgs)
        {
            myTicker.Stop();

            SetMyTime(Convert.ToString(CountDown));
            // Restarts the timer and increments the counter.
            CountDown--;
            myTicker.Enabled = true;
        }

        private void SetMyTime(string TimeLeft)
        {
            myTimer.Text = TimeLeft;
        }

        private void myTimer_TextChanged(object sender, EventArgs e)
        {
            if (myTimer.Text == "0")
            {
                myTicker.Tick -= OnTimedEvent;
                myTicker.Stop();
                myTicker.Enabled = false;
                AnswerAdd.Enabled = false;
                AnswerDivide.Enabled = false;
                AnswerMultiply.Enabled = false;
                AnswerSubtract.Enabled = false;
                checkSum.Enabled = false;
                checkSubtract.Enabled = false;
                checkMultiply.Enabled = false;
                checkDivision.Enabled = false;
                MessageBox.Show("Times Up!\nPress OK to Check the Answers.");
                CheckAnswers();
            }
        }

        private void CheckAnswers()
        {
            int correctAnswers = Convert.ToInt32(score.Text);
            correctAnswers += (CheckSum() ? 1 : 0);
            correctAnswers += (CheckSubtract() ? 1 : 0);
            correctAnswers += (CheckMultiply() ? 1 : 0);
            correctAnswers += (CheckDivide() ? 1 : 0);
            score.Text = correctAnswers.ToString();
        }

        private bool CheckSum()
        {
            bool good;
            int addSum = Convert.ToInt32(add1.Text) + Convert.ToInt32(add2.Text);
            good = (addSum == AnswerAdd.Value);

            MessageBox.Show(good ? "Sum is Right!" : $"Sum is only off by {Math.Abs(addSum - AnswerAdd.Value)}");

            if (good)
            {
                // set new values
                int Min = 1;
                int Max = 60;
                int[] rnd = new int[8];

                Random randNum = new Random();

                add1.Text = randNum.Next(Min, Max).ToString();
                add2.Text = randNum.Next(Min, Max).ToString();
                randNum.Next(Min, Max);
            }
            return good;
        }

        private bool CheckSubtract()
        {
            bool good;
            int subDiff = Convert.ToInt32(subtract1.Text) - Convert.ToInt32(subtract2.Text);
            good = (subDiff == AnswerSubtract.Value);

            MessageBox.Show(good ? "Difference is Right!" : $"Difference is only off by {Math.Abs(subDiff - AnswerSubtract.Value)}");
            if (good)
            {
                // set new values
                int Min = 1;
                int Max = 60;
                int[] rnd = new int[8];

                Random randNum = new Random();

                add1.Text = randNum.Next(Min, Max).ToString();
                add2.Text = randNum.Next(Min, Max).ToString();
                randNum.Next(Min, Max);
            }
            return good;
        }

        private bool CheckMultiply()
        {
            bool good;
            int mulProd = Convert.ToInt32(multiply1.Text) * Convert.ToInt32(multiply2.Text);
            good = (mulProd == AnswerMultiply.Value);

            MessageBox.Show(good ? "Product is Right!" : $"Product is only off by {Math.Abs(mulProd - AnswerMultiply.Value)}");
            return good;
        }

        private bool CheckDivide()
        {
            bool good;
            int divQuot = Convert.ToInt32(divide1.Text) / Convert.ToInt32(divide2.Text);
            good = (divQuot == AnswerDivide.Value);

            MessageBox.Show(good ? "Quotient is Right!" : $"Quotient is only off by {Math.Abs(divQuot - AnswerDivide.Value)}");
            return good;
        }

        private void checkSum_Click(object sender, EventArgs e)
        {
            int correctAnswers = Convert.ToInt32(score.Text);
            correctAnswers += (CheckSum() ? 1 : 0);
            //      correctAnswers += (CheckSubtract() ? 1 : 0);
            //     correctAnswers += (CheckMultiply() ? 1 : 0);
            //   correctAnswers += (CheckDivide() ? 1 : 0);
            score.Text = correctAnswers.ToString();
        }

        private void checkSubtract_Click(object sender, EventArgs e)
        {
            int correctAnswers = Convert.ToInt32(score.Text);
            //correctAnswers += (CheckSum() ? 1 : 0);
            correctAnswers += (CheckSubtract() ? 1 : 0);
            //     correctAnswers += (CheckMultiply() ? 1 : 0);
            //   correctAnswers += (CheckDivide() ? 1 : 0);
            score.Text = correctAnswers.ToString();
        }

        private void checkMultiply_Click(object sender, EventArgs e)
        {
            int correctAnswers = Convert.ToInt32(score.Text);
            //correctAnswers += (CheckSum() ? 1 : 0);
            //correctAnswers += (CheckSubtract() ? 1 : 0);
            correctAnswers += (CheckMultiply() ? 1 : 0);
            //   correctAnswers += (CheckDivide() ? 1 : 0);
            score.Text = correctAnswers.ToString();
        }

        private void checkDivision_Click(object sender, EventArgs e)
        {
            int correctAnswers = Convert.ToInt32(score.Text);
            //correctAnswers += (CheckSum() ? 1 : 0);
            //correctAnswers += (CheckSubtract() ? 1 : 0);
            //  correctAnswers += (CheckMultiply() ? 1 : 0);
            correctAnswers += (CheckDivide() ? 1 : 0);
            score.Text = correctAnswers.ToString();
        }
    }
}
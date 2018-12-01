using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimedMathTest
{
    public partial class mathQuiz : Form
    {
        Random randomizer = new Random();
        bool gameStarted = new Boolean();
        Int32 plusFinalValue = new Int32();
        Int32 minusFinalValue = new Int32();
        Int32 multiplyFinalValue = new Int32();
        Int32 divideFinalValue = new Int32();
        Int32 actualTime = new Int32();
        private void ResetVariables()
        {
            plusLeftLabel.Text = "?";
            plusRightLabel.Text = "?";
            minusLeftLabel.Text = "?";
            minusRightLabel.Text = "?";
            multiplyLeftLabel.Text = "?";
            multiplyRightLabel.Text = "?";
            divideLeftLabel.Text = "?";
            divideRightLabel.Text = "?";
            timeBar.Value = 0;
            timeValue.Text = "∞";
            plusSolution.Value = 0;
            minusSolution.Value = 0;
            multiplySolution.Value = 0;
            divideSolution.Value = 0;
            userInteractable.Text = "Start Quiz";
            actualTime = 60;
            timeBar.Maximum = actualTime * 60;
            timerQuiz.Enabled = false;
            timerBarSecond.Enabled = false;
            timeValue.Location = new Point(154, 70);
            timeValue.Size = new Size(634, 34);
        }
        private Int32 TimerFunction(Int32 Time)
        {
            Time -= 1;
            timeValue.Text = $"{Convert.ToString(Time)} seconds left!";
            return Time;
        }
        private Int32 PlusQuiz
        {
            get
            {
                Int32 plusLeft = randomizer.Next(0, 500);
                plusLeftLabel.Text = Convert.ToString(plusLeft);
                Int32 plusRight = randomizer.Next(0, 500);
                plusRightLabel.Text = Convert.ToString(plusRight);
                return plusLeft + plusRight;
            }
        }
        private Int32 MinusQuiz
        {
            get
            {
                Int32 minusLeft = randomizer.Next(0, 500);
                minusLeftLabel.Text = Convert.ToString(minusLeft);
                Int32 minusRight = randomizer.Next(0, minusLeft);
                minusRightLabel.Text = Convert.ToString(minusRight);
                return minusLeft - minusRight;
            }
        }
        private Int32 MultiplyQuiz
        {
            get
            {
                Int32 multiplyLeft = randomizer.Next(0, 500);
                multiplyLeftLabel.Text = Convert.ToString(multiplyLeft);
                Int32 multiplyRight = randomizer.Next(0, 500);
                multiplyRightLabel.Text = Convert.ToString(multiplyRight);
                return multiplyLeft * multiplyRight;
            }
        }
        private Int32 DivideQuiz
        {
            get
            {
                Int32 divideLeft = 1;
                Int32 divideRight = 2;
                while (divideLeft % divideRight != 0)
                {
                    divideLeft = randomizer.Next(1, 500);
                    divideLeftLabel.Text = Convert.ToString(divideLeft);
                    divideRight = randomizer.Next(1, divideLeft);
                    divideRightLabel.Text = Convert.ToString(divideRight);
                }
                return divideLeft / divideRight;
            }
        }
        public mathQuiz()
        {
            InitializeComponent();
            ResetVariables();
            this.KeyPreview = true;
        }
        private void userInteractable_Click(object sender, EventArgs e)
        {
            Int16 quizPoints = new Int16();
            if (gameStarted == false)
            {
                timeValue.Text = $"{Convert.ToString(actualTime)} seconds left!";
                plusFinalValue = PlusQuiz;
                minusFinalValue = MinusQuiz;
                multiplyFinalValue = MultiplyQuiz;
                divideFinalValue = DivideQuiz;
                userInteractable.Text = "Send Results";
                timerBarSecond.Enabled = true;
                timerQuiz.Enabled = true;
            }
            else
            {
                if (plusSolution.Value == plusFinalValue)
                {
                    quizPoints += 25;
                }
                if (minusSolution.Value == minusFinalValue)
                {
                    quizPoints += 25;
                }
                if (multiplySolution.Value == multiplyFinalValue)
                {
                    quizPoints += 25;
                }
                if (divideSolution.Value == divideFinalValue)
                {
                    quizPoints += 25;
                }
                switch (quizPoints)
                {
                    case 25:
                        {
                            MessageBox.Show("1/4");
                        }
                        break;
                    case 50:
                        {
                            MessageBox.Show("2/4");
                        }
                        break;
                    case 75:
                        {
                            MessageBox.Show("3/4");
                        }
                        break;
                    case 100:
                        {
                            MessageBox.Show("4/4");
                        }
                        break;
                    default:
                        {
                            MessageBox.Show("0/4");
                        }
                        break;

                }
                ResetVariables();
            }
            gameStarted = !gameStarted;
        }
        private void timerQuiz_Tick(object sender, EventArgs e)
        {
            actualTime = TimerFunction(actualTime);
            if (actualTime == 0)
            {
                timerQuiz.Enabled = false;
                timeValue.Location = new Point(18, 27);
                timeValue.Size = new Size(770, 77);
                timeValue.Text = "Time's up!";
                userInteractable.PerformClick();
            }
        }
        private void timerBarSecond_Tick(object sender, EventArgs e)
        {
            timeBar.Increment(1);
        }
    }
}

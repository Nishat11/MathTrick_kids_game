using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
using System.Xml;

namespace WindowsFormsApplication3
{
    public partial class ThreeDigitSquare : Form
    {
        Constants con = new Constants();
        public ThreeDigitSquare()
        {
            InitializeComponent();
        }
        //To clear textbox controls and to set focus on the first text box
        void ClearControls()
        {

            ThreeDigitSquareAns1.Clear();
            ThreeDigitSquareAns2.Clear();
            ThreeDigitSquareAns3.Clear();
            ThreeDigitSquareAns4.Clear();

            ThreeDigitSquareAns1.Focus();
        }

        //To make controls invisible
        void InVisibleControls()
        {
            TrickThreeDigitSquarebtnCorrect1.Visible = false;
            TrickThreeDigitSquarebtnCorrect2.Visible = false;
            TrickThreeDigitSquarebtnCorrect3.Visible = false;
            TrickThreeDigitSquarebtnCorrect4.Visible = false;
            ThreeDigitSquarebtnIncorrect1.Visible = false;
            ThreeDigitSquarebtnIncorrect2.Visible = false;
            ThreeDigitSquarebtnIncorrect3.Visible = false;
            ThreeDigitSquarebtnIncorrect4.Visible = false;
            ThreeDigitSquarebtnSubmit.Visible = false;

            ThreeDigitSquarebtnLightBulb1.Visible = false;
            ThreeDigitSquarebtnLightBulb2.Visible = false;
            ThreeDigitSquarebtnLightBulb3.Visible = false;
            ThreeDigitSquarebtnLightBulb4.Visible = false;
        }

        private void ThreeDigitSquarebtn_home_Click(object sender, EventArgs e)
        {
            con.home.Show();
            this.Dispose();
        }

        private void ThreeDigitSquare_Load(object sender, EventArgs e)
        {
            ThreeDigitSquareHintBox.Visible = true;
            InVisibleControls();
            ThreeDigitSquareAns1.Focus();
        }

        private void ThreeDigitSquarebtnLightBulb1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oops ! Wrong Answer, The Correct Answer is:" + 167281 + "\n Please follow the instructions and try again");
        }

        private void ThreeDigitSquarebtnLightBulb2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oops ! Wrong Answer, The Correct Answer is:" + 105625 + "\n Please follow the instructions and try again");
        }

        private void ThreeDigitSquarebtnLightBulb3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oops ! Wrong Answer, The Correct Answer is:" + 366025 + "\n Please follow the instructions and try again");
        }

        private void ThreeDigitSquarebtnLightBulb4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oops ! Wrong Answer, The Correct Answer is:" + 93025 + "\n Please follow the instructions and try again");
        }

        private void ThreeDigitSquareAns1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ' '))
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Only Numeric value");
            }
        }

        private void ThreeDigitSquareAns2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ' '))
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Only Numeric value");
            }
        }

        private void ThreeDigitSquareAns3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ' '))
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Only Numeric value");
            }
        }

        private void ThreeDigitSquareAns4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ' '))
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Only Numeric value");
            }
        }

        private void ThreeDigitSquarebtnSubmit_Click(object sender, EventArgs e)
        {
            ThreeDigitSquareAns1.Enabled = false;
            ThreeDigitSquareAns2.Enabled = false;
            ThreeDigitSquareAns3.Enabled = false;
            ThreeDigitSquareAns4.Enabled = false;

            if (ThreeDigitSquareAns1.Text != "" && ThreeDigitSquareAns2.Text != "" &&
                ThreeDigitSquareAns3.Text != "" && ThreeDigitSquareAns4.Text != "")

            {
                ThreeDigitSquareHintBox.Visible = false;
                Trick_7_11_13_GroupBoxAnsLables.Visible = true;
                double ans1, ans2, ans3, ans4, res1, res2, res3, res4;
                int countans = 0;

                ans1 = double.Parse(ThreeDigitSquareAns1.Text);
                res1 = 167281;

                if (ans1 == res1)
                {
                    countans++;
                    TrickThreeDigitSquarebtnCorrect1.Visible = true;
                    TrickThreeDigitSquarebtnCorrect1.Enabled = false;
                }
                else
                {
                    ThreeDigitSquarebtnIncorrect1.Visible = true;
                    ThreeDigitSquarebtnLightBulb1.Visible = true;
                    ThreeDigitSquarebtn_TryAgain.Visible = true;
                }

                ans2 = double.Parse(ThreeDigitSquareAns2.Text);
                res2 = 105625;

                if (ans2 == res2)
                {
                    countans++;
                    TrickThreeDigitSquarebtnCorrect2.Visible = true;
                    TrickThreeDigitSquarebtnCorrect2.Enabled = false;
                }
                else
                {
                    ThreeDigitSquarebtnIncorrect2.Visible = true;
                    ThreeDigitSquarebtnLightBulb2.Visible = true;
                    ThreeDigitSquarebtn_TryAgain.Visible = true;
                }

                ans3 = double.Parse(ThreeDigitSquareAns3.Text);
                res3 = 366025;

                if (ans3 == res3)
                {
                    countans++;
                    TrickThreeDigitSquarebtnCorrect3.Visible = true;
                    TrickThreeDigitSquarebtnCorrect3.Enabled = false;
                }
                else
                {
                    ThreeDigitSquarebtnIncorrect3.Visible = true;
                    ThreeDigitSquarebtnLightBulb3.Visible = true;
                    ThreeDigitSquarebtn_TryAgain.Visible = true;
                }

                ans4 = double.Parse(ThreeDigitSquareAns4.Text);
                res4 = 93025;

                if (ans4 == res4)
                {
                    countans++;
                    TrickThreeDigitSquarebtnCorrect4.Visible = true;
                    TrickThreeDigitSquarebtnCorrect4.Enabled = false;
                }
                else
                {
                    ThreeDigitSquarebtnIncorrect4.Visible = true;
                    ThreeDigitSquarebtnLightBulb4.Visible = true;
                    ThreeDigitSquarebtn_TryAgain.Visible = true;
                }

                //Check for Stars
                int countstars = 1;
                if (countans == 3)
                {
                    con.home.Update_xml(16, countstars);
                }
                else if (countans == 4)
                {
                    countstars++;
                    con.home.Update_xml(16, countstars);
                }

                //Check for quiz successfully completed or not
                if (countans >= 3)
                {
                    MessageBox.Show("Congratulations! Quiz Successfully Completed", "Greetings!", MessageBoxButtons.OK, MessageBoxIcon.None);
                    ThreeDigitSquarebtn_TryAgain.Visible = false;
                    ThreeDigitSquarebtnSubmit.Visible = false;
                }
                else
                {
                    MessageBox.Show("You need to get at least three correct answers to pass a quiz", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.home.Update_xml(16, countstars);
                }
            }
            else
            {
                MessageBox.Show("You must attempt all the questions", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ThreeDigitSquareAns4_TextChanged(object sender, EventArgs e)
        {
            ThreeDigitSquarebtnSubmit.Visible = true;
        }

        private void ThreeDigitSquarebtn_TryAgain_Click(object sender, EventArgs e)
        {
            ThreeDigitSquareAns1.Enabled = true;
            ThreeDigitSquareAns2.Enabled = true;
            ThreeDigitSquareAns3.Enabled = true;
            ThreeDigitSquareAns4.Enabled = true;
            ThreeDigitSquareAns1.Focus();

            ThreeDigitSquarebtn_TryAgain.Visible = false;
            Trick_7_11_13_GroupBoxAnsLables.Visible = false;
            ThreeDigitSquareHintBox.Visible = true;

            ClearControls();

            TrickThreeDigitSquarebtnCorrect1.Visible = true;
            TrickThreeDigitSquarebtnCorrect2.Visible = true;
            TrickThreeDigitSquarebtnCorrect3.Visible = true;
            TrickThreeDigitSquarebtnCorrect4.Visible = true;
            ThreeDigitSquarebtnIncorrect1.Visible = true;
            ThreeDigitSquarebtnIncorrect2.Visible = true;
            ThreeDigitSquarebtnIncorrect3.Visible = true;
            ThreeDigitSquarebtnIncorrect4.Visible = true;
            ThreeDigitSquarebtnLightBulb1.Visible = true;
            ThreeDigitSquarebtnLightBulb2.Visible = true;
            ThreeDigitSquarebtnLightBulb3.Visible = true;
            ThreeDigitSquarebtnLightBulb4.Visible = true;
            ThreeDigitSquarebtnSubmit.Visible = true;

            InVisibleControls();
        }
    }
    }

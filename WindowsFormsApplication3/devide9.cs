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
    public partial class devide9 : Form
    {
        Constants con = new Constants();
        public devide9()
        {
            InitializeComponent();
        }
        //To clear textbox controls and to set focus on the first text box
        void ClearControls()
        {

            DevideBy9Ans1.Clear();
            DevideBy9Ans2.Clear();
            DevideBy9Ans3.Clear();
            DevideBy9Ans4.Clear();

            DevideBy9Ans1.Focus();
        }

        //To make controls invisible
        void InVisibleControls()
        {
            DevideBy9btnCorrect1.Visible = false;
            DevideBy9btnCorrect2.Visible = false;
            DevideBy9btnCorrect3.Visible = false;
            DevideBy9btnCorrect4.Visible = false;
            DevideBy9btnIncorrect1.Visible = false;
            DevideBy9btnIncorrect2.Visible = false;
            DevideBy9btnIncorrect3.Visible = false;
            DevideBy9btnIncorrect4.Visible = false;
            DevideBy9btnSubmit.Visible = false;

            DevideBy9btnLightBulb1.Visible = false;
            DevideBy9btnLightBulb2.Visible = false;
            DevideBy9btnLightBulb3.Visible = false;
            DevideBy9btnLightBulb4.Visible = false;
        }

        private void DevideBy9btn_home_Click(object sender, EventArgs e)
        {
            con.home.Show();
            this.Dispose();
        }

        private void devide9_Load(object sender, EventArgs e)
        {
            DevideBy9HintBox.Visible = true;
            InVisibleControls();
            DevideBy9Ans1.Focus();
        }

        private void DevideBy9btnLightBulb1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oops ! Wrong Answer, The Correct Answer is:" + 8 + "\n Please follow the instructions and try again");

        }

        private void DevideBy9btnLightBulb2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oops ! Wrong Answer, The Correct Answer is:" + 4 + "\n Please follow the instructions and try again");
        }

        private void DevideBy9btnLightBulb3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oops ! Wrong Answer, The Correct Answer is:" + 7 + "\n Please follow the instructions and try again");
        }

        private void DevideBy9btnLightBulb4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oops ! Wrong Answer, The Correct Answer is:" + 9 + "\n Please follow the instructions and try again");
        }

        private void DevideBy9Ans1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Only Numeric value");
            }
        }

        private void DevideBy9Ans2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Only Numeric value");
            }
        }

        private void DevideBy9Ans3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Only Numeric value");
            }
        }

        private void DevideBy9Ans4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Only Numeric value");
            }
        }

        private void DevideBy9btnSubmit_Click(object sender, EventArgs e)
        {
            DevideBy9Ans1.Enabled = false;
            DevideBy9Ans2.Enabled = false;
            DevideBy9Ans3.Enabled = false;
            DevideBy9Ans4.Enabled = false;

            if (DevideBy9Ans1.Text != "" && DevideBy9Ans2.Text != "" &&
                DevideBy9Ans3.Text != "" && DevideBy9Ans4.Text != "")

            {
                DevideBy9HintBox.Visible = false;
                Trick_7_11_13_GroupBoxAnsLables.Visible = true;
                double ans1, ans2, ans3, ans4, res1, res2, res3, res4;
                int countans = 0;

                ans1 = double.Parse(DevideBy9Ans1.Text);
                res1 = 8;

                if (ans1 == res1)
                {
                    countans++;
                    DevideBy9btnCorrect1.Visible = true;
                    DevideBy9btnCorrect1.Enabled = false;
                }
                else
                {
                    DevideBy9btnIncorrect1.Visible = true;
                    DevideBy9btnLightBulb1.Visible = true;
                    DevideBy9btn_TryAgain.Visible = true;
                }

                ans2 = double.Parse(DevideBy9Ans2.Text);
                res2 = 4;

                if (ans2 == res2)
                {
                    countans++;
                    DevideBy9btnCorrect2.Visible = true;
                    DevideBy9btnCorrect2.Enabled = false;
                }
                else
                {
                    DevideBy9btnIncorrect2.Visible = true;
                    DevideBy9btnLightBulb2.Visible = true;
                    DevideBy9btn_TryAgain.Visible = true;
                }

                ans3 = double.Parse(DevideBy9Ans3.Text);
                res3 = 7;

                if (ans3 == res3)
                {
                    countans++;
                    DevideBy9btnCorrect3.Visible = true;
                    DevideBy9btnCorrect3.Enabled = false;
                }
                else
                {
                    DevideBy9btnIncorrect3.Visible = true;
                    DevideBy9btnLightBulb3.Visible = true;
                    DevideBy9btn_TryAgain.Visible = true;
                }

                ans4 = double.Parse(DevideBy9Ans4.Text);
                res4 = 9;

                if (ans4 == res4)
                {
                    countans++;
                    DevideBy9btnCorrect4.Visible = true;
                    DevideBy9btnCorrect4.Enabled = false;
                }
                else
                {
                    DevideBy9btnIncorrect4.Visible = true;
                    DevideBy9btnLightBulb4.Visible = true;
                    DevideBy9btn_TryAgain.Visible = true;
                }

                //Check for Stars
                int countstars = 1;
                if (countans == 3)
                {
                    con.home.Update_xml(13, countstars);
                }
                else if (countans == 4)
                {
                    countstars++;
                    con.home.Update_xml(13, countstars);
                }

                //Check for quiz successfully completed or not
                if (countans >= 3)
                {
                    MessageBox.Show("Congratulations! Quiz Successfully Completed", "Greetings!", MessageBoxButtons.OK, MessageBoxIcon.None);
                    DevideBy9btn_TryAgain.Visible = false;
                    DevideBy9btnSubmit.Visible = false;
                }
                else
                {
                    MessageBox.Show("You need to get at least three correct answers to pass a quiz", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
            }
            else
            {
                MessageBox.Show("You must attempt all the questions", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DevideBy9Ans4_TextChanged(object sender, EventArgs e)
        {
            DevideBy9btnSubmit.Visible = true;
        }

        private void DevideBy9btn_TryAgain_Click(object sender, EventArgs e)
        {
            DevideBy9Ans1.Enabled = true;
            DevideBy9Ans2.Enabled = true;
            DevideBy9Ans3.Enabled = true;
            DevideBy9Ans4.Enabled = true;
            DevideBy9Ans1.Focus();

            DevideBy9btn_TryAgain.Visible = false;
            Trick_7_11_13_GroupBoxAnsLables.Visible = false;
            DevideBy9HintBox.Visible = true;

            ClearControls();

            DevideBy9btnCorrect1.Visible = true;
            DevideBy9btnCorrect2.Visible = true;
            DevideBy9btnCorrect3.Visible = true;
            DevideBy9btnCorrect4.Visible = true;
            DevideBy9btnIncorrect1.Visible = true;
            DevideBy9btnIncorrect2.Visible = true;
            DevideBy9btnIncorrect3.Visible = true;
            DevideBy9btnIncorrect4.Visible = true;
            DevideBy9btnLightBulb1.Visible = true;
            DevideBy9btnLightBulb2.Visible = true;
            DevideBy9btnLightBulb3.Visible = true;
            DevideBy9btnLightBulb4.Visible = true;
            DevideBy9btnSubmit.Visible = true;

            InVisibleControls();
        }
    }
    }



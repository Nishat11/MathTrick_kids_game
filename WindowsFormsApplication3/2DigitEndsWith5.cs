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
    public partial class TwoDigitEndsWith5 : Form
    {
        Constants con = new Constants();
        public TwoDigitEndsWith5()
        {
            InitializeComponent();
        }

        //To clear textbox controls and to set focus on the first text box
        void ClearControls()
        {

            txtTrick2digitwith5Ans1.Clear();
            txtTrick2digitwith5Ans2.Clear();
            txtTrick2digitwith5Ans3.Clear();
            txtTrick2digitwith5Ans4.Clear();

            txtTrick2digitwith5Ans1.Focus();
        }

        //To make controls invisible
        void InVisibleControls()
        {
            Trick2digitwith5btnCorrect1.Visible = false;
            Trick2digitwith5btnCorrect2.Visible = false;
            Trick2digitwith5btnCorrect3.Visible = false;
            Trick2digitwith5btnCorrect4.Visible = false;
            Trick2digitwith5btnIncorrect1.Visible = false;
            Trick2digitwith5btnIncorrect2.Visible = false;
            Trick2digitwith5btnIncorrect3.Visible = false;
            Trick2digitwith5btnIncorrect4.Visible = false;
            Trick2digitwith5btnSubmit.Visible = false;

            Trick2digitwith5btnLightBulb1.Visible = false;
            Trick2digitwith5btnLightBulb2.Visible = false;
            Trick2digitwith5btnLightBulb3.Visible = false;
            Trick2digitwith5btnLightBulb4.Visible = false;
        }

        private void Trick2digitwith5btn_home_Click(object sender, EventArgs e)
        {
            con.home.Show();
            this.Dispose();
        }

        private void TwoDigitEndsWith5_Load(object sender, EventArgs e)
        {
            Trick2digitwith5HintBox.Visible = true;
            InVisibleControls();
            txtTrick2digitwith5Ans1.Focus();
        }

        private void Trick2digitwith5btnLightBulb1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oops ! Wrong Answer, The Correct Answer is:" + 8.33 + "\n Please follow the instructions and try again");
        }

        private void Trick2digitwith5btnLightBulb2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oops ! Wrong Answer, The Correct Answer is:" + 2025 + "\n Please follow the instructions and try again");
        }

        private void Trick2digitwith5btnLightBulb3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oops ! Wrong Answer, The Correct Answer is:" + 1225 + "\n Please follow the instructions and try again");
        }

        private void Trick2digitwith5btnLightBulb4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oops ! Wrong Answer, The Correct Answer is:" + 5625 + "\n Please follow the instructions and try again");
        }

        private void txtTrick2digitwith5Ans1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ' '))
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Only Numeric value");
            }
        }

        private void txtTrick2digitwith5Ans2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ' '))
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Only Numeric value");
            }
        }

        private void txtTrick2digitwith5Ans3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ' '))
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Only Numeric value");
            }
        }

        private void txtTrick2digitwith5Ans4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ' '))
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Only Numeric value");
            }
        }

        private void Trick2digitwith5btnSubmit_Click(object sender, EventArgs e)
        {
            txtTrick2digitwith5Ans1.Enabled = false;
            txtTrick2digitwith5Ans2.Enabled = false;
            txtTrick2digitwith5Ans3.Enabled = false;
            txtTrick2digitwith5Ans4.Enabled = false;

            if (txtTrick2digitwith5Ans1.Text != "" && txtTrick2digitwith5Ans2.Text != "" &&
                txtTrick2digitwith5Ans3.Text != "" && txtTrick2digitwith5Ans4.Text != "")

            {
                Trick2digitwith5HintBox.Visible = false;
                Trick_7_11_13_GroupBoxAnsLables.Visible = true;
                double ans1, ans2, ans3, ans4, res1, res2, res3, res4;
                int countans = 0;

                ans1 = double.Parse(txtTrick2digitwith5Ans1.Text);
                res1 = 3025;

                if (ans1 == res1)
                {
                    countans++;
                    Trick2digitwith5btnCorrect1.Visible = true;
                    Trick2digitwith5btnCorrect1.Enabled = false;
                }
                else
                {
                    Trick2digitwith5btnIncorrect1.Visible = true;
                    Trick2digitwith5btnLightBulb1.Visible = true;
                    Trick2digitwith5btn_TryAgain.Visible = true;
                }

                ans2 = double.Parse(txtTrick2digitwith5Ans2.Text);
                res2 = 2025;

                if (ans2 == res2)
                {
                    countans++;
                    Trick2digitwith5btnCorrect2.Visible = true;
                    Trick2digitwith5btnCorrect2.Enabled = false;
                }
                else
                {
                    Trick2digitwith5btnCorrect2.Visible = true;
                    Trick2digitwith5btnLightBulb2.Visible = true;
                    Trick2digitwith5btn_TryAgain.Visible = true;
                }

                ans3 = double.Parse(txtTrick2digitwith5Ans3.Text);
                res3 = 1225;

                if (ans3 == res3)
                {
                    countans++;
                    Trick2digitwith5btnCorrect3.Visible = true;
                    Trick2digitwith5btnCorrect3.Enabled = false;
                }
                else
                {
                    Trick2digitwith5btnIncorrect3.Visible = true;
                    Trick2digitwith5btnLightBulb3.Visible = true;
                    Trick2digitwith5btn_TryAgain.Visible = true;
                }

                ans4 = double.Parse(txtTrick2digitwith5Ans4.Text);
                res4 = 5625;

                if (ans4 == res4)
                {
                    countans++;
                    Trick2digitwith5btnCorrect4.Visible = true;
                    Trick2digitwith5btnCorrect4.Enabled = false;
                }
                else
                {
                    Trick2digitwith5btnIncorrect4.Visible = true;
                    Trick2digitwith5btnLightBulb4.Visible = true;
                    Trick2digitwith5btn_TryAgain.Visible = true;
                }

                //Check for Stars
                int countstars = 1;
                if (countans == 3)
                {
                    con.home.Update_xml(12, countstars);
                }
                else if (countans == 4)
                {
                    countstars++;
                    con.home.Update_xml(12, countstars);
                }

                //Check for quiz successfully completed or not
                if (countans >= 3)
                {
                    MessageBox.Show("Congratulations! Quiz Successfully Completed", "Greetings!", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Trick2digitwith5btn_TryAgain.Visible = false;
                    Trick2digitwith5btnSubmit.Visible = false;
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

        private void txtTrick2digitwith5Ans4_TextChanged(object sender, EventArgs e)
        {
            Trick2digitwith5btnSubmit.Visible = true;
        }

        private void Trick2digitwith5btn_TryAgain_Click(object sender, EventArgs e)
        {
            txtTrick2digitwith5Ans1.Enabled = true;
            txtTrick2digitwith5Ans2.Enabled = true;
            txtTrick2digitwith5Ans3.Enabled = true;
            txtTrick2digitwith5Ans4.Enabled = true;
            txtTrick2digitwith5Ans1.Focus();

            Trick2digitwith5btn_TryAgain.Visible = false;
            Trick_7_11_13_GroupBoxAnsLables.Visible = false;
            Trick2digitwith5HintBox.Visible = true;

            ClearControls();

            Trick2digitwith5btnCorrect1.Visible = true;
            Trick2digitwith5btnCorrect2.Visible = true;
            Trick2digitwith5btnCorrect3.Visible = true;
            Trick2digitwith5btnCorrect4.Visible = true;
            Trick2digitwith5btnIncorrect1.Visible = true;
            Trick2digitwith5btnIncorrect2.Visible = true;
            Trick2digitwith5btnIncorrect3.Visible = true;
            Trick2digitwith5btnIncorrect4.Visible = true;
            Trick2digitwith5btnLightBulb1.Visible = true;
            Trick2digitwith5btnLightBulb2.Visible = true;
            Trick2digitwith5btnLightBulb3.Visible = true;
            Trick2digitwith5btnLightBulb4.Visible = true;
            Trick2digitwith5btnSubmit.Visible = true;

            InVisibleControls();
        }
    }
}

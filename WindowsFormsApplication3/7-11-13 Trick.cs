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
    public partial class Trick_7_11_13 : Form
    {
        Constants con = new Constants();
        public Trick_7_11_13()
        {
            InitializeComponent();
        }
        
        private void Trick_7_11_13btn_TryAgain_Click(object sender, EventArgs e)
        {
            txtTrick7_11_13Ans1.Enabled = true;
            txtTrick7_11_13Ans2.Enabled = true;
            txtTrick7_11_13Ans3.Enabled = true;
            txtTrick7_11_13Ans4.Enabled = true;
            txtTrick7_11_13Ans1.Focus();

            Trick_7_11_13btn_TryAgain.Visible = false;
            Trick_7_11_13_GroupBoxAnsLables.Visible = false;
            Trick7_11_13HintBox.Visible = true;

            ClearControls();

            Trick_7_11_13btnCorrect1.Visible = true;
            Trick_7_11_13btnCorrect2.Visible = true;
            Trick_7_11_13btnCorrect3.Visible = true;
            Trick_7_11_13btnCorrect4.Visible = true;
            Trick_7_11_13btnIncorrect1.Visible = true;
            Trick_7_11_13btnIncorrect2.Visible = true;
            Trick_7_11_13btnIncorrect3.Visible = true;
            Trick_7_11_13btnIncorrect4.Visible = true;
            Trick_7_11_13btnLightBulb1.Visible = true;
            Trick_7_11_13btnLightBulb2.Visible = true;
            Trick_7_11_13btnLightBulb3.Visible = true;
            Trick_7_11_13btnLightBulb4.Visible = true;
            Trick_7_11_13btnSubmit.Visible = true;

            InVisibleControls();
        }

        void ClearControls()
        {

            txtTrick7_11_13Ans1.Clear();
            txtTrick7_11_13Ans2.Clear();
            txtTrick7_11_13Ans3.Clear();
            txtTrick7_11_13Ans4.Clear();

            txtTrick7_11_13Ans1.Focus();
        }

        void InVisibleControls()
        {
            Trick_7_11_13btnCorrect1.Visible = false;
            Trick_7_11_13btnCorrect2.Visible = false;
            Trick_7_11_13btnCorrect3.Visible = false;
            Trick_7_11_13btnCorrect4.Visible = false;
            Trick_7_11_13btnIncorrect1.Visible = false;
            Trick_7_11_13btnIncorrect2.Visible = false;
            Trick_7_11_13btnIncorrect3.Visible = false;
            Trick_7_11_13btnIncorrect4.Visible = false;
            Trick_7_11_13btnSubmit.Visible = false;

            Trick_7_11_13btnLightBulb1.Visible = false;
            Trick_7_11_13btnLightBulb2.Visible = false;
            Trick_7_11_13btnLightBulb3.Visible = false;
            Trick_7_11_13btnLightBulb4.Visible = false;
        }

        private void Trick_7_11_13btn_home_Click(object sender, EventArgs e)
        {
            con.home.Show();
            this.Dispose();
        }

        private void Trick_7_11_13_Load(object sender, EventArgs e)
        {
            Trick7_11_13HintBox.Visible = true;
            InVisibleControls();
            txtTrick7_11_13Ans1.Focus();
        }

        private void Trick_7_11_13btnLightBulb2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oops ! Wrong Answer, The Correct Answer is:" + 789789 + "\n Please follow the instructions and try again");

        }

        private void Trick_7_11_13btnLightBulb3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oops ! Wrong Answer, The Correct Answer is:" + 999999 + "\n Please follow the instructions and try again");

        }

        private void Trick_7_11_13btnLightBulb4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oops ! Wrong Answer, The Correct Answer is:" + 653653 + "\n Please follow the instructions and try again");

        }

        private void Trick_7_11_13btnSubmit_Click(object sender, EventArgs e)
        {
            txtTrick7_11_13Ans1.Enabled = false;
            txtTrick7_11_13Ans2.Enabled = false;
            txtTrick7_11_13Ans3.Enabled = false;
            txtTrick7_11_13Ans4.Enabled = false;

            if (txtTrick7_11_13Ans1.Text!="" && txtTrick7_11_13Ans2.Text!="" &&
                txtTrick7_11_13Ans3.Text != "" && txtTrick7_11_13Ans4.Text != "")

           {
                Trick7_11_13HintBox.Visible = false;
                Trick_7_11_13_GroupBoxAnsLables.Visible = true;
                double ans1, ans2, ans3, ans4, res1, res2, res3, res4;
                int countans = 0;

                ans1 = double.Parse(txtTrick7_11_13Ans1.Text);
                res1 = 123123;

                if (ans1 == res1)
                {
                    countans++;
                    Trick_7_11_13btnCorrect1.Visible = true;
                    Trick_7_11_13btnCorrect1.Enabled = false;
                }
                else
                {
                    Trick_7_11_13btnIncorrect1.Visible = true;
                    Trick_7_11_13btnLightBulb1.Visible = true;
                    Trick_7_11_13btn_TryAgain.Visible = true;
                }

                ans2 = double.Parse(txtTrick7_11_13Ans2.Text);
                res2 = 789789;

                if (ans2 == res2)
                {
                    countans++;
                    Trick_7_11_13btnCorrect2.Visible = true;
                    Trick_7_11_13btnCorrect2.Enabled = false;
                }
                else
                {
                    Trick_7_11_13btnIncorrect2.Visible = true;
                    Trick_7_11_13btnLightBulb2.Visible = true;
                    Trick_7_11_13btn_TryAgain.Visible = true;
                }

                ans3 = double.Parse(txtTrick7_11_13Ans3.Text);
                res3 = 999999;

                if (ans3 == res3)
                {
                    countans++;
                    Trick_7_11_13btnCorrect3.Visible = true;
                    Trick_7_11_13btnCorrect3.Enabled = false;
                }
                else
                {
                    Trick_7_11_13btnIncorrect3.Visible = true;
                    Trick_7_11_13btnLightBulb3.Visible = true;
                    Trick_7_11_13btn_TryAgain.Visible = true;
                }

                ans4 = double.Parse(txtTrick7_11_13Ans4.Text);
                res4 = 653653;

                if (ans4 == res4)
                {
                    countans++;
                    Trick_7_11_13btnCorrect4.Visible = true;
                    Trick_7_11_13btnCorrect4.Enabled = false;
                }
                else
                {
                    Trick_7_11_13btnIncorrect4.Visible = true;
                    Trick_7_11_13btnLightBulb4.Visible = true;
                    Trick_7_11_13btn_TryAgain.Visible = true;
                }

                //Check for Stars
                int countstars = 1;
                if (countans == 3)
                {
                    con.home.Update_xml(15, countstars);
                }
                else if (countans == 4)
                {
                    countstars++;
                    con.home.Update_xml(15, countstars);
                }

                //Check for quiz successfully completed or not
                if (countans >= 3)
                {
                    MessageBox.Show("Congratulations! Quiz Successfully Completed", "Greetings!", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Trick_7_11_13btn_TryAgain.Visible = false;
                    Trick_7_11_13btnSubmit.Visible = false;
                }
                else
                {
                    MessageBox.Show("You need to get at least three correct answers to pass a quiz", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    con.home.Update_xml(15, countstars);
                }
            }
            else
            {
                MessageBox.Show("You must attempt all the questions", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Trick_7_11_13btnLightBulb1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oops ! Wrong Answer, The Correct Answer is:" + 123123 + "\n Please follow the instructions and try again");
        }

        private void txtTrick7_11_13Ans1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ' '))
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Only Numeric value");
            }
        }

        private void txtTrick7_11_13Ans2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ' '))
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Only Numeric value");
            }
        }

        private void txtTrick7_11_13Ans3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ' '))
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Only Numeric value");
            }
        }

        private void txtTrick7_11_13Ans4_KeyPress(object sender, KeyPressEventArgs e)
        {           
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ' '))
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Only Numeric value");
            }
        }

        private void txtTrick7_11_13Ans4_TextChanged(object sender, EventArgs e)
        {
            Trick_7_11_13btnSubmit.Visible = true;
        }
    }
}



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Multiply6to10 : Form
    {
        Constants con = new Constants();
        public Multiply6to10()
        {
            InitializeComponent();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_page Home = new Home_page();
            Home.Show();
        }
        // when the user click submit, this function will be called to ensure if the boxws are filled or if the answers are correct or not
        void CheckAnswers()
        {
            if (txtAnswer1.Text != "" && txtAnswer2.Text != "" && txtAnswer3.Text != "" && txtAnswer4.Text != "")
            {
                // the multiplication result
                int a = int.Parse(No1_1.Text) * int.Parse(No1_2.Text);
                int b = int.Parse(No2_1.Text) * int.Parse(No2_2.Text);
                int c = int.Parse(No3_1.Text) * int.Parse(No3_2.Text);
                int d = int.Parse(No4_1.Text) * int.Parse(No4_2.Text);
                int count = 0;
                // have the result from the player and compare it with the correct one
                if (a == int.Parse(txtAnswer1.Text))
                {
                    count++;
                    right1.Visible = true;
                    assistance1.Visible = true;
                }
                else
                {
                    wrong1.Visible = true;
                    assistance1.Visible = true;
                }
                if (b == int.Parse(txtAnswer2.Text))
                {
                    count++;
                    right2.Visible = true;
                    assistance2.Visible = true;
                }
                else
                {
                    wrong2.Visible = true;
                    assistance2.Visible = true;
                }
                if (c == int.Parse(txtAnswer3.Text))
                {
                    count++;
                    right3.Visible = true;
                    assistance3.Visible = true;
                }
                else
                {
                    wrong3.Visible = true;
                    assistance3.Visible = true;
                }
                if (d == int.Parse(txtAnswer4.Text))
                {
                    count++;
                    right4.Visible = true;
                    assistance4.Visible = true;
                }
                else
                {
                    wrong4.Visible = true;
                    assistance4.Visible = true;
                }
                int countstars = 1;
                if (count == 3)
                {
                    con.home.Update_xml(11, countstars);
                }
                else if (count == 4)
                {
                    countstars++;
                    con.home.Update_xml(11, countstars);
                }

                //Check for quiz successfully completed or not
                if (count >= 3)
                {
                    MessageBox.Show("Congratulations! Quiz Successfully Completed", "Greetings!", MessageBoxButtons.OK, MessageBoxIcon.None);
                    btn_TryAgain.Visible = false;
                    Submit_trick.Visible = false;
                }
                else
                { 
                    MessageBox.Show("You need to get at least three correct answers to pass a quiz", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Submit_trick.Visible = false;
                    btn_TryAgain.Visible = true;
                }
                ReadOnly();
            }
            else
            {
                // check if the boxes are empty or not
                MessageBox.Show("Enter value for all questions", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Submit_trick.Visible = true;
                btn_TryAgain.Visible = false;
            }
        }
        // the helper controles is unvisalble till the user enter the sumbitted value
        void InVisibleControls()
        {
            wrong1.Visible = false;
            wrong2.Visible = false;
            wrong3.Visible = false;
            wrong4.Visible = false;

            right1.Visible = false;
            right2.Visible = false;
            right3.Visible = false;
            right4.Visible = false;

            assistance1.Visible = false;
            assistance2.Visible = false;
            assistance3.Visible = false;
            assistance4.Visible = false;

            btn_TryAgain.Visible = false;
        }

        // to not alter the resutl after sumbit
        void ReadOnly()
        {
            txtAnswer1.ReadOnly = true;
            txtAnswer2.ReadOnly = true;
            txtAnswer3.ReadOnly = true;
            txtAnswer4.ReadOnly = true;
        }
        // to reset all the boxes to empty to enable the user to fill them again
        void Reset()
        {
            txtAnswer1.Clear();
            txtAnswer2.Clear();
            txtAnswer3.Clear();
            txtAnswer4.Clear();
            txtAnswer1.Focus();
            txtAnswer1.ReadOnly = false;
            txtAnswer2.ReadOnly = false;
            txtAnswer3.ReadOnly = false;
            txtAnswer4.ReadOnly = false;
        }
        // the answers
        private void assistance1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("The correct answer is 63", "Correct Answer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void assistance2_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("The correct answer is 20", "Correct Answer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void assistance3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" The correct answer is 12", "Correct Answer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void assistance4_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("The correct answer is 56", "Correct Answer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // validation to not enter any input other that numbers    
        private void txtAnswer1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Only Numeric value", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtAnswer2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Only Numeric value", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtAnswer3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Only Numeric value", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtAnswer4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Only Numeric value", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Submit_trick_Click(object sender, EventArgs e)
        {
            //the player will send the answers
            CheckAnswers();                 
        }

        private void Multiply6to10_Load(object sender, EventArgs e)
        {
            InVisibleControls();
            txtAnswer1.Focus();
        }
        // if the user click try again button, the textboxes will be reseted and the try agin button will not be visible 
        private void btn_TryAgain_Click(object sender, EventArgs e)
        {
            InVisibleControls();
            Reset();
            Submit_trick.Visible = true;
            btn_TryAgain.Visible = false;
        }
    }
}

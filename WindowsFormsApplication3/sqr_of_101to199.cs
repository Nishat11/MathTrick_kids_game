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
    public partial class sqr_of_101to199 : Form
    {
        Constants con = new Constants();
        public sqr_of_101to199()
        {
            InitializeComponent();
        }

        public void Initialize_all_value_for_trick()
        {
            //Add correct answers....
            con.answers.Add("10816");
            con.answers.Add("16384");
            con.answers.Add("31684");
            con.answers.Add("37249");

            //Add name of input fields..
            con.name_of_textbox.Add(sqr_101to199Trick_ans_1);
            con.name_of_textbox.Add(sqr_101to199Trick_ans_2);
            con.name_of_textbox.Add(sqr_101to199Trick_ans_3);
            con.name_of_textbox.Add(sqr_101to199Trick_ans_4);
            con.question_attend = 0;

            //Add name for sad face buttons
            con.sad_face.Add(Trick_1btnNo_1); con.sad_face.Add(Trick_1btnNo_2); con.sad_face.Add(Trick_1btnNo_3); con.sad_face.Add(Trick_1btnNo_4);

            //Add name for smile face buttons
            con.smile_face.Add(Trick1btnYes_1); con.smile_face.Add(Trick1btnYes_2); con.smile_face.Add(Trick1btnYes_3); con.smile_face.Add(Trick1btnYes_4);

            //Add name for correct answer buttons
            con.correct_answer.Add(Trick1_correct_1); con.correct_answer.Add(Trick1_correct_2); con.correct_answer.Add(Trick1_correct_3); con.correct_answer.Add(Trick1_correct_4);
        }
        //Check all answer given and minimum 3 are correct..
        public void Check_Num_of_answers()
        {

            if (con.correct_answers < 3)
            {
                //Failed level try again button visible..
                btn_TryAgain.Visible = true;
                Submit_trick.Visible = false;
                for (int i = 0; i < 4; i++)
                    con.name_of_textbox[i].Enabled = false;
                if(con.question_attend == 4)
                {
                    MessageBox.Show("You need to get at least three correct answers to pass a quiz");
                }
            }
            else if (con.correct_answers == 3 && con.question_attend == 4)
            {
                //One star, correct 3 correct answer
                con.No_star = 1;
                for (int i = 0; i < 4; i++)
                    con.name_of_textbox[i].Enabled = false;
                MessageBox.Show("Successfully complete this puzzel", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Submit_trick.Enabled = false;
                con.home.Update_xml(8, con.No_star);
            }
            else if (con.question_attend == 4)
            {
                //Two star, correct 4 correct answer
                con.No_star = 2;
                for (int i = 0; i < 4; i++)
                    con.name_of_textbox[i].Enabled = false;
                MessageBox.Show("Successfully complete this puzzel", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Submit_trick.Enabled = false;
                con.home.Update_xml(8, con.No_star);
            }

        }

        public void Reset_all_values()
        {

            btn_TryAgain.Visible = false;
            Submit_trick.Visible = true;
            for (int i = 0; i < 4; i++)
            {
                con.name_of_textbox[i].Text = "";
                con.name_of_textbox[i].Enabled = true;
                con.sad_face[i].Visible = false;
                con.smile_face[i].Visible = false;
                con.correct_answer[i].Visible = false;
            }

        }
        private void sqr_of_101to199_Load(object sender, EventArgs e)
        {
            con.reset_all();
            Initialize_all_value_for_trick();
        }

        private void sqr_of_101to199_FormClosing(object sender, FormClosingEventArgs e)
        {
            //On close of trick page display home page back
            con.home.Show();
        }

        private void Trick1_correct_1_Click(object sender, EventArgs e)
        {
            //Message box to show correct answer.
            MessageBox.Show("Correct anser is : " + con.answers[0] + "", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void Trick1_correct_2_Click(object sender, EventArgs e)
        {
            //Message box to show correct answer.
            MessageBox.Show("Correct anser is : " + con.answers[1] + "", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void Trick1_correct_3_Click(object sender, EventArgs e)
        {
            //Message box to show correct answer.
            MessageBox.Show("Correct anser is : " + con.answers[2] + "", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void Trick1_correct_4_Click(object sender, EventArgs e)
        {
            //Message box to show correct answer.
            MessageBox.Show("Correct anser is : " + con.answers[3] + "", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            //After submitting quiez player go to home page..
            this.Close();
            con.home.Show();
        }

        private void btn_TryAgain_Click(object sender, EventArgs e)
        {
            //Player click Try againe for this level...Reset all values.
            Reset_all_values();
        }

        private void Submit_trick_Click(object sender, EventArgs e)
        {
            con.Check_answers();
            Check_Num_of_answers();
        }

        private void sqr_101to199Trick_ans_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Only Numeric value");
            }
        }
    }
}

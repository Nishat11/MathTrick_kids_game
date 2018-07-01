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
    public partial class prime_num : Form
    {
        Constants con = new Constants();
        //Array of answer given by player
       
        public prime_num()
        {
            InitializeComponent();
        }

        public void Initialize_all_value_for_trick()
        {
            //Add correct answers....
            con.answers.Add("No");
            con.answers.Add("Yes");
            con.answers.Add("Yes");
            con.answers.Add("No");

            //Add name of input fields..
            con.name_of_combobox.Add(No_primeTrick_ans_1);
            con.name_of_combobox.Add(No_primeTrick_ans_2);
            con.name_of_combobox.Add(No_primeTrick_ans_3);
            con.name_of_combobox.Add(No_primeTrick_ans_4);
            con.question_attend = 0;
           
            //it will not allow user to write anything in combo box, only can select
            No_primeTrick_ans_1.DropDownStyle = ComboBoxStyle.DropDownList;
            No_primeTrick_ans_2.DropDownStyle = ComboBoxStyle.DropDownList;
            No_primeTrick_ans_3.DropDownStyle = ComboBoxStyle.DropDownList;
            No_primeTrick_ans_4.DropDownStyle = ComboBoxStyle.DropDownList;

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
                    con.name_of_combobox[i].Enabled = false;
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
                    con.name_of_combobox[i].Enabled = false;
                MessageBox.Show("Successfully complete this puzzel", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Submit_trick.Enabled = false;
                con.home.Update_xml(10, con.No_star);
            }
            else if (con.question_attend == 4)
            {
                //Two star, correct 4 correct answer
                con.No_star = 2;
                for (int i = 0; i < 4; i++)
                    con.name_of_combobox[i].Enabled = false;
                MessageBox.Show("Successfully complete this puzzel", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Submit_trick.Enabled = false;
                con.home.Update_xml(10, con.No_star);
            }

        }

        public void Reset_all_values()
        {
            con.question_attend = 0;
            btn_TryAgain.Visible = false;
            Submit_trick.Visible = true;
            for (int i = 0; i < 4; i++)
            {
                con.name_of_combobox[i].Text = null;
                con.name_of_combobox[i].Enabled = true;
                con.sad_face[i].Visible = false;
                con.smile_face[i].Visible = false;
                con.correct_answer[i].Visible = false;
            }

        }
        private void prime_num_Load(object sender, EventArgs e)
        {
            con.reset_all();
            Initialize_all_value_for_trick();
        }

        private void prime_num_FormClosing(object sender, FormClosingEventArgs e)
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
            con.Check_answers_for_cmb();
            Check_Num_of_answers();
        }
    }
}

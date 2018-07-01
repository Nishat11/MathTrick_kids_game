using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace WindowsFormsApplication3
{
    public partial class No_2_trick : Form
    {
        //objecy of constant scripr 
        Constants con = new Constants();
        public int No_star = 0;
        //Check all answer given for try again 
        public int question_attend = 0;
       
        public No_2_trick()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //Submit trick
        private void Submit_trick_Click(object sender, EventArgs e)
        {
            con.Check_answers_for_cmb();
            Check_Num_of_answers();
           
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
                No_star = 1;
                for (int i = 0; i < 4; i++)
                    con.name_of_combobox[i].Enabled = false;
                MessageBox.Show("Successfully complete this puzzel", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Submit_trick.Enabled = false;
                con.home.Update_xml(3,No_star);
                
            }
            else if (con.question_attend == 4)
            {
                //Two star, correct 4 correct answer
                No_star = 2;
                for (int i = 0; i < 4; i++)
                    con.name_of_combobox[i].Enabled = false;
                MessageBox.Show("Successfully complete this puzzel", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Submit_trick.Enabled = false;
                con.home.Update_xml(3, No_star);
            }
           
        }

        public void Initialize_all_value_for_trick()
        {
            //Add correct answers....
            con.answers.Add("Yes");
            con.answers.Add("No");
            con.answers.Add("No");
            con.answers.Add("Yes");

            //Add name of input fields..
            con.name_of_combobox.Add(No_2Trick_ans_1);
            con.name_of_combobox.Add(No_2Trick_ans_2);
            con.name_of_combobox.Add(No_2Trick_ans_3);
            con.name_of_combobox.Add(No_2Trick_ans_4);
            question_attend = 0;

            
            No_2Trick_ans_1.DropDownStyle = ComboBoxStyle.DropDownList;
            No_2Trick_ans_2.DropDownStyle = ComboBoxStyle.DropDownList;
            No_2Trick_ans_3.DropDownStyle = ComboBoxStyle.DropDownList;
            No_2Trick_ans_4.DropDownStyle = ComboBoxStyle.DropDownList;

            //Add name for sad face buttons
            con.sad_face.Add(Trick_1btnNo_1); con.sad_face.Add(Trick_1btnNo_2); con.sad_face.Add(Trick_1btnNo_3); con.sad_face.Add(Trick_1btnNo_4);

            //Add name for smile face buttons
            con.smile_face.Add(Trick1btnYes_1); con.smile_face.Add(Trick1btnYes_2); con.smile_face.Add(Trick1btnYes_3); con.smile_face.Add(Trick1btnYes_4);

            //Add name for correct answer buttons
            con.correct_answer.Add(Trick1_correct_1); con.correct_answer.Add(Trick1_correct_2); con.correct_answer.Add(Trick1_correct_3); con.correct_answer.Add(Trick1_correct_4);
        }

        public void Reset_all_values()
        {
            btn_TryAgain.Visible = false;
            Submit_trick.Visible = true;
            for (int i=0;i<4;i++)
            {
                con.name_of_combobox[i].Text = null;
                con.name_of_combobox[i].Enabled = true;
                con.sad_face[i].Visible = false;
                con.smile_face[i].Visible = false;
                con.correct_answer[i].Visible = false;
            }

        }
        //Only replace name of text field for your trick
        private void Math_Trick_Load(object sender, EventArgs e)
        {
            Initialize_all_value_for_trick();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            //After submitting quiez player go to home page..
            this.Close();
            con.home.Show();
            this.Dispose();
        }

        private void Math_Trick_FormClosing(object sender, FormClosingEventArgs e)
        {
            //On close of trick page display home page back
            con.home.Show();
        }

        private void btn_TryAgain_Click(object sender, EventArgs e)
        {
            //Player click Try againe for this level...Reset all values.
            Reset_all_values();
        }

        private void Trick1_correct_1_Click(object sender, EventArgs e)
        {
            //Message box to show correct answer.
            MessageBox.Show("Correct anser is : " + con.answers[0]+". Because last digit of number is even", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void Trick1_correct_2_Click(object sender, EventArgs e)
        {
            //Message box to show correct answer.
            MessageBox.Show("Correct anser is : " + con.answers[1]+ ". Because last digit of number is odd", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void Trick1_correct_3_Click(object sender, EventArgs e)
        {
            //Message box to show correct answer.
            MessageBox.Show("Correct anser is : " + con.answers[2]+ " . Because last digit of number is odd", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void Trick1_correct_4_Click(object sender, EventArgs e)
        {
            //Message box to show correct answer.
            MessageBox.Show("Correct anser is : " + con.answers[3]+ " . Because last digit of number is even", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void No_2Trick_ans_1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void No_2Trick_ans_1_TextUpdate(object sender, EventArgs e)
        {

        }
    }
}

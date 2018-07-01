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
    public partial class fastFive : Form
    {
        //Array of answers for trick
        public List<string> answers = new List<string>();
        //Array of answer given by player
        public List<TextBox> name_of_textbox = new List<TextBox>();
        //Array of sad face
        public List<Button> sad_face = new List<Button>();
        //Array of smile face
        public List<Button> smile_face = new List<Button>();
        //Array of correct answer button..
        public List<Button> correct_answer = new List<Button>();
        //Home page object
        Home_page home = new Home_page();
        //No of correct answer for this level
        public int correct_answers = 0;
        //No of star for this level
        public int No_star = 0;
        //Check all answer given for try again 
        public int question_attend = 0;
            
        Constants con = new Constants();

        public fastFive()
        {
            InitializeComponent();
        }

        private void fastFive_Load(object sender, EventArgs e)
        {
            Initialize_all_value_for_trick();
        }

        public void Initialize_all_value_for_trick()
        {
            //Add correct answers....
            answers.Add("51.2");
            answers.Add("18");
            answers.Add("8.8");
            answers.Add("6.4");

            //Add name of input fields..
            name_of_textbox.Add(textBox8);
            name_of_textbox.Add(textBox7);
            name_of_textbox.Add(textBox6);
            name_of_textbox.Add(textBox5);
            question_attend = 0;

            //Add name for sad face buttons
            sad_face.Add(Trick_1btnNo_1); sad_face.Add(Trick_1btnNo_2); sad_face.Add(Trick_1btnNo_3); sad_face.Add(Trick_1btnNo_4);

            //Add name for smile face buttons
            smile_face.Add(Trick1btnYes_1); smile_face.Add(Trick1btnYes_2); smile_face.Add(Trick1btnYes_3); smile_face.Add(Trick1btnYes_4);

            //Add name for correct answer buttons
            correct_answer.Add(Trick1_correct_1); correct_answer.Add(Trick1_correct_2); correct_answer.Add(Trick1_correct_3); correct_answer.Add(Trick1_correct_4);
        }

        private void Submit_trick_Click(object sender, EventArgs e)
        {
            Check_answers();
            Check_Num_of_answers();
        }

        //Check answer for your trick 
        public void Check_answers()
        {
            question_attend = 0;
            foreach (TextBox tb in name_of_textbox)
            {
                if (tb.Text != "")
                    question_attend++;
                Console.WriteLine("value for write line is" + question_attend);
            }

            int i; //i is for number of answer
            //To check for all four answers...
            for (i = 0; i < 4; i++)
            {
                if (name_of_textbox[i].Text != "")
                {
                    if (answers[i].ToString() == name_of_textbox[i].Text)
                    {
                        //Answer is correct for question no. i
                        Console.WriteLine("Answer is right for" + i);
                        if (question_attend == 4)
                        {
                            correct_answers++;
                            smile_face[i].Visible = true;
                        }

                    }
                    else
                    {
                        //Answer is incorrect for question no. i
                        Console.WriteLine("Answer is wrong for" + i);
                        if (question_attend == 4)
                        {
                            sad_face[i].Visible = true;
                            correct_answer[i].Visible = true;
                        }
                    }
                    // question_attend = true;
                }
                else
                {
                    MessageBox.Show("Enter value for all questions", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    //warning message only one time..
                    i = 3;
                    // question_attend = false;
                }
            }
        } // end of Check_answers function

        //Checks all answers given to determine if minimum of 3 are correct..
        public void Check_Num_of_answers()
        {

            if (correct_answers < 3 && question_attend == 4)
            {
                //Failed level try again button visible..
                btn_TryAgain.Visible = true;
                Submit_trick.Visible = false;
                for (int i = 0; i < 4; i++)
                    name_of_textbox[i].Enabled = false;
            }
            else if (correct_answers == 3 && question_attend == 4)
            {
                //One star, correct 3 correct answer
                No_star = 1;
                for (int i = 0; i < 4; i++)
                    name_of_textbox[i].Enabled = false;
                MessageBox.Show("Successfully completed this puzzle", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Submit_trick.Enabled = false;
                con.home.Update_xml(17, No_star);

            }
            else if (question_attend == 4)
            {
                //Two star, correct 4 correct answer
                No_star = 2;
                for (int i = 0; i < 4; i++)
                    name_of_textbox[i].Enabled = false;
                MessageBox.Show("Successfully completed this puzzle", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Submit_trick.Enabled = false;
                con.home.Update_xml(17, No_star);
            }

        } // end of Check_Num_of_answers function

        private void btn_TryAgain_Click(object sender, EventArgs e)
        {
            //Player clicked Try again for this level...Resets all values.
            Reset_all_values();
        }

        public void Reset_all_values()
        {
            btn_TryAgain.Visible = false;
            Submit_trick.Visible = true;
            for (int i = 0; i < 4; i++)
            {
                name_of_textbox[i].Text = "";
                name_of_textbox[i].Enabled = true;
                sad_face[i].Visible = false;
                smile_face[i].Visible = false;
                correct_answer[i].Visible = false;
            }
        }  // end of Reset_all_values function

        private void btn_home_Click(object sender, EventArgs e)
        {
            //After submitting quiz, the player will click Home button to go to home page.
            this.Close();
            home.Show();
            this.Dispose();
        }

        private void Trick1_correct_1_Click(object sender, EventArgs e)
        {
            //Message box to show correct answer.
            MessageBox.Show("Correct answer is : " + answers[0], "Assistance", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void Trick1_correct_2_Click(object sender, EventArgs e)
        {
            //Message box to show correct answer.
            MessageBox.Show("Correct answer is : " + answers[1], "Assistance", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void Trick1_correct_3_Click(object sender, EventArgs e)
        {
            //Message box to show correct answer.
            MessageBox.Show("Correct answer is : " + answers[2], "Assistance", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void Trick1_correct_4_Click(object sender, EventArgs e)
        {
            //Message box to show correct answer.
            MessageBox.Show("Correct answer is : " + answers[3], "Assistance", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}

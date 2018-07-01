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
    public partial class Math_Trick : Form
    {
        //Array of ansers for trick
        public List<string> answers = new List<string>();
        //Array of answer given by player
        public List<ComboBox> name_of_textbox = new List<ComboBox>();
        //Array of sad face
        public List<Button> sad_face = new List<Button>();
        //Array of smile face
        public List<Button> smile_face = new List<Button>();
        //Array of correct answer button..
        public List<Button> correct_answer = new List<Button>();
        //Home page object
        Home_page home = new Home_page();
        //No of correct answer for this level
        public int correct_answers =0 ;
        //No of star for this level
        public int No_star = 0;
        //Check all answer given for try again 
        public int question_attend = 0;

        public Math_Trick()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //Submit trick
        private void Submit_trick_Click(object sender, EventArgs e)
        {
            Check_answers();
            Check_Num_of_answers();
        }

        //Check answer for your trick 
        public void Check_answers()
        {
            question_attend = 0;
            foreach (ComboBox cb in name_of_textbox)
            {
                if (cb.Text != "")
                    question_attend++;
                Console.WriteLine("value for write line is"+ question_attend);
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
                    MessageBox.Show("Enter value for all questions","Warning",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    //warning message only one time..
                    i = 3;
                   // question_attend = false;
                }
            }
        }

        //Check all answer given and minimum 3 are correct..
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
                MessageBox.Show("Successfully complete this puzzel", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Submit_trick.Enabled = false;

            }
            else if (question_attend == 4)
            {
                //Two star, correct 4 correct answer
                No_star = 2;
                for (int i = 0; i < 4; i++)
                    name_of_textbox[i].Enabled = false;
                MessageBox.Show("Successfully complete this puzzel", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Submit_trick.Enabled = false;
            }
           
        }

        public void Initialize_all_value_for_trick()
        {
            //Add correct answers....
            answers.Add("Yes");
            answers.Add("No");
            answers.Add("No");
            answers.Add("Yes");

            //Add name of input fields..
            name_of_textbox.Add(No_2Trick_ans_1);
            name_of_textbox.Add(No_2Trick_ans_2);
            name_of_textbox.Add(No_2Trick_ans_3);
            name_of_textbox.Add(No_2Trick_ans_4);
            question_attend = 0;

            //Add name for sad face buttons
            sad_face.Add(Trick_1btnNo_1); sad_face.Add(Trick_1btnNo_2); sad_face.Add(Trick_1btnNo_3); sad_face.Add(Trick_1btnNo_4);

            //Add name for smile face buttons
            smile_face.Add(Trick1btnYes_1); smile_face.Add(Trick1btnYes_2); smile_face.Add(Trick1btnYes_3); smile_face.Add(Trick1btnYes_4);

            //Add name for correct answer buttons
            correct_answer.Add(Trick1_correct_1); correct_answer.Add(Trick1_correct_2); correct_answer.Add(Trick1_correct_3); correct_answer.Add(Trick1_correct_4);
        }

        public void Reset_all_values()
        {
           
            btn_TryAgain.Visible = false;
            Submit_trick.Visible = true;
            for (int i=0;i<4;i++)
            {
                name_of_textbox[i].Text = "";
                name_of_textbox[i].Enabled = true;
                sad_face[i].Visible = false;
                smile_face[i].Visible = false;
                correct_answer[i].Visible = false;
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
            home.Show();
        }

        private void Math_Trick_FormClosing(object sender, FormClosingEventArgs e)
        {
            //On close of trick page display home page back
            home.Show();
        }

        private void btn_TryAgain_Click(object sender, EventArgs e)
        {
            //Player click Try againe for this level...Reset all values.
            Reset_all_values();
        }

        private void Trick1_correct_1_Click(object sender, EventArgs e)
        {
            //Message box to show correct answer.
            MessageBox.Show("Correct anser is : "+answers[0]+". Because last digit of number is even", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void Trick1_correct_2_Click(object sender, EventArgs e)
        {
            //Message box to show correct answer.
            MessageBox.Show("Correct anser is : " + answers[1]+ ". Because last digit of number is odd", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void Trick1_correct_3_Click(object sender, EventArgs e)
        {
            //Message box to show correct answer.
            MessageBox.Show("Correct anser is : " + answers[2]+ " . Because last digit of number is odd", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void Trick1_correct_4_Click(object sender, EventArgs e)
        {
            //Message box to show correct answer.
            MessageBox.Show("Correct anser is : " + answers[3]+ " . Because last digit of number is even", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}

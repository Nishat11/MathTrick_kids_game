using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApplication3
{
   
    class Constants
    {
       
        //Array of ansers for trick : Nishat
        public List<string> answers = new List<string>();
        //Array of answer given by player in Text box
        public List<TextBox> name_of_textbox = new List<TextBox>();
        //Array of answer given by player in combo box : nishat
        public List<ComboBox> name_of_combobox = new List<ComboBox>();
        //Array of sad face
        public List<Button> sad_face = new List<Button>();
        //Array of smile face
        public List<Button> smile_face = new List<Button>();
        //Array of correct answer button..
        public List<Button> correct_answer = new List<Button>();
        //Home page object
        public Home_page home = new Home_page();
        //No of correct answer for this level
        public int correct_answers = 0;
        //No of star for this level
        public int No_star = 0;
        //Check all answer given for try again 
        public int question_attend = 0;

        //Reset all vaiables and Lists
        public void reset_all()
        {
            answers.Clear();
            name_of_textbox.Clear();
            sad_face.Clear();
            smile_face.Clear();
            correct_answer.Clear();
        }

        // Check anser for trick with combo box : Nishat
        public void Check_answers_for_cmb()
        {
            question_attend = 0;
            foreach (ComboBox cb in name_of_combobox)
            {
                if (cb.Text != "")
                    question_attend++;
                Console.WriteLine("value for write line is......................." + question_attend);
            }

            int i; //i is for number of answer
            //To check for all four answers...
            for (i = 0; i < 4; i++)
            {
                if (name_of_combobox[i].Text != "")
                {
                    if (answers[i].ToString() == name_of_combobox[i].Text)
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
                }
                else
                {
                    MessageBox.Show("Enter value for all questions", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    //warning message only one time..
                    i = 3;
                }
            }
        }

        //Check answer for textbox trick 
        public void Check_answers()
        {
            question_attend = 0;
            foreach (TextBox cb in name_of_textbox)
            {
                if (cb.Text != "")
                    question_attend++;
                Console.WriteLine("value for write line is" + question_attend);
            }

            int i; //i is for number of answer given

            //To check for all four answers...
            for (i = 0; i < 4; i++)
            {
                if (name_of_textbox[i].Text != "")
                {
                    if (answers[i].ToString() == name_of_textbox[i].Text)
                    {
                        //Answer is correct for question no. i
                        if (question_attend == 4)
                        {
                            correct_answers++;
                            smile_face[i].Visible = true;
                        }
                    }
                    else
                    {
                        //Answer is incorrect for question no. i
                        if (question_attend == 4)
                        {
                            sad_face[i].Visible = true;
                            correct_answer[i].Visible = true;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Enter value for all questions", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    //warning message only one time..
                    i = 3;
                }
            }
        }
    }
}

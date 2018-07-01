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
using System.Xml.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Home_page : Form
    {
       
        string Xml_file_Path = @"C:\Trick_Mathster\Trick_Mathster.xml";
        //Xml_data xml_data = new Xml_data();
        //Array of Trick buttons
        public List<string> trick_button = new List<string>();
        //Array of stars for trick
        public List<Button> stars = new List<Button>();
        XmlDocument xml1 = new XmlDocument();
        public int total_completed_level = 0;

        public Home_page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Home_page_Load(object sender, EventArgs e)
        {
            //Check xml file is there or not...???
            InitializeValues();
            Check_xml();
        }

        void InitializeValues()
        {
            for(int i= 1;i<21;i++)
            {
                trick_button.Add("btn_trick_"+i);
            }
            
        }
        void Check_xml ()
        {
            //Check xml file is there or not...???
            if (File.Exists(Xml_file_Path))
            {
                read_xml();
                User_info_panel.Visible = false;
                All_trick_panel.Visible = true;
                btn_Reset_levels.Enabled = true;
                btn_reset.Enabled = true;
                Progress_panel.Visible = true;
            }
            else
            {
                User_info_panel.Visible = true;
                All_trick_panel.Visible = false;
                btn_Reset_levels.Enabled = false;
                btn_reset.Enabled = false;
                total_completed_level = 0;
                Progress_panel.Visible = false;
            }
        }
           
        //}
        //First Trick button
        private void button30_Click(object sender, EventArgs e)
        {
            this.Hide();
            Table9 trick9 = new Table9();
            trick9.Show();
        }

        private void Home_page_FormClosing(object sender, FormClosingEventArgs e)
        {
            //On close close application
            Application.Exit();
        }
     
        // Create xml file......
        private void createNode(int level_no, int stars, int status, XmlTextWriter writer , string user_name)
        {
            writer.WriteStartElement("Level");
            writer.WriteStartElement("Level_No");
            writer.WriteString(""+ level_no);
            writer.WriteEndElement();
            writer.WriteStartElement("Stars_No");
            writer.WriteString(""+ stars);
            writer.WriteEndElement();
            writer.WriteStartElement("Status");
            writer.WriteString("" + status);
            writer.WriteEndElement();
            writer.WriteStartElement("Username");
            writer.WriteString("" + user_name);
            writer.WriteEndElement();
            writer.WriteEndElement();
        }
        void Create_Xml (string username)
        {
            //Create folder in c drive : Nishat
            if (!Directory.Exists(@"C:\Trick_Mathster"))
                Directory.CreateDirectory(@"C:\Trick_Mathster");

            XmlTextWriter writer = new XmlTextWriter(Xml_file_Path, System.Text.Encoding.UTF8);
            writer.WriteStartDocument(true);
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 2;
            writer.WriteStartElement("Username");
            //writer.WriteStartElement("UserName ="+ username);

            for(int i=1; i<21; i++)
            {
                createNode(i, 0, 0, writer, username);
            }
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
            //MessageBox.Show("XML File created ! ");
            //Display all trick home page
            User_info_panel.Visible = false;
            //Check all user data from xml..

            read_xml();
            All_trick_panel.Visible = true;
            btn_Reset_levels.Enabled = true;
            btn_reset.Enabled = true;
            Progress_panel.Visible = true;
        }

        //Check saved data from xml as update home page.....
        private void read_xml()
        {
            total_completed_level = 0;
            XmlReader xmlFile;
            xmlFile = XmlReader.Create(Xml_file_Path, new XmlReaderSettings());
            DataSet ds = new DataSet();
            ds.ReadXml(xmlFile);
            
            for (int i = 0; i <= ds.Tables[0].Rows.Count-1; i++)
            {
                //Level stars from 1 to 20 it cant zero..
                int level_no = i + 1;
                //Check level progression..... status
                if (ds.Tables[0].Rows[i].ItemArray[2].ToString() == "0")
                {
                    this.Controls.Find("btn_trick_" + level_no, true)[0].Visible = true;
                    this.Controls.Find("btn_img_" + level_no, true)[0].Visible = false;
                }
                else
                {
                    this.Controls.Find(trick_button[i].ToString(), true)[0].Visible = false;
                    this.Controls.Find("btn_img_" + level_no, true)[0].Visible = true;
                    total_completed_level++;
                }
                //check No of stars..
                if (ds.Tables[0].Rows[i].ItemArray[1].ToString() == "1")
                {
                    this.Controls.Find(("star_"+ level_no + "_"+1).ToString(), true)[0].Visible = true;
                }
                else if(ds.Tables[0].Rows[i].ItemArray[1].ToString() == "2")
                {
                    this.Controls.Find(("star_" + level_no + "_" + 1).ToString(), true)[0].Visible = true;
                    this.Controls.Find(("star_" + level_no + "_" + 2).ToString(), true)[0].Visible = true;
                }
                else
                {
                    this.Controls.Find(("star_" + level_no + "_" + 1).ToString(), true)[0].Visible = false;
                    this.Controls.Find(("star_" + level_no + "_" + 2).ToString(), true)[0].Visible = false;
                }
            }
            ds.Dispose();
            xmlFile.Dispose();
            //Check  number of completed levels
            Console.WriteLine("total completed level no : -"+ total_completed_level);
            levelprogress.Value = total_completed_level;
            if (total_completed_level == 20)
            {
                btn_Certificate.Enabled = true;
                abt_image.Enabled = true;
            }
            else
            {
                btn_Certificate.Enabled = false;
                abt_image.Enabled = false;
            }
               
        }

        //Need to update this code to update xml file..........
        public void Update_xml(int level_no, int stars)
        {
           // XmlDocument xml1 = new XmlDocument();
            xml1.Load(Xml_file_Path);

            //It will give list of all Level elements.. :Nishat
            XmlNodeList nodes = xml1.SelectNodes("//Level");
            //List start from 0... so i use -1... Nishat
            nodes[level_no-1].SelectSingleNode("Stars_No").InnerText = stars.ToString();
            nodes[level_no - 1].SelectSingleNode("Status").InnerText = "1";
            xml1.Save(Xml_file_Path);
        }

        private void BindGrid()
        {
            DataSet ds = new DataSet();
            ds.ReadXml(Xml_file_Path);
            if (ds != null && ds.HasChanges())
            {
                //grdxml.DataSource = ds;
                //grdxml.DataBind();
            }
            else
            {
               // grdxml.DataBind();
            }
        }

        private void btn_submit_name_Click(object sender, EventArgs e)
        {
            //Create xml file and store name of user..
            if (txt_username.Text != "")
            {
                Create_Xml(txt_username.Text);
            }
            else
            {
                MessageBox.Show("Enter valid name of player", "Black value of Name", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void Star1_lvl_1_Click(object sender, EventArgs e)
        {

        }

        private void Star2_lvl_1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button32_Click(object sender, EventArgs e)
        {

        }

        private void btn_trick_3_Click(object sender, EventArgs e)
        {
            this.Hide();
            No_2_trick math = new No_2_trick();
            math.Show();
        }

        private void btn_trick_2_Click(object sender, EventArgs e)
        {
            //update_xml(3, 4);
            this.Hide();
            No_Muultiply_By11 multy_by_11 = new No_Muultiply_By11();
            multy_by_11.Show();
        }

        private void btn_trick_6_Click(object sender, EventArgs e)
        {
            this.Hide();
            No_multi_by_12 multy_by_12 = new No_multi_by_12();
            multy_by_12.Show();
        }

        private void btn_Certificate_Click(object sender, EventArgs e)
        {
            //Show certificate if all 20 level completed 
            this.Hide();
            certificate certi_page = new certificate();
            certi_page.Show();
        }

        private void btn_skip_name_Click(object sender, EventArgs e)
        {
            Create_Xml("");
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            DialogResult dg_choice = MessageBox.Show("Are you sure you want to delete this User and data..?", "Delete User Warning", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(dg_choice == DialogResult.Yes)
            {
                File.Delete(Xml_file_Path);
                //Check xml file is there or not...???
                Check_xml();
                
            }
            
        }

        private void btn_trick_5_Click(object sender, EventArgs e)
        {
            this.Hide();
            sqr_frm_11to20 frm_11to20_trick = new sqr_frm_11to20();
            frm_11to20_trick.Show();
        }

        private void btn_trick_7_Click(object sender, EventArgs e)
        {
            this.Hide();
            sqr_of_2_num frm_sqr_2_num = new sqr_of_2_num();
            frm_sqr_2_num.Show();
        }

        private void btn_trick_10_Click(object sender, EventArgs e)
        {
            this.Hide();
            prime_num frm_prime_num = new prime_num();
            frm_prime_num.Show();
        }

        private void btn_trick_9_Click(object sender, EventArgs e)
        {
            this.Hide();
            _15perc_of_num frm_15perc_of_num = new _15perc_of_num();
            frm_15perc_of_num.Show();
        }

        private void btn_trick_8_Click(object sender, EventArgs e)
        {
            this.Hide();
            sqr_of_101to199 frm_sqr_of_101to199 = new sqr_of_101to199();
            frm_sqr_of_101to199.Show();
        }

        private void btn_Reset_levels_Click(object sender, EventArgs e)
        {
            DialogResult dg_choice = MessageBox.Show("Are you sure you want to reset all levels?", "Delete User Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg_choice == DialogResult.Yes)
            {
                xml1.Load(Xml_file_Path);
                //It will give list of all Level elements.. :Nishat
                XmlNodeList nodes = xml1.SelectNodes("//Level");
                foreach (XmlElement element in nodes)
                {
                    element.SelectSingleNode("Stars_No").InnerText = "0";
                    element.SelectSingleNode("Status").InnerText = "0";
                }
                xml1.Save(Xml_file_Path);
                read_xml();
            }
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            string text = "Select any Trick name to start it. Give at least 3 correct answers to solve each trick.";
            MessageBox.Show(text, "Help", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void btn_trick_15_Click(object sender, EventArgs e)
        {
            this.Hide();
            Trick_7_11_13 tmpfrm = new Trick_7_11_13();
            tmpfrm.Show();
        }

        private void btn_trick_11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Multiply6to10 Multiply6To10 = new Multiply6to10();
            Multiply6To10.Show();
        }

        private void btn_trick_14_Click(object sender, EventArgs e)
        {
            this.Hide();
            decimal_to_binary decimal_to_binary = new decimal_to_binary();
            decimal_to_binary.Show();
        }

        private void btn_trick_17_Click(object sender, EventArgs e)
        {
            this.Hide();
            fastFive fast_five = new fastFive();
            fast_five.Show();
        }

        private void btn_trick_20_Click(object sender, EventArgs e)
        {
            this.Hide();
            MultiplyBy5ToThePowerN By5 = new MultiplyBy5ToThePowerN();
            By5.Show();
        }

        private void btn_trick_4_Click(object sender, EventArgs e)
        {
            this.Hide();
            BigNumberAddition BigNO = new BigNumberAddition();
            BigNO.Show();
        }

        private void btn_trick_19_Click(object sender, EventArgs e)
        {
            this.Hide();
            Trick_Pi remember_pi = new Trick_Pi();
            remember_pi.Show();
        }

        private void btn_trick_18_Click(object sender, EventArgs e)
        {
            this.Hide();
            multiplyBy6 multiplyBy6 = new multiplyBy6();
            multiplyBy6.Show();
        }

        private void btn_trick_12_Click(object sender, EventArgs e)
        {
            this.Hide();
            TwoDigitEndsWith5 twodigitwith5 = new TwoDigitEndsWith5();
            twodigitwith5.Show();            
        }

        private void btn_trick_16_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThreeDigitSquare threedigitsquare = new ThreeDigitSquare();
            threedigitsquare.Show();      
        }

        private void btn_trick_13_Click(object sender, EventArgs e)
        {
            this.Hide();
            devide9 DevideBy9 = new devide9();
            DevideBy9.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void abt_sir_Carl_Linnaeus_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/Srinivasa_Ramanujan");
        }

        private void abt_image_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/Srinivasa_Ramanujan");
        }
    }
}

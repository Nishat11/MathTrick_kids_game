using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Xml;

namespace WindowsFormsApplication3
{
    public partial class certificate : Form
    {
        Constants con = new Constants();
        Bitmap memoryImage;
        Bitmap bitmap;
        string Xml_file_Path = @"C:\Trick_Mathster\Trick_Mathster.xml";
        //store name of user
        public string certi_username;

        public certificate()
        {
            InitializeComponent();
        }
        private void CaptureScreen()
        {
            //Graphics myGraphics = this.CreateGraphics();
            //Size s = this.Size;
            //memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            //Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            //memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);

            using (var myGraphics = CreateGraphics())
            {
                var s = Size;
                memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
                using (var memoryGraphics = Graphics.FromImage(memoryImage))
                {
                    memoryGraphics.CopyFromScreen(Location.X, Location.Y, 0, 0, s);
                }
            }
        }

        private void printDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            // calculate width and height scalings taking page margins into account
            var wScale = e.MarginBounds.Width / (float)memoryImage.Width;
            var hScale = e.MarginBounds.Height / (float)memoryImage.Height;

            // choose the smaller of the two scales
            var scale = wScale < hScale ? wScale : hScale;

            // apply scaling to the image
            e.Graphics.ScaleTransform(scale, scale);

            // print to default printer's page
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            //CaptureScreen();
            //printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            //printDocument1.Print();

            //Add a Panel control.
            Panel panel = new Panel();
            this.Controls.Add(panel);

            //Create a Bitmap of size same as that of the Form.
            //Graphics grp = panel.CreateGraphics();
            //Size formSize = this.ClientSize;
            //bitmap = new Bitmap(formSize.Width, formSize.Height, grp);
            //grp = Graphics.FromImage(bitmap);

            ////Copy screen area that that the Panel covers.
            //Point panelLocation = PointToScreen(panel.Location);
            //grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);

            ////Show the Print Preview Dialog.
            //printPreviewDialog1.Document = printDocument1;
            //printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            //printPreviewDialog1.ShowDialog();

            printDocument1.OriginAtMargins = true;
            printDocument1.DocumentName = "TEST IMAGE PRINTING";

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

            //if (printDialog.ShowDialog() == DialogResult.OK)
                //printDocument.Print();

        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
           // e.Graphics.DrawImage(print_panel.BackgroundImage, 0, 0);
            e.Graphics.DrawImage(print_panel.BackgroundImage, Point.Empty);
        }

        private void PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Print the contents.
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void btn_close_print_page_Click(object sender, EventArgs e)
        {
            this.Close();
            con.home.Show();
        }
      
        private void certificate_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.home.Show();
        }

        private void certificate_Load_1(object sender, EventArgs e)
        {
            XmlReader xmlFile;
            xmlFile = XmlReader.Create(Xml_file_Path, new XmlReaderSettings());
            DataSet ds = new DataSet();
            ds.ReadXml(xmlFile);
            certi_username = ds.Tables[0].Rows[0].ItemArray[3].ToString();
            Home_page home_obj = new Home_page();
            Console.WriteLine("my name is ...." + certi_username);
            u_name_certi.Text = certi_username;
            ds.Dispose();
            xmlFile.Dispose();
        }
    }
}

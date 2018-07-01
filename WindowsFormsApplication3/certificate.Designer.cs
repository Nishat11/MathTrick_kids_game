namespace WindowsFormsApplication3
{
    partial class certificate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(certificate));
            this.btn_close_print_page = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.u_name_certi = new System.Windows.Forms.Label();
            this.print_panel = new System.Windows.Forms.PictureBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.print_panel)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_close_print_page
            // 
            this.btn_close_print_page.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_close_print_page.BackColor = System.Drawing.SystemColors.Control;
            this.btn_close_print_page.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close_print_page.ForeColor = System.Drawing.Color.Black;
            this.btn_close_print_page.Location = new System.Drawing.Point(1186, 665);
            this.btn_close_print_page.Name = "btn_close_print_page";
            this.btn_close_print_page.Size = new System.Drawing.Size(93, 38);
            this.btn_close_print_page.TabIndex = 58;
            this.btn_close_print_page.Text = "Close";
            this.btn_close_print_page.UseVisualStyleBackColor = false;
            this.btn_close_print_page.Click += new System.EventHandler(this.btn_close_print_page_Click);
            // 
            // u_name_certi
            // 
            this.u_name_certi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.u_name_certi.AutoSize = true;
            this.u_name_certi.BackColor = System.Drawing.Color.White;
            this.u_name_certi.Font = new System.Drawing.Font("Palatino Linotype", 30F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.u_name_certi.Location = new System.Drawing.Point(595, 285);
            this.u_name_certi.Name = "u_name_certi";
            this.u_name_certi.Size = new System.Drawing.Size(124, 53);
            this.u_name_certi.TabIndex = 59;
            this.u_name_certi.Text = "Vicky";
            // 
            // print_panel
            // 
            this.print_panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.print_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("print_panel.BackgroundImage")));
            this.print_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.print_panel.Location = new System.Drawing.Point(0, -2);
            this.print_panel.Name = "print_panel";
            this.print_panel.Size = new System.Drawing.Size(1302, 736);
            this.print_panel.TabIndex = 56;
            this.print_panel.TabStop = false;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // certificate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 733);
            this.Controls.Add(this.u_name_certi);
            this.Controls.Add(this.btn_close_print_page);
            this.Controls.Add(this.print_panel);
            this.Name = "certificate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "certificate";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.certificate_FormClosing);
            this.Load += new System.EventHandler(this.certificate_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.print_panel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close_print_page;
        private System.Windows.Forms.PictureBox print_panel;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label u_name_certi;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}
namespace BroadlinkManager
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            Syncfusion.Windows.Forms.CaptionImage captionImage1 = new Syncfusion.Windows.Forms.CaptionImage();
            Syncfusion.Windows.Forms.CaptionImage captionImage2 = new Syncfusion.Windows.Forms.CaptionImage();
            Syncfusion.Windows.Forms.CaptionImage captionImage3 = new Syncfusion.Windows.Forms.CaptionImage();
            this.Output = new BroadlinkManager.Controls.BetterRichTextBox();
            this.ToolBar = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.Scan = new System.Windows.Forms.ToolStripButton();
            this.Devices = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Commands = new System.Windows.Forms.ToolStripDropDownButton();
            this.LearnIR = new System.Windows.Forms.ToolStripMenuItem();
            this.SendIR = new System.Windows.Forms.ToolStripMenuItem();
            this.LearnRF = new System.Windows.Forms.ToolStripMenuItem();
            this.SendRF = new System.Windows.Forms.ToolStripMenuItem();
            this.Cancel = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Output
            // 
            this.Output.BackColor = System.Drawing.Color.Black;
            this.Output.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output.ForeColor = System.Drawing.Color.White;
            this.Output.Location = new System.Drawing.Point(0, 109);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(955, 423);
            this.Output.TabIndex = 0;
            this.Output.Text = "";
            // 
            // ToolBar
            // 
            this.ToolBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(143)))), ((int)(((byte)(199)))));
            this.ToolBar.Image = null;
            this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Scan,
            this.Devices,
            this.toolStripSeparator1,
            this.Commands});
            this.ToolBar.Location = new System.Drawing.Point(0, 0);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Size = new System.Drawing.Size(955, 40);
            this.ToolBar.TabIndex = 4;
            // 
            // Scan
            // 
            this.Scan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Scan.Image = ((System.Drawing.Image)(resources.GetObject("Scan.Image")));
            this.Scan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Scan.Name = "Scan";
            this.Scan.Size = new System.Drawing.Size(36, 22);
            this.Scan.Text = "Scan";
            this.Scan.Click += new System.EventHandler(this.Scan_Click);
            // 
            // Devices
            // 
            this.Devices.Name = "Devices";
            this.Devices.Size = new System.Drawing.Size(121, 25);
            this.Devices.SelectedIndexChanged += new System.EventHandler(this.Devices_SelectedIndexChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // Commands
            // 
            this.Commands.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Commands.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LearnIR,
            this.SendIR,
            this.LearnRF,
            this.SendRF,
            this.Cancel});
            this.Commands.Image = ((System.Drawing.Image)(resources.GetObject("Commands.Image")));
            this.Commands.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Commands.Name = "Commands";
            this.Commands.Size = new System.Drawing.Size(82, 22);
            this.Commands.Text = "Commands";
            // 
            // LearnIR
            // 
            this.LearnIR.Image = global::BroadlinkManager.Properties.Resources.Infrared1;
            this.LearnIR.Name = "LearnIR";
            this.LearnIR.Size = new System.Drawing.Size(180, 22);
            this.LearnIR.Text = "Learn IR";
            this.LearnIR.Click += new System.EventHandler(this.LearnIR_Click);
            // 
            // SendIR
            // 
            this.SendIR.Image = global::BroadlinkManager.Properties.Resources.Infrared1;
            this.SendIR.Name = "SendIR";
            this.SendIR.Size = new System.Drawing.Size(180, 22);
            this.SendIR.Text = "Send IR";
            // 
            // LearnRF
            // 
            this.LearnRF.Image = global::BroadlinkManager.Properties.Resources.Radar;
            this.LearnRF.Name = "LearnRF";
            this.LearnRF.Size = new System.Drawing.Size(180, 22);
            this.LearnRF.Text = "Learn RF";
            // 
            // SendRF
            // 
            this.SendRF.Image = global::BroadlinkManager.Properties.Resources.Radar;
            this.SendRF.Name = "SendRF";
            this.SendRF.Size = new System.Drawing.Size(180, 22);
            this.SendRF.Text = "Send RF";
            // 
            // Cancel
            // 
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(180, 22);
            this.Cancel.Text = "Cancel Learning";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(143)))), ((int)(((byte)(199)))));
            this.BorderThickness = 10;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(143)))), ((int)(((byte)(199)))));
            this.CaptionBarHeight = 67;
            this.CaptionButtonColor = System.Drawing.Color.Black;
            this.CaptionButtonHoverColor = System.Drawing.Color.White;
            captionImage1.BackColor = System.Drawing.Color.Transparent;
            captionImage1.Image = global::BroadlinkManager.Properties.Resources.SettingsNoraml;
            captionImage1.Location = new System.Drawing.Point(920, 40);
            captionImage1.Name = "settings";
            captionImage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            captionImage2.Image = global::BroadlinkManager.Properties.Resources.Close;
            captionImage2.Location = new System.Drawing.Point(920, 4);
            captionImage2.Name = "close";
            captionImage3.BackColor = System.Drawing.Color.Transparent;
            captionImage3.Image = global::BroadlinkManager.Properties.Resources.Minus;
            captionImage3.Location = new System.Drawing.Point(883, 4);
            captionImage3.Name = "min";
            this.CaptionImages.Add(captionImage1);
            this.CaptionImages.Add(captionImage2);
            this.CaptionImages.Add(captionImage3);
            this.CaptionVerticalAlignment = Syncfusion.Windows.Forms.VerticalAlignment.Top;
            this.ClientSize = new System.Drawing.Size(955, 533);
            this.ControlBox = false;
            this.Controls.Add(this.ToolBar);
            this.Controls.Add(this.Output);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(143)))), ((int)(((byte)(199)))));
            this.MinimumSize = new System.Drawing.Size(794, 529);
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "Broadlink Manager";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ToolBar.ResumeLayout(false);
            this.ToolBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

     

        #endregion

        private Controls.BetterRichTextBox Output;
      
        private Syncfusion.Windows.Forms.Tools.ToolStripEx ToolBar;
        private System.Windows.Forms.ToolStripButton Scan;
        private System.Windows.Forms.ToolStripComboBox Devices;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton Commands;
        private System.Windows.Forms.ToolStripMenuItem LearnIR;
        private System.Windows.Forms.ToolStripMenuItem SendIR;
        private System.Windows.Forms.ToolStripMenuItem LearnRF;
        private System.Windows.Forms.ToolStripMenuItem SendRF;
        private System.Windows.Forms.ToolStripMenuItem Cancel;
    }
}


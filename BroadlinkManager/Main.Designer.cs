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
            Syncfusion.Windows.Forms.Tools.SplitButtonRenderer splitButtonRenderer1 = new Syncfusion.Windows.Forms.Tools.SplitButtonRenderer();
            Syncfusion.Windows.Forms.CaptionImage captionImage1 = new Syncfusion.Windows.Forms.CaptionImage();
            Syncfusion.Windows.Forms.CaptionImage captionImage2 = new Syncfusion.Windows.Forms.CaptionImage();
            Syncfusion.Windows.Forms.CaptionImage captionImage3 = new Syncfusion.Windows.Forms.CaptionImage();
            this.Actions = new Syncfusion.Windows.Forms.Tools.SplitButton();
            this.LearnIr = new Syncfusion.Windows.Forms.Tools.toolstripitem();
            this.SendIR = new Syncfusion.Windows.Forms.Tools.toolstripitem();
            this.LeranRF = new Syncfusion.Windows.Forms.Tools.toolstripitem();
            this.SendRF = new Syncfusion.Windows.Forms.Tools.toolstripitem();
            this.Output = new BroadlinkManager.Controls.BetterRichTextBox();
            this.btnScan = new System.Windows.Forms.Button();
            this.DevicesList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Actions
            // 
            this.Actions.BeforeTouchSize = new System.Drawing.Size(105, 23);
            this.Actions.DropDownItems.Add(this.LearnIr);
            this.Actions.DropDownItems.Add(this.SendIR);
            this.Actions.DropDownItems.Add(this.LeranRF);
            this.Actions.DropDownItems.Add(this.SendRF);
            this.Actions.DropDownPosition = Syncfusion.Windows.Forms.Tools.Position.Bottom;
            this.Actions.ForeColor = System.Drawing.Color.Black;
            this.Actions.Location = new System.Drawing.Point(321, 16);
            this.Actions.MinimumSize = new System.Drawing.Size(75, 23);
            this.Actions.Name = "Actions";
            splitButtonRenderer1.SplitButton = this.Actions;
            this.Actions.Renderer = splitButtonRenderer1;
            this.Actions.ShowDropDownOnButtonClick = false;
            this.Actions.Size = new System.Drawing.Size(105, 23);
            this.Actions.TabIndex = 3;
            this.Actions.Text = "Actions";
            // 
            // LearnIr
            // 
            this.LearnIr.Image = global::BroadlinkManager.Properties.Resources.Infrared1;
            this.LearnIr.Name = "LearnIr";
            this.LearnIr.Size = new System.Drawing.Size(23, 23);
            this.LearnIr.Text = "Learn IR";
            // 
            // SendIR
            // 
            this.SendIR.Image = global::BroadlinkManager.Properties.Resources.Infrared1;
            this.SendIR.Name = "SendIR";
            this.SendIR.Size = new System.Drawing.Size(23, 23);
            this.SendIR.Text = "Send IR";
            // 
            // LeranRF
            // 
            this.LeranRF.Image = global::BroadlinkManager.Properties.Resources.Radar;
            this.LeranRF.Name = "LeranRF";
            this.LeranRF.Size = new System.Drawing.Size(23, 23);
            this.LeranRF.Text = "Learn RF";
            // 
            // SendRF
            // 
            this.SendRF.Image = global::BroadlinkManager.Properties.Resources.Radar;
            this.SendRF.Name = "SendRF";
            this.SendRF.Size = new System.Drawing.Size(23, 23);
            this.SendRF.Text = "SendRF";
            // 
            // Output
            // 
            this.Output.BackColor = System.Drawing.Color.Black;
            this.Output.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output.ForeColor = System.Drawing.Color.White;
            this.Output.Location = new System.Drawing.Point(0, 62);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(955, 470);
            this.Output.TabIndex = 0;
            this.Output.Text = "";
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(12, 16);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(75, 23);
            this.btnScan.TabIndex = 1;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // DevicesList
            // 
            this.DevicesList.FormattingEnabled = true;
            this.DevicesList.Location = new System.Drawing.Point(93, 16);
            this.DevicesList.Name = "DevicesList";
            this.DevicesList.Size = new System.Drawing.Size(191, 21);
            this.DevicesList.TabIndex = 2;
            this.DevicesList.SelectedIndexChanged += new System.EventHandler(this.DevicesList_SelectedIndexChanged);
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
            this.Controls.Add(this.Actions);
            this.Controls.Add(this.DevicesList);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.Output);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(143)))), ((int)(((byte)(199)))));
            this.MinimumSize = new System.Drawing.Size(794, 529);
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "Broadlink Manager";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.BetterRichTextBox Output;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.ComboBox DevicesList;
        private Syncfusion.Windows.Forms.Tools.SplitButton Actions;
        private Syncfusion.Windows.Forms.Tools.toolstripitem LearnIr;
        private Syncfusion.Windows.Forms.Tools.toolstripitem SendIR;
        private Syncfusion.Windows.Forms.Tools.toolstripitem LeranRF;
        private Syncfusion.Windows.Forms.Tools.toolstripitem SendRF;
    }
}


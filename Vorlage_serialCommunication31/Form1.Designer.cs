namespace Timer
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.serielleSchnittstelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cboPorts = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.schließenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programmBeendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblInfo = new System.Windows.Forms.Label();
            this.trkRed = new System.Windows.Forms.TrackBar();
            this.trkBlue = new System.Windows.Forms.TrackBar();
            this.trkGreen = new System.Windows.Forms.TrackBar();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdSendData = new System.Windows.Forms.Button();
            this.lboModes = new System.Windows.Forms.ListBox();
            this.cmdSave = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkGreen)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serielleSchnittstelleToolStripMenuItem,
            this.programmBeendenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1549, 40);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // serielleSchnittstelleToolStripMenuItem
            // 
            this.serielleSchnittstelleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.portToolStripMenuItem,
            this.schließenToolStripMenuItem});
            this.serielleSchnittstelleToolStripMenuItem.Name = "serielleSchnittstelleToolStripMenuItem";
            this.serielleSchnittstelleToolStripMenuItem.Size = new System.Drawing.Size(251, 36);
            this.serielleSchnittstelleToolStripMenuItem.Text = "Serial Communiation";
            // 
            // portToolStripMenuItem
            // 
            this.portToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cboPorts,
            this.toolStripMenuItem1});
            this.portToolStripMenuItem.Name = "portToolStripMenuItem";
            this.portToolStripMenuItem.Size = new System.Drawing.Size(172, 38);
            this.portToolStripMenuItem.Text = "Port";
            // 
            // cboPorts
            // 
            this.cboPorts.Name = "cboPorts";
            this.cboPorts.Size = new System.Drawing.Size(121, 40);
            this.cboPorts.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(205, 38);
            this.toolStripMenuItem1.Text = "Öffnen";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // schließenToolStripMenuItem
            // 
            this.schließenToolStripMenuItem.Name = "schließenToolStripMenuItem";
            this.schließenToolStripMenuItem.Size = new System.Drawing.Size(172, 38);
            this.schließenToolStripMenuItem.Text = "Close";
            this.schließenToolStripMenuItem.Click += new System.EventHandler(this.schließenToolStripMenuItem_Click);
            // 
            // programmBeendenToolStripMenuItem
            // 
            this.programmBeendenToolStripMenuItem.Name = "programmBeendenToolStripMenuItem";
            this.programmBeendenToolStripMenuItem.Size = new System.Drawing.Size(212, 36);
            this.programmBeendenToolStripMenuItem.Text = "Close Application";
            this.programmBeendenToolStripMenuItem.Click += new System.EventHandler(this.programmBeendenToolStripMenuItem_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(641, 74);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(214, 51);
            this.lblInfo.TabIndex = 17;
            this.lblInfo.Text = "Serial info";
            // 
            // trkRed
            // 
            this.trkRed.Location = new System.Drawing.Point(41, 74);
            this.trkRed.Maximum = 255;
            this.trkRed.Name = "trkRed";
            this.trkRed.Size = new System.Drawing.Size(154, 90);
            this.trkRed.TabIndex = 18;
            this.trkRed.TickFrequency = 16;
            this.trkRed.ValueChanged += new System.EventHandler(this.MixRed);
            this.trkRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trkRed_mouse);
            // 
            // trkBlue
            // 
            this.trkBlue.Location = new System.Drawing.Point(41, 220);
            this.trkBlue.Maximum = 255;
            this.trkBlue.Name = "trkBlue";
            this.trkBlue.Size = new System.Drawing.Size(154, 90);
            this.trkBlue.TabIndex = 19;
            this.trkBlue.TickFrequency = 16;
            this.trkBlue.ValueChanged += new System.EventHandler(this.MixBlue);
            this.trkBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trkBlue_mouse);
            // 
            // trkGreen
            // 
            this.trkGreen.Location = new System.Drawing.Point(41, 146);
            this.trkGreen.Maximum = 255;
            this.trkGreen.Name = "trkGreen";
            this.trkGreen.Size = new System.Drawing.Size(154, 90);
            this.trkGreen.TabIndex = 20;
            this.trkGreen.TickFrequency = 16;
            this.trkGreen.ValueChanged += new System.EventHandler(this.MixGreen);
            this.trkGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trkGreen_mouse);
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Location = new System.Drawing.Point(214, 74);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(89, 51);
            this.lblRed.TabIndex = 21;
            this.lblRed.Text = "Rot";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Location = new System.Drawing.Point(214, 220);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(109, 51);
            this.lblBlue.TabIndex = 22;
            this.lblBlue.Text = "Blau";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Location = new System.Drawing.Point(214, 146);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(141, 51);
            this.lblGreen.TabIndex = 23;
            this.lblGreen.Text = "Gruen";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(409, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 130);
            this.panel1.TabIndex = 24;
            // 
            // cmdSendData
            // 
            this.cmdSendData.Location = new System.Drawing.Point(647, 136);
            this.cmdSendData.Name = "cmdSendData";
            this.cmdSendData.Size = new System.Drawing.Size(190, 130);
            this.cmdSendData.TabIndex = 25;
            this.cmdSendData.Text = "Send Data!";
            this.cmdSendData.UseVisualStyleBackColor = true;
            this.cmdSendData.Click += new System.EventHandler(this.cmdSendData_Click);
            // 
            // lboModes
            // 
            this.lboModes.FormattingEnabled = true;
            this.lboModes.ItemHeight = 51;
            this.lboModes.Location = new System.Drawing.Point(41, 342);
            this.lboModes.Name = "lboModes";
            this.lboModes.Size = new System.Drawing.Size(306, 157);
            this.lboModes.TabIndex = 26;
            this.lboModes.SelectedIndexChanged += new System.EventHandler(this.lboModes_SelectedIndexChanged);
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(497, 342);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(255, 115);
            this.cmdSave.TabIndex = 27;
            this.cmdSave.Text = "Save to Preset";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(25F, 51F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1549, 984);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.lboModes);
            this.Controls.Add(this.cmdSendData);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.trkGreen);
            this.Controls.Add(this.trkBlue);
            this.Controls.Add(this.trkRed);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Vorlage_serialCommunication31";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkGreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem serielleSchnittstelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox cboPorts;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem schließenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programmBeendenToolStripMenuItem;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TrackBar trkRed;
        private System.Windows.Forms.TrackBar trkBlue;
        private System.Windows.Forms.TrackBar trkGreen;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdSendData;
        private System.Windows.Forms.ListBox lboModes;
        private System.Windows.Forms.Button cmdSave;
    }
}


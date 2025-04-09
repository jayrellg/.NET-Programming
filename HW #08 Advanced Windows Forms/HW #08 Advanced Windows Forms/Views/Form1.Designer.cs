namespace HW__08_Advanced_Windows_Forms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bttnExit = new Button();
            panel1 = new Panel();
            buttonAddEdit = new Button();
            textBoxPosition = new TextBox();
            textBoxMinutes = new TextBox();
            textBoxJerseyNumber = new TextBox();
            textBoxName = new TextBox();
            lblMinutesPlayed = new Label();
            lblNumber = new Label();
            lblPosition = new Label();
            lblName = new Label();
            cmbSoccerPlayers = new ComboBox();
            rtbDescription = new RichTextBox();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            miSave = new ToolStripMenuItem();
            miOpen = new ToolStripMenuItem();
            miExit = new ToolStripMenuItem();
            mnuHelp = new ToolStripMenuItem();
            miAbout = new ToolStripMenuItem();
            pbSoccerPlayer = new PictureBox();
            bttnAddImage = new Button();
            bttnEditPlayers = new Button();
            chkJerseyNumberFilter = new CheckBox();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSoccerPlayer).BeginInit();
            SuspendLayout();
            // 
            // bttnExit
            // 
            bttnExit.Location = new Point(533, 452);
            bttnExit.Name = "bttnExit";
            bttnExit.Size = new Size(94, 29);
            bttnExit.TabIndex = 5;
            bttnExit.Text = "Exit";
            bttnExit.UseVisualStyleBackColor = true;
            bttnExit.Click += buttonExit_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonAddEdit);
            panel1.Controls.Add(textBoxPosition);
            panel1.Controls.Add(textBoxMinutes);
            panel1.Controls.Add(textBoxJerseyNumber);
            panel1.Controls.Add(textBoxName);
            panel1.Controls.Add(lblMinutesPlayed);
            panel1.Controls.Add(lblNumber);
            panel1.Controls.Add(lblPosition);
            panel1.Controls.Add(lblName);
            panel1.Location = new Point(78, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(324, 335);
            panel1.TabIndex = 6;
            // 
            // buttonAddEdit
            // 
            buttonAddEdit.Location = new Point(107, 290);
            buttonAddEdit.Name = "buttonAddEdit";
            buttonAddEdit.Size = new Size(94, 29);
            buttonAddEdit.TabIndex = 8;
            buttonAddEdit.Text = "Save";
            buttonAddEdit.UseVisualStyleBackColor = true;
            buttonAddEdit.Click += buttonAddEdit_Click;
            // 
            // textBoxPosition
            // 
            textBoxPosition.Location = new Point(160, 108);
            textBoxPosition.Name = "textBoxPosition";
            textBoxPosition.Size = new Size(125, 27);
            textBoxPosition.TabIndex = 7;
            // 
            // textBoxMinutes
            // 
            textBoxMinutes.Location = new Point(160, 233);
            textBoxMinutes.Name = "textBoxMinutes";
            textBoxMinutes.Size = new Size(125, 27);
            textBoxMinutes.TabIndex = 6;
            // 
            // textBoxJerseyNumber
            // 
            textBoxJerseyNumber.Location = new Point(160, 174);
            textBoxJerseyNumber.Name = "textBoxJerseyNumber";
            textBoxJerseyNumber.Size = new Size(125, 27);
            textBoxJerseyNumber.TabIndex = 5;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(160, 45);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(125, 27);
            textBoxName.TabIndex = 4;
            // 
            // lblMinutesPlayed
            // 
            lblMinutesPlayed.AutoSize = true;
            lblMinutesPlayed.Location = new Point(0, 240);
            lblMinutesPlayed.Name = "lblMinutesPlayed";
            lblMinutesPlayed.Size = new Size(109, 20);
            lblMinutesPlayed.TabIndex = 3;
            lblMinutesPlayed.Text = "Minutes Played";
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Location = new Point(46, 181);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(63, 20);
            lblNumber.TabIndex = 2;
            lblNumber.Text = "Number";
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Location = new Point(48, 115);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(61, 20);
            lblPosition.TabIndex = 1;
            lblPosition.Text = "Position";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(60, 48);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // cmbSoccerPlayers
            // 
            cmbSoccerPlayers.FormattingEnabled = true;
            cmbSoccerPlayers.Location = new Point(935, 12);
            cmbSoccerPlayers.Name = "cmbSoccerPlayers";
            cmbSoccerPlayers.Size = new Size(151, 28);
            cmbSoccerPlayers.TabIndex = 7;
            cmbSoccerPlayers.SelectedIndexChanged += cmbSoccerPlayers_SelectedIndexChanged;
            // 
            // rtbDescription
            // 
            rtbDescription.Location = new Point(810, 63);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(276, 304);
            rtbDescription.TabIndex = 8;
            rtbDescription.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(817, 15);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 9;
            label1.Text = "Select a Player :";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuFile, mnuHelp });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1147, 28);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { miSave, miOpen, miExit });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(46, 24);
            mnuFile.Text = "File";
            // 
            // miSave
            // 
            miSave.Name = "miSave";
            miSave.Size = new Size(167, 26);
            miSave.Text = "Save";
            miSave.Click += miSave_Click;
            // 
            // miOpen
            // 
            miOpen.Name = "miOpen";
            miOpen.Size = new Size(167, 26);
            miOpen.Text = "Open";
            miOpen.Click += miOpen_Click;
            // 
            // miExit
            // 
            miExit.Name = "miExit";
            miExit.ShortcutKeys = Keys.Control | Keys.X;
            miExit.Size = new Size(167, 26);
            miExit.Text = "Exit";
            miExit.Click += miExit_Click;
            // 
            // mnuHelp
            // 
            mnuHelp.DropDownItems.AddRange(new ToolStripItem[] { miAbout });
            mnuHelp.Name = "mnuHelp";
            mnuHelp.Size = new Size(55, 24);
            mnuHelp.Text = "Help";
            // 
            // miAbout
            // 
            miAbout.Name = "miAbout";
            miAbout.Size = new Size(133, 26);
            miAbout.Text = "About";
            miAbout.Click += miAbout_Click;
            // 
            // pbSoccerPlayer
            // 
            pbSoccerPlayer.BackColor = SystemColors.ActiveBorder;
            pbSoccerPlayer.Location = new Point(439, 31);
            pbSoccerPlayer.Name = "pbSoccerPlayer";
            pbSoccerPlayer.Size = new Size(296, 336);
            pbSoccerPlayer.SizeMode = PictureBoxSizeMode.Zoom;
            pbSoccerPlayer.TabIndex = 11;
            pbSoccerPlayer.TabStop = false;
            // 
            // bttnAddImage
            // 
            bttnAddImage.Location = new Point(533, 383);
            bttnAddImage.Name = "bttnAddImage";
            bttnAddImage.Size = new Size(94, 29);
            bttnAddImage.TabIndex = 12;
            bttnAddImage.Text = "Add Image";
            bttnAddImage.UseVisualStyleBackColor = true;
            bttnAddImage.Click += bttnAddImage_Click;
            // 
            // bttnEditPlayers
            // 
            bttnEditPlayers.Location = new Point(913, 383);
            bttnEditPlayers.Name = "bttnEditPlayers";
            bttnEditPlayers.Size = new Size(94, 29);
            bttnEditPlayers.TabIndex = 13;
            bttnEditPlayers.Text = "Edit Players";
            bttnEditPlayers.UseVisualStyleBackColor = true;
            bttnEditPlayers.Click += bttnEditPlayers_Click;
            // 
            // chkJerseyNumberFilter
            // 
            chkJerseyNumberFilter.AutoSize = true;
            chkJerseyNumberFilter.Location = new Point(827, 418);
            chkJerseyNumberFilter.Name = "chkJerseyNumberFilter";
            chkJerseyNumberFilter.Size = new Size(287, 24);
            chkJerseyNumberFilter.TabIndex = 14;
            chkJerseyNumberFilter.Text = "Show Players With Jersey Number > 11\r\n";
            chkJerseyNumberFilter.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 493);
            Controls.Add(chkJerseyNumberFilter);
            Controls.Add(bttnEditPlayers);
            Controls.Add(bttnAddImage);
            Controls.Add(pbSoccerPlayer);
            Controls.Add(label1);
            Controls.Add(rtbDescription);
            Controls.Add(cmbSoccerPlayers);
            Controls.Add(panel1);
            Controls.Add(bttnExit);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Soccer Player";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbSoccerPlayer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private Button bttnExit;
        private Panel panel1;
        private Label lblName;
        private Label lblPosition;
        private Label lblMinutesPlayed;
        private Label lblNumber;
        private TextBox textBoxPosition;
        private TextBox textBoxMinutes;
        private TextBox textBoxJerseyNumber;
        private TextBox textBoxName;
        private Button buttonAddEdit;
        private ComboBox cmbSoccerPlayers;
        private RichTextBox rtbDescription;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuHelp;
        private ToolStripMenuItem miExit;
        private ToolStripMenuItem miSave;
        private ToolStripMenuItem miOpen;
        private ToolStripMenuItem miAbout;
        private PictureBox pbSoccerPlayer;
        private Button bttnAddImage;
        private Button bttnEditPlayers;
        private CheckBox chkJerseyNumberFilter;
    }
}
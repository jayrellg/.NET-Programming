namespace HW__07_Windows_Forms.Views
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // bttnExit
            // 
            bttnExit.Location = new Point(340, 385);
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
            cmbSoccerPlayers.Location = new Point(599, 32);
            cmbSoccerPlayers.Name = "cmbSoccerPlayers";
            cmbSoccerPlayers.Size = new Size(151, 28);
            cmbSoccerPlayers.TabIndex = 7;
            cmbSoccerPlayers.SelectedIndexChanged += cmbSoccerPlayers_SelectedIndexChanged;
            // 
            // rtbDescription
            // 
            rtbDescription.Location = new Point(494, 93);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(256, 289);
            rtbDescription.TabIndex = 8;
            rtbDescription.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(481, 35);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 9;
            label1.Text = "Select a Player :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(rtbDescription);
            Controls.Add(cmbSoccerPlayers);
            Controls.Add(panel1);
            Controls.Add(bttnExit);
            Name = "Form1";
            Text = "Soccer Player";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
    }
}

namespace HW__08_Advanced_Windows_Forms.Views
{
    partial class AboutDialog
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
            bttnClose = new Button();
            rtbAboutText = new RichTextBox();
            SuspendLayout();
            // 
            // bttnClose
            // 
            bttnClose.Location = new Point(359, 317);
            bttnClose.Name = "bttnClose";
            bttnClose.Size = new Size(94, 29);
            bttnClose.TabIndex = 0;
            bttnClose.Text = "Close";
            bttnClose.UseVisualStyleBackColor = true;
            bttnClose.Click += bttnClose_Click;
            // 
            // rtbAboutText
            // 
            rtbAboutText.Dock = DockStyle.Top;
            rtbAboutText.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rtbAboutText.Location = new Point(0, 0);
            rtbAboutText.Name = "rtbAboutText";
            rtbAboutText.Size = new Size(806, 311);
            rtbAboutText.TabIndex = 1;
            rtbAboutText.Text = "";
            // 
            // AboutDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 368);
            Controls.Add(rtbAboutText);
            Controls.Add(bttnClose);
            Name = "AboutDialog";
            Text = "AboutDialog";
            ResumeLayout(false);
        }

        #endregion

        private Button bttnClose;
        private RichTextBox rtbAboutText;
    }
}
namespace HW__08_Advanced_Windows_Forms.Views
{
    partial class PlayerEditDialog
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
            components = new System.ComponentModel.Container();
            dgvSoccerPlayer = new DataGridView();
            bttnSave = new Button();
            bttnCancel = new Button();
            mnuStrip = new ContextMenuStrip(components);
            findToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvSoccerPlayer).BeginInit();
            mnuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSoccerPlayer
            // 
            dgvSoccerPlayer.AllowUserToAddRows = false;
            dgvSoccerPlayer.AllowUserToDeleteRows = false;
            dgvSoccerPlayer.AllowUserToOrderColumns = true;
            dgvSoccerPlayer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSoccerPlayer.Location = new Point(12, 12);
            dgvSoccerPlayer.Name = "dgvSoccerPlayer";
            dgvSoccerPlayer.RowHeadersWidth = 51;
            dgvSoccerPlayer.Size = new Size(776, 353);
            dgvSoccerPlayer.TabIndex = 0;
            dgvSoccerPlayer.ColumnHeaderMouseDoubleClick += dgvSoccerPlayer_ColumnHeaderMouseDoubleClick;
            // 
            // bttnSave
            // 
            bttnSave.Location = new Point(88, 409);
            bttnSave.Name = "bttnSave";
            bttnSave.Size = new Size(94, 29);
            bttnSave.TabIndex = 1;
            bttnSave.Text = "Save";
            bttnSave.UseVisualStyleBackColor = true;
            bttnSave.Click += bttnSave_Click;
            // 
            // bttnCancel
            // 
            bttnCancel.Location = new Point(589, 409);
            bttnCancel.Name = "bttnCancel";
            bttnCancel.Size = new Size(94, 29);
            bttnCancel.TabIndex = 2;
            bttnCancel.Text = "Cancel";
            bttnCancel.UseVisualStyleBackColor = true;
            bttnCancel.Click += bttnCancel_Click;
            // 
            // mnuStrip
            // 
            mnuStrip.ImageScalingSize = new Size(20, 20);
            mnuStrip.Items.AddRange(new ToolStripItem[] { findToolStripMenuItem });
            mnuStrip.Name = "mnuStrip";
            mnuStrip.Size = new Size(107, 28);
            // 
            // findToolStripMenuItem
            // 
            findToolStripMenuItem.Name = "findToolStripMenuItem";
            findToolStripMenuItem.Size = new Size(106, 24);
            findToolStripMenuItem.Text = "Find";
            findToolStripMenuItem.Click += findToolStripMenuItem_Click;
            // 
            // PlayerEditDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bttnCancel);
            Controls.Add(bttnSave);
            Controls.Add(dgvSoccerPlayer);
            Name = "PlayerEditDialog";
            Text = "PlayerEditDialog";
            ((System.ComponentModel.ISupportInitialize)dgvSoccerPlayer).EndInit();
            mnuStrip.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSoccerPlayer;
        private Button bttnSave;
        private Button bttnCancel;
        private ContextMenuStrip mnuStrip;
        private ToolStripMenuItem findToolStripMenuItem;
    }
}
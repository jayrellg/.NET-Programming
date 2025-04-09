using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HW__08_Advanced_Windows_Forms.Models;

namespace HW__08_Advanced_Windows_Forms.Views
{
    public partial class PlayerEditDialog : Form
    {
        // List to be returned to the Main form
        // 'private set' to ptotect data so that only code inside this class can assign a value to this property.
        public List<SoccerPlayer> EditedPlayers { get; private set; } = null;  //Initally Null, only assigned data when user clicks save
        private List<SoccerPlayer> tempPlayers;

        private bool sortAscending = true; // toggle flag for column sort


        public PlayerEditDialog(List<SoccerPlayer> players)
        {
            InitializeComponent();

            tempPlayers = players.Select(p => new SoccerPlayer(p.PlayerName, p.PlayerPosition, p.ImagePath, p.JerseyNumber, p.MinutesPlayed)).ToList();
            dgvSoccerPlayer.DataSource = tempPlayers;
            dgvSoccerPlayer.ContextMenuStrip = mnuStrip;
        }

        // Save chnges from tempPlayers to EditedPLayers and return them to Main Form when user clicks 'Save'
        private void bttnSave_Click(object sender, EventArgs e)
        {
            EditedPlayers = tempPlayers; // Only apply changes on save
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        //Close Edit Form
        private void bttnCancel_Click(object sender, EventArgs e)
        {
            //close form but not whole application
            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }

        //Method to Handle column sorting when user doubleClicks column header
        private void dgvSoccerPlayer_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Get name of property that the clicked column is bound to.
            string columnName = dgvSoccerPlayer.Columns[e.ColumnIndex].DataPropertyName;
            
            if (string.IsNullOrWhiteSpace(columnName)) return;

            // Sort the tempPlayers list based on the column clicked
            tempPlayers = sortAscending
                ? tempPlayers.OrderBy(p => typeof(SoccerPlayer).GetProperty(columnName).GetValue(p)).ToList() // If true , sort Ascending
                : tempPlayers.OrderByDescending(p => typeof(SoccerPlayer).GetProperty(columnName).GetValue(p)).ToList(); // If false , sort Descending

            sortAscending = !sortAscending;

            // Rebind the sorted list to the DataGridView
            dgvSoccerPlayer.DataSource = null;  // Clear Current Data
            dgvSoccerPlayer.DataSource = tempPlayers;  // re-bind the freshly sorted list.

        }

        // Handles Menu strip 'Find' Click, Allows user search for specific values. 
        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Displays a prompt in a dialog box, waits for the user to input search term 
            string searchTerm = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter the value to search for:", //Text Promt
                "Find", //Tittle
                "", //Default Value
                -1, -1 // Dialog box Position
            ).Trim().ToLower();  //Ignore Case and trailing white spaces



            if (string.IsNullOrEmpty(searchTerm))
                return;


            bool found = false;  // Flag to track if a match is found

            // Loop through all rows in the DataGridView
            foreach (DataGridViewRow row in dgvSoccerPlayer.Rows)
            {
                // Loop through all cells in the current row
                foreach (DataGridViewCell cell in row.Cells)
                {
                    // Check if the cell value contains the search term
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchTerm))
                    {
                        // Select the row where the match is found
                        row.Selected = true;
                        found = true;
                        break;  // Stop searching after the first match is found in this row
                    }
                    else
                    {
                        // Deselect the row if no match is found in this cell
                        row.Selected = false;
                    }
                }
            }

            // If no match is found, show a message
            if (!found)
            {
                MessageBox.Show("No results found.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

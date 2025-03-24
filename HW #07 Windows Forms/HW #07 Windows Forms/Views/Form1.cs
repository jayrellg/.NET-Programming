
using System.Xml.Linq;
using HW__07_Windows_Forms.Controllers;
using HW__07_Windows_Forms.Models;

namespace HW__07_Windows_Forms.Views
{
    public partial class Form1 : Form
    {
        // Controller instance to manage soccer player data and logic
        private SoccerPlayerController controller = new SoccerPlayerController();

        // Constructor to initialize the form and load players
        public Form1()
        {
            InitializeComponent();
            LoadPlayers();
        }

        // Method to load players from the controller into the combo box
        private void LoadPlayers()
        {
            cmbSoccerPlayers.Items.Clear();
            foreach (SoccerPlayer player in controller.GetPlayers())
            {
                cmbSoccerPlayers.Items.Add(player.PlayerName);
            }
        }

        // Event handler method for the Add/Edit button , this adds a new player or edits and existing one
        private void buttonAddEdit_Click(object sender, EventArgs e)
        {
            // Validate that the required fields (name and position) are not empty
            if (string.IsNullOrWhiteSpace(textBoxName.Text) || string.IsNullOrWhiteSpace(textBoxPosition.Text))
            {
                MessageBox.Show("Please enter all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Check if a player with the same name already exists
            if (controller.PlayerExists(textBoxName.Text))
            {
                // Prompt the user to confirm if they want to edit the existing player
                DialogResult result = MessageBox.Show($"A player named {textBoxName.Text} already exists. Do you want to edit this player?", "Edit Player", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Update the existing player with new data
                    controller.UpdatePlayer(textBoxName.Text, textBoxPosition.Text, textBoxJerseyNumber.Text, textBoxMinutes.Text);
                }
                else
                {
                    // Notify the user that editing was cancelled and return
                    MessageBox.Show("Editing cancelled. Please use a different name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                // Add a new player with the provided data
                controller.AddPlayer(textBoxName.Text, textBoxPosition.Text, textBoxJerseyNumber.Text, textBoxMinutes.Text);
            }

            // Refresh the description box and combo box with updated player data , and Clear input fields
            UpdateDisplay();
            LoadPlayers();
            ClearFields();
        }

        // Event handler for when a player is selected from the combo box
        private void cmbSoccerPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Find the selected player in the controller's player list
            SoccerPlayer? player = controller.GetPlayers().Find(p => p.PlayerName == cmbSoccerPlayers.SelectedItem.ToString());
            if (player != null)
            {
                // Populate the input fields with the selected player's data
                textBoxName.Text = player.PlayerName;
                textBoxPosition.Text = player.PlayerPosition;
                textBoxJerseyNumber.Text = player.JerseyNumber.ToString();
                textBoxMinutes.Text = player.MinutesPlayed.ToString();
            }
        }


        // Method to update the display with all players' information
        private void UpdateDisplay()
        {
            rtbDescription.Text = string.Join("\n\n", controller.GetPlayers().Select(p => p.ToString()));
        }
        
        // Method to clear all input fields
        private void ClearFields()
        {
            textBoxName.Clear();
            textBoxPosition.Clear();
            textBoxJerseyNumber.Clear();
            textBoxMinutes.Clear();
        }

        // Event handler for the Exit button (Exit application)
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }


    }
}

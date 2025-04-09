using HW__08_Advanced_Windows_Forms.Controllers;
using HW__08_Advanced_Windows_Forms.Models;
using HW__08_Advanced_Windows_Forms.Views;
using System.Windows.Forms;
using Utilities;

namespace HW__08_Advanced_Windows_Forms
{
    public partial class Form1 : Form
    {
        // Controller instance to manage soccer player data and logic
        private SoccerPlayerController controller = new SoccerPlayerController();

        private string selectedImagePath = string.Empty;  // Store the image path locally


        // Constructor to initialize the form and load players
        public Form1()
        {
            InitializeComponent();

        }

        // Method to load players from the controller into the combo box 
        private void LoadPlayersComboBox()
        {
            cmbSoccerPlayers.Items.Clear();
            foreach (SoccerPlayer player in controller.GetPlayers()) // Get all players from the controller
            {
                cmbSoccerPlayers.Items.Add(player.PlayerName); // Add player names to the combo box
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
                    controller.UpdatePlayer(textBoxName.Text, textBoxPosition.Text, textBoxJerseyNumber.Text, textBoxMinutes.Text, selectedImagePath);
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
                controller.AddPlayer(textBoxName.Text, textBoxPosition.Text, textBoxJerseyNumber.Text, textBoxMinutes.Text, selectedImagePath);
            }

            UpdateDescriptionRTB(); // Refresh the description box
            LoadPlayersComboBox(); //load players into combo box
            ClearFields(); //clear input fields
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


                // Show image if available
                if (!string.IsNullOrEmpty(player.ImagePath) && File.Exists(player.ImagePath))
                {
                    pbSoccerPlayer.Image = Image.FromFile(player.ImagePath);
                }
                else
                {
                    pbSoccerPlayer.Image = null; // Clear if no image
                }
            }
        }


        // Method to update the rich text box with all players' information UpdateDescriptionRTB
        private void UpdateDescriptionRTB()
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

        // Event handler for the Save button, user can save thier players obejcts and write them to a file. 

        private void miSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File (*.txt)|*.txt|JSON File (*.json)|*.json";
            saveFileDialog.Title = "Save Soccer Player Data";
            saveFileDialog.FilterIndex = 1;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = saveFileDialog.FileName;
                    string extension = Path.GetExtension(filePath).ToLower();

                    // Get list of players from controller
                    List<SoccerPlayer> players = controller.GetPlayers();
                    SoccerPlayerWriter writer = new SoccerPlayerWriter();

                    switch (extension)
                    {
                        case ".txt":
                            writer.WriteToTextFile(players, filePath);
                            break;
                        case ".json":
                            writer.WriteToJsonFile(players, filePath);
                            break;
                        default:
                            MessageBox.Show("Unsupported file format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }

                    MessageBox.Show("Data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to save data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        // Event handler for the Open button, allows users to open saved player data files
        private void miOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text File (*.txt)|*.txt|JSON File (*.json)|*.json";
            openFileDialog.Title = "Open Soccer Player Data";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string extension = Path.GetExtension(filePath).ToLower();
                DataSerializer serializer = new DataSerializer();

                try
                {
                    List<SoccerPlayer> loadedPlayers;

                    switch (extension)
                    {
                        case ".txt":
                            loadedPlayers = controller.ReadFromTextFile(filePath);
                            break;
                        case ".json":
                            loadedPlayers = serializer.JsonDeserialize<List<SoccerPlayer>>(filePath);
                            break;
                        default:
                            MessageBox.Show("Unsupported file format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }

                    // If successful, replace existing players and refresh UI
                    if (loadedPlayers != null && loadedPlayers.Count > 0)
                    {
                        controller.SetPlayers(loadedPlayers);
                        LoadPlayersComboBox();
                        UpdateDescriptionRTB();
                        ClearFields();
                        MessageBox.Show("Data loaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No players were loaded. Keeping previous data.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void bttnAddImage_Click(object sender, EventArgs e)
        {
            // Open file dialog for selecting an image
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select a Player Image";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";

                // Show dialog and check if the user selected a file
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Load and display the image in the PictureBox
                    pbSoccerPlayer.Image = Image.FromFile(openFileDialog.FileName);
                    selectedImagePath = openFileDialog.FileName;
                }
                else
                {
                    MessageBox.Show("No image selected. Please choose an image file.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }



        private void bttnEditPlayers_Click(object sender, EventArgs e)
        {
            PlayerEditDialog editDialog;

            if (chkJerseyNumberFilter.Checked) 
            {
                // Open the modal dialog to edit players using a grid view using a modal
                editDialog = new PlayerEditDialog(controller.GetPlayers().Where(p => p.JerseyNumber > 11).ToList());
            }
            else
            {
                editDialog = new PlayerEditDialog(controller.GetPlayers());

            }

            // Show the dialog and check if the changes were saved
            if (editDialog.ShowDialog() == DialogResult.OK && editDialog.EditedPlayers != null)
            {
                // If changes were saved, refresh the display on the main form
                controller.SetPlayers(editDialog.EditedPlayers);
                LoadPlayersComboBox(); // Reload players into combo box
                UpdateDescriptionRTB();// Update the rich text box with new data
                ClearFields(); // Clear input fields
            }
        }


        private void miAbout_Click(object sender, EventArgs e)
        {
            // Open the About dialog as modal
            AboutDialog aboutDialog = new AboutDialog();
            aboutDialog.ShowDialog();  // This makes the About dialog modal
        }


        

        private void miExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

    }
}

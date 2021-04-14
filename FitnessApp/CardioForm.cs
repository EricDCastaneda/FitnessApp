using System;
using System.IO;
using System.Windows.Forms;

namespace FitnessApp
{
    public partial class CardioForm : Form
    {
        public CardioForm()
        {
            InitializeComponent();
        }

        private void recordButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool valid = true; // To hold a flag indicating validity
                string dateInput = dateTextBox.Text.Trim(); // To hold a trimmed copy of the user's Date input

                // Check if input was entered.
                if (dateInput != "")
                {
                    // Check each character in input.
                    foreach (char ch in dateInput)
                    {
                        // If this character is a letter, the Date isn't valid.
                        if (char.IsLetter(ch))
                        {
                            // Clear Date text and display error message.
                            valid = false;
                            dateTextBox.Text = "";
                            MessageBox.Show("Please try again! The Date format should be MM/DD/YY using numbers.");
                            dateTextBox.Focus();
                        }
                    }
                }

                string exerciseInput = exerciseTextBox.Text.Trim(); // To hold a trimmed copy of the user's Exercise Name input

                // Check if input was entered.
                if (exerciseInput != "")
                {
                    // Check each character in input.
                    foreach (char ch in exerciseInput)
                    {
                        // If this character is a digit, the Exercise Name isn't valid.
                        if (char.IsDigit(ch))
                        {
                            // Clear Exercise Name text and display error message.
                            valid = false;
                            exerciseTextBox.Text = "";
                            MessageBox.Show("Please try again! The Exercise Name should only consist of letters without any numbers.");
                            exerciseTextBox.Focus();
                        }
                    }
                }

                string durationInput = durationTextBox.Text.Trim(); // To hold a trimmed copy of the user's Duration input

                // Check if input was entered.
                if (durationInput != "")
                {
                    // Check each character in input.
                    foreach (char ch in durationInput)
                    {
                        // If this character is a letter, the durationInput isn't valid.
                        if (char.IsLetter(ch))
                        {
                            // Clear Duration text and display error message.
                            valid = false;
                            durationTextBox.Text = "";
                            MessageBox.Show("Please try again! The Duration should be numeric and not include any letters or special characters.");
                            durationTextBox.Focus();
                        }
                    }
                }

                if (valid)
                {

                    // Declare a StreamWriter variable. 
                    StreamWriter outputFile;

                    // Append the file and get a StreamWriter object.                  
                    outputFile = File.AppendText("Fitness.txt");

                    // Write the fitness information to the file. 
                    outputFile.WriteLine("Date: " + dateTextBox.Text + "\nExercise: " + exerciseTextBox.Text + "\nDuration: "
                    + durationTextBox.Text);

                    // Close the file. 
                    outputFile.Close();

                    // Let the user know the exercise was written. 
                    MessageBox.Show("The exercise was recorded.");
                }
            }
            catch (Exception ex)
            {
                // Display an error message. 
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}

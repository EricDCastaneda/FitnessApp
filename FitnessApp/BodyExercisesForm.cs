using System;
using System.IO;
using System.Windows.Forms;

namespace FitnessApp
{
    public partial class BodyExercisesForm : Form
    {
        public BodyExercisesForm()
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
                            MessageBox.Show("Please try again! The Exercise Name should only consist of letters without any numbers or special characters.");
                            exerciseTextBox.Focus();
                        }
                    }
                }

                // Temporary variables to hold the number of reps per set
                int firstSetInput, secondSetInput, thirdSetInput;               

                // Check for number input in the firstSetRepsTextBox.
                if (int.TryParse(firstSetRepsTextBox.Text, out firstSetInput))
                {
                    valid = true;

                    // Check for number input in the secondSetRepsTextBox.
                    if (int.TryParse(secondSetRepsTextBox.Text, out secondSetInput))
                    {
                        valid = true;

                        // Check for number input in the thirdSetRepsTextBox.
                        if (int.TryParse(thirdSetRepsTextBox.Text, out thirdSetInput))
                        {
                            valid = true;
                        }
                        else
                        {
                            // Clear thirdSet text and display error message.
                            valid = false;
                            thirdSetRepsTextBox.Text = "";
                            MessageBox.Show("Please try again! The number of reps should be numeric and not include any letters or special characters.");
                            thirdSetRepsTextBox.Focus();
                        }
                    }
                    else
                    {
                        // Clear secondSet text and display error message.
                        valid = false;
                        secondSetRepsTextBox.Text = "";
                        MessageBox.Show("Please try again! The number of reps should be numeric and not include any letters or special characters.");
                        secondSetRepsTextBox.Focus();
                    }
                }
                else
                {
                    // Clear firstSet text and display error message.
                    valid = false;
                    firstSetRepsTextBox.Text = "";
                    MessageBox.Show("Please try again! The number of reps should be numeric and not include any letters or special characters.");
                    firstSetRepsTextBox.Focus();
                }

                if (valid)
                {

                    // Declare a StreamWriter variable. 
                    StreamWriter outputFile;

                    // Append the file and get a StreamWriter object.                  
                    outputFile = File.AppendText("Fitness.txt");

                    // Write the fitness information to the file. 
                    outputFile.WriteLine("Date: " + dateTextBox.Text + "\nExercise: " + exerciseTextBox.Text + "\nFirst Set Reps: "
                    + firstSetRepsTextBox.Text + "\nSecond Set Reps: " + secondSetRepsTextBox.Text + "\nThird Set Reps: "
                    + thirdSetRepsTextBox.Text);

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

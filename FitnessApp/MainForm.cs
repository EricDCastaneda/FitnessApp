using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void cardioButton_Click(object sender, EventArgs e)
        {
            // Create an instance of the CardioForm class.
            CardioForm myCardioForm = new CardioForm();

            // Display the form.
            myCardioForm.ShowDialog();
        }

        private void bodyExercisesButton_Click(object sender, EventArgs e)
        {
            // Create an instance of the BodyExercisesForm class.
            BodyExercisesForm myBodyExercisesForm = new BodyExercisesForm();

            // Display the form.
            myBodyExercisesForm.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}

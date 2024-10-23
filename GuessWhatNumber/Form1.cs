using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessWhatNumber
{
    public partial class Form1 : Form
    {
        Random ranGen = new Random();
        int secretNumber;

        public Form1()
        {
            InitializeComponent();

            secretNumber = ranGen.Next(1, 101);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int userGuess = Convert.ToInt32(guessInput.Text);
            
            if (userGuess == secretNumber)
            {
                guessOutput.Text = "YOU GOT IT!!!!";

            }
            else if (userGuess > secretNumber)
            {
                guessOutput.Text = "Too high.";
            }
            else if (userGuess < secretNumber)
            {
                guessOutput.Text = "Too low.";
            }
        }
    }
}

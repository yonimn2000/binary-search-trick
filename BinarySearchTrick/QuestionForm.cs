using System;
using System.Windows.Forms;

namespace YonatanMankovich.BinarySearchTrick
{
    public partial class QuestionForm : Form
    {
        private readonly BinarySearcher binarySearcher;
        private int guesses;
        private readonly int totalGuesses;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lowerBound">Inclusive</param>
        /// <param name="upperBound">Inclusive</param>
        public QuestionForm(long lowerBound, long upperBound)
        {
            InitializeComponent();
            binarySearcher = new BinarySearcher(lowerBound, upperBound);
            numberLBL.Text = binarySearcher.CurrentNumber.ToString();
            totalGuesses = binarySearcher.GetMaxNumberOfGuesses();
            guesses = 0;
            MakeMove();
        }

        private void correctBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void leftBTN_Click(object sender, EventArgs e)
        {
            binarySearcher.GoLeft();
            MakeMove();
        }

        private void rightBTN_Click(object sender, EventArgs e)
        {
            binarySearcher.GoRight();
            MakeMove();
        }

        private void MakeMove()
        {
            numberLBL.Text = binarySearcher.CurrentNumber.ToString();
            Text = $"Guess {++guesses} out of {totalGuesses}";
            if (guesses == totalGuesses)
                leftBTN.Enabled = rightBTN.Enabled = false;
            boundsLBL.Text = $"Your number is between {binarySearcher.LowerBound} and {binarySearcher.UpperBound}.";
        }
    }
}
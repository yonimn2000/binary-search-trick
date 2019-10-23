using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace YonatanMankovich.BinarySearchTrick
{
    public partial class QuestionForm : Form
    {
        private BinarySearcher binarySearcher;
        private int guesses;
        private int totalGuesses;
        private readonly Stack<BinarySearcher> stack = new Stack<BinarySearcher>();

        public QuestionForm(long lowerBound, long upperBound)
        {
            InitializeComponent();
            binarySearcher = new BinarySearcher(lowerBound, upperBound);
            stack.Push(binarySearcher);
            totalGuesses = binarySearcher.GetMaxNumberOfGuesses();
            guesses = 1;
            ShowBinarySearcherData();
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
            stack.Push(binarySearcher);
            guesses++;
            ShowBinarySearcherData();
        }

        private void ShowBinarySearcherData()
        {
            numberLBL.Text = binarySearcher.CurrentNumber.ToString();
            Text = $"Guess {guesses} out of {totalGuesses}";
            leftBTN.Enabled = rightBTN.Enabled = !(guesses == totalGuesses);
            boundsLBL.Text = $"Your number is between {binarySearcher.LowerBound} and {binarySearcher.UpperBound - 1}.";
        }

        private void undoBTN_Click(object sender, EventArgs e)
        {
            if (stack.Count > 1)
            {
                guesses--;
                stack.Pop();
                binarySearcher = stack.Pop();
                stack.Push(binarySearcher);
                ShowBinarySearcherData();
            }
        }
    }
}
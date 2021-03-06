﻿using System;
using System.Windows.Forms;

namespace YonatanMankovich.BinarySearchTrick
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            UpdateMaxGuessesLBL();
        }

        private void setBTN_Click(object sender, EventArgs e)
        {
            DialogResult thinkDialogResult = MessageBox.Show($"Think of a number between {lowerBoundNUD.Value} and {upperBoundNUD.Value}.",
                "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (thinkDialogResult == DialogResult.OK)
            {
                QuestionForm questionForm = new QuestionForm((long)lowerBoundNUD.Value, (long)upperBoundNUD.Value+1);
                questionForm.ShowDialog();
                questionForm.Dispose();
            }
        }

        private void NUDs_ValueChanged(object sender, EventArgs e)
        {
            UpdateMaxGuessesLBL();
            lowerBoundNUD.Maximum = upperBoundNUD.Value - 1;
        }

        private void NUDs_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateMaxGuessesLBL();
        }

        private void UpdateMaxGuessesLBL()
        {
            maxGuessesLBL.Text = "Your number will be guessed with "
                            + BinarySearcher.GetMaxNumberOfGuessesForRange((long)lowerBoundNUD.Value, (long)upperBoundNUD.Value + 1)
                            + " guesses or less.";
        }
    }
}
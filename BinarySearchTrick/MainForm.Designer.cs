namespace YonatanMankovich.BinarySearchTrick
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lowerBoundNUD = new System.Windows.Forms.NumericUpDown();
            this.upperBoundNUD = new System.Windows.Forms.NumericUpDown();
            this.setBTN = new System.Windows.Forms.Button();
            this.maxGuessesLBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lowerBoundNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperBoundNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // lowerBoundNUD
            // 
            this.lowerBoundNUD.Location = new System.Drawing.Point(12, 12);
            this.lowerBoundNUD.Name = "lowerBoundNUD";
            this.lowerBoundNUD.Size = new System.Drawing.Size(96, 20);
            this.lowerBoundNUD.TabIndex = 0;
            this.lowerBoundNUD.ValueChanged += new System.EventHandler(this.NUDs_ValueChanged);
            this.lowerBoundNUD.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NUDs_KeyUp);
            // 
            // upperBoundNUD
            // 
            this.upperBoundNUD.Location = new System.Drawing.Point(114, 12);
            this.upperBoundNUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.upperBoundNUD.Name = "upperBoundNUD";
            this.upperBoundNUD.Size = new System.Drawing.Size(96, 20);
            this.upperBoundNUD.TabIndex = 1;
            this.upperBoundNUD.Value = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.upperBoundNUD.ValueChanged += new System.EventHandler(this.NUDs_ValueChanged);
            this.upperBoundNUD.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NUDs_KeyUp);
            // 
            // setBTN
            // 
            this.setBTN.Location = new System.Drawing.Point(216, 12);
            this.setBTN.Name = "setBTN";
            this.setBTN.Size = new System.Drawing.Size(96, 20);
            this.setBTN.TabIndex = 2;
            this.setBTN.Text = "Set";
            this.setBTN.UseVisualStyleBackColor = true;
            this.setBTN.Click += new System.EventHandler(this.setBTN_Click);
            // 
            // maxGuessesLBL
            // 
            this.maxGuessesLBL.AutoSize = true;
            this.maxGuessesLBL.Location = new System.Drawing.Point(9, 35);
            this.maxGuessesLBL.Name = "maxGuessesLBL";
            this.maxGuessesLBL.Size = new System.Drawing.Size(251, 13);
            this.maxGuessesLBL.TabIndex = 3;
            this.maxGuessesLBL.Text = "Your number will be guessed with 7 guesses or less.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 55);
            this.Controls.Add(this.maxGuessesLBL);
            this.Controls.Add(this.setBTN);
            this.Controls.Add(this.upperBoundNUD);
            this.Controls.Add(this.lowerBoundNUD);
            this.Name = "MainForm";
            this.Text = "Binary Search Trick";
            ((System.ComponentModel.ISupportInitialize)(this.lowerBoundNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperBoundNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown lowerBoundNUD;
        private System.Windows.Forms.NumericUpDown upperBoundNUD;
        private System.Windows.Forms.Button setBTN;
        private System.Windows.Forms.Label maxGuessesLBL;
    }
}


namespace YonatanMankovich.BinarySearchTrick
{
    partial class QuestionForm
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
            this.leftBTN = new System.Windows.Forms.Button();
            this.correctBTN = new System.Windows.Forms.Button();
            this.rightBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numberLBL = new System.Windows.Forms.Label();
            this.boundsLBL = new System.Windows.Forms.Label();
            this.undoBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // leftBTN
            // 
            this.leftBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftBTN.Location = new System.Drawing.Point(9, 50);
            this.leftBTN.Name = "leftBTN";
            this.leftBTN.Size = new System.Drawing.Size(107, 38);
            this.leftBTN.TabIndex = 3;
            this.leftBTN.Text = "Smaller";
            this.leftBTN.UseVisualStyleBackColor = true;
            this.leftBTN.Click += new System.EventHandler(this.leftBTN_Click);
            // 
            // correctBTN
            // 
            this.correctBTN.Location = new System.Drawing.Point(75, 94);
            this.correctBTN.Name = "correctBTN";
            this.correctBTN.Size = new System.Drawing.Size(154, 23);
            this.correctBTN.TabIndex = 6;
            this.correctBTN.Text = "You guessed it!";
            this.correctBTN.UseVisualStyleBackColor = true;
            this.correctBTN.Click += new System.EventHandler(this.correctBTN_Click);
            // 
            // rightBTN
            // 
            this.rightBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightBTN.Location = new System.Drawing.Point(122, 50);
            this.rightBTN.Name = "rightBTN";
            this.rightBTN.Size = new System.Drawing.Size(107, 38);
            this.rightBTN.TabIndex = 4;
            this.rightBTN.Text = "Bigger";
            this.rightBTN.UseVisualStyleBackColor = true;
            this.rightBTN.Click += new System.EventHandler(this.rightBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Is this your number: ";
            // 
            // numberLBL
            // 
            this.numberLBL.AutoSize = true;
            this.numberLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberLBL.Location = new System.Drawing.Point(113, 26);
            this.numberLBL.Name = "numberLBL";
            this.numberLBL.Size = new System.Drawing.Size(109, 20);
            this.numberLBL.TabIndex = 2;
            this.numberLBL.Text = "##########";
            // 
            // boundsLBL
            // 
            this.boundsLBL.AutoSize = true;
            this.boundsLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic);
            this.boundsLBL.Location = new System.Drawing.Point(7, 9);
            this.boundsLBL.Name = "boundsLBL";
            this.boundsLBL.Size = new System.Drawing.Size(199, 13);
            this.boundsLBL.TabIndex = 0;
            this.boundsLBL.Text = "Your number is between #### and ####.";
            // 
            // undoBTN
            // 
            this.undoBTN.Location = new System.Drawing.Point(9, 94);
            this.undoBTN.Name = "undoBTN";
            this.undoBTN.Size = new System.Drawing.Size(60, 23);
            this.undoBTN.TabIndex = 5;
            this.undoBTN.Text = "Undo";
            this.undoBTN.UseVisualStyleBackColor = true;
            this.undoBTN.Click += new System.EventHandler(this.undoBTN_Click);
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 125);
            this.Controls.Add(this.undoBTN);
            this.Controls.Add(this.boundsLBL);
            this.Controls.Add(this.numberLBL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rightBTN);
            this.Controls.Add(this.correctBTN);
            this.Controls.Add(this.leftBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "QuestionForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Question Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button leftBTN;
        private System.Windows.Forms.Button correctBTN;
        private System.Windows.Forms.Button rightBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numberLBL;
        private System.Windows.Forms.Label boundsLBL;
        private System.Windows.Forms.Button undoBTN;
    }
}
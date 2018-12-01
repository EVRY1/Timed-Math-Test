namespace TimedMathTest
{
    partial class mathQuiz
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
            this.components = new System.ComponentModel.Container();
            this.userInteractable = new System.Windows.Forms.Button();
            this.divideSolution = new System.Windows.Forms.NumericUpDown();
            this.plusSolution = new System.Windows.Forms.NumericUpDown();
            this.minusSolution = new System.Windows.Forms.NumericUpDown();
            this.multiplySolution = new System.Windows.Forms.NumericUpDown();
            this.divideEqual = new System.Windows.Forms.Label();
            this.multiplyEqual = new System.Windows.Forms.Label();
            this.minusEqual = new System.Windows.Forms.Label();
            this.plusEqual = new System.Windows.Forms.Label();
            this.minusRightLabel = new System.Windows.Forms.Label();
            this.plusLeftLabel = new System.Windows.Forms.Label();
            this.plusOperator = new System.Windows.Forms.Label();
            this.plusRightLabel = new System.Windows.Forms.Label();
            this.minusLeftLabel = new System.Windows.Forms.Label();
            this.multiplyRightLabel = new System.Windows.Forms.Label();
            this.divideRightLabel = new System.Windows.Forms.Label();
            this.multiplyLeftLabel = new System.Windows.Forms.Label();
            this.divideLeftLabel = new System.Windows.Forms.Label();
            this.minusOperator = new System.Windows.Forms.Label();
            this.multiplyOperator = new System.Windows.Forms.Label();
            this.divideOperator = new System.Windows.Forms.Label();
            this.timerQuiz = new System.Windows.Forms.Timer(this.components);
            this.timeLeftText = new System.Windows.Forms.Label();
            this.timeBar = new System.Windows.Forms.ProgressBar();
            this.timeValue = new System.Windows.Forms.Label();
            this.timerBarSecond = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.divideSolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plusSolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minusSolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiplySolution)).BeginInit();
            this.SuspendLayout();
            // 
            // userInteractable
            // 
            this.userInteractable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userInteractable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInteractable.Location = new System.Drawing.Point(18, 402);
            this.userInteractable.Name = "userInteractable";
            this.userInteractable.Size = new System.Drawing.Size(770, 36);
            this.userInteractable.TabIndex = 0;
            this.userInteractable.Text = "Start Quiz";
            this.userInteractable.UseVisualStyleBackColor = true;
            this.userInteractable.Click += new System.EventHandler(this.userInteractable_Click);
            // 
            // divideSolution
            // 
            this.divideSolution.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.divideSolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideSolution.Location = new System.Drawing.Point(668, 358);
            this.divideSolution.Name = "divideSolution";
            this.divideSolution.Size = new System.Drawing.Size(120, 38);
            this.divideSolution.TabIndex = 2;
            // 
            // plusSolution
            // 
            this.plusSolution.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.plusSolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusSolution.Location = new System.Drawing.Point(668, 148);
            this.plusSolution.Name = "plusSolution";
            this.plusSolution.Size = new System.Drawing.Size(120, 38);
            this.plusSolution.TabIndex = 3;
            // 
            // minusSolution
            // 
            this.minusSolution.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.minusSolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusSolution.Location = new System.Drawing.Point(668, 218);
            this.minusSolution.Name = "minusSolution";
            this.minusSolution.Size = new System.Drawing.Size(120, 38);
            this.minusSolution.TabIndex = 4;
            // 
            // multiplySolution
            // 
            this.multiplySolution.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.multiplySolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplySolution.Location = new System.Drawing.Point(668, 288);
            this.multiplySolution.Name = "multiplySolution";
            this.multiplySolution.Size = new System.Drawing.Size(120, 38);
            this.multiplySolution.TabIndex = 5;
            // 
            // divideEqual
            // 
            this.divideEqual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.divideEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.divideEqual.Location = new System.Drawing.Point(624, 358);
            this.divideEqual.Name = "divideEqual";
            this.divideEqual.Size = new System.Drawing.Size(38, 38);
            this.divideEqual.TabIndex = 6;
            this.divideEqual.Text = "=";
            this.divideEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // multiplyEqual
            // 
            this.multiplyEqual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.multiplyEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.multiplyEqual.Location = new System.Drawing.Point(624, 288);
            this.multiplyEqual.Name = "multiplyEqual";
            this.multiplyEqual.Size = new System.Drawing.Size(38, 38);
            this.multiplyEqual.TabIndex = 7;
            this.multiplyEqual.Text = "=";
            this.multiplyEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusEqual
            // 
            this.minusEqual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.minusEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.minusEqual.Location = new System.Drawing.Point(624, 218);
            this.minusEqual.Name = "minusEqual";
            this.minusEqual.Size = new System.Drawing.Size(38, 38);
            this.minusEqual.TabIndex = 8;
            this.minusEqual.Text = "=";
            this.minusEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusEqual
            // 
            this.plusEqual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.plusEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.plusEqual.Location = new System.Drawing.Point(624, 148);
            this.plusEqual.Name = "plusEqual";
            this.plusEqual.Size = new System.Drawing.Size(38, 38);
            this.plusEqual.TabIndex = 9;
            this.plusEqual.Text = "=";
            this.plusEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusRightLabel
            // 
            this.minusRightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.minusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.minusRightLabel.Location = new System.Drawing.Point(358, 218);
            this.minusRightLabel.Name = "minusRightLabel";
            this.minusRightLabel.Size = new System.Drawing.Size(260, 38);
            this.minusRightLabel.TabIndex = 10;
            this.minusRightLabel.Text = "?";
            this.minusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusLeftLabel
            // 
            this.plusLeftLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.plusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.plusLeftLabel.Location = new System.Drawing.Point(12, 148);
            this.plusLeftLabel.Name = "plusLeftLabel";
            this.plusLeftLabel.Size = new System.Drawing.Size(290, 38);
            this.plusLeftLabel.TabIndex = 11;
            this.plusLeftLabel.Text = "?";
            this.plusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusOperator
            // 
            this.plusOperator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.plusOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.plusOperator.Location = new System.Drawing.Point(308, 148);
            this.plusOperator.Name = "plusOperator";
            this.plusOperator.Size = new System.Drawing.Size(38, 38);
            this.plusOperator.TabIndex = 12;
            this.plusOperator.Text = "+";
            this.plusOperator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusRightLabel
            // 
            this.plusRightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.plusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.plusRightLabel.Location = new System.Drawing.Point(352, 148);
            this.plusRightLabel.Name = "plusRightLabel";
            this.plusRightLabel.Size = new System.Drawing.Size(266, 38);
            this.plusRightLabel.TabIndex = 13;
            this.plusRightLabel.Text = "?";
            this.plusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusLeftLabel
            // 
            this.minusLeftLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.minusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.minusLeftLabel.Location = new System.Drawing.Point(12, 218);
            this.minusLeftLabel.Name = "minusLeftLabel";
            this.minusLeftLabel.Size = new System.Drawing.Size(290, 38);
            this.minusLeftLabel.TabIndex = 14;
            this.minusLeftLabel.Text = "?";
            this.minusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // multiplyRightLabel
            // 
            this.multiplyRightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.multiplyRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.multiplyRightLabel.Location = new System.Drawing.Point(358, 288);
            this.multiplyRightLabel.Name = "multiplyRightLabel";
            this.multiplyRightLabel.Size = new System.Drawing.Size(260, 38);
            this.multiplyRightLabel.TabIndex = 15;
            this.multiplyRightLabel.Text = "?";
            this.multiplyRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divideRightLabel
            // 
            this.divideRightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.divideRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.divideRightLabel.Location = new System.Drawing.Point(358, 358);
            this.divideRightLabel.Name = "divideRightLabel";
            this.divideRightLabel.Size = new System.Drawing.Size(260, 38);
            this.divideRightLabel.TabIndex = 16;
            this.divideRightLabel.Text = "?";
            this.divideRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // multiplyLeftLabel
            // 
            this.multiplyLeftLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.multiplyLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.multiplyLeftLabel.Location = new System.Drawing.Point(12, 288);
            this.multiplyLeftLabel.Name = "multiplyLeftLabel";
            this.multiplyLeftLabel.Size = new System.Drawing.Size(290, 38);
            this.multiplyLeftLabel.TabIndex = 17;
            this.multiplyLeftLabel.Text = "?";
            this.multiplyLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divideLeftLabel
            // 
            this.divideLeftLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.divideLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.divideLeftLabel.Location = new System.Drawing.Point(12, 358);
            this.divideLeftLabel.Name = "divideLeftLabel";
            this.divideLeftLabel.Size = new System.Drawing.Size(290, 38);
            this.divideLeftLabel.TabIndex = 18;
            this.divideLeftLabel.Text = "?";
            this.divideLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusOperator
            // 
            this.minusOperator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.minusOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.minusOperator.Location = new System.Drawing.Point(308, 218);
            this.minusOperator.Name = "minusOperator";
            this.minusOperator.Size = new System.Drawing.Size(38, 38);
            this.minusOperator.TabIndex = 19;
            this.minusOperator.Text = "-";
            this.minusOperator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // multiplyOperator
            // 
            this.multiplyOperator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.multiplyOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.multiplyOperator.Location = new System.Drawing.Point(308, 288);
            this.multiplyOperator.Name = "multiplyOperator";
            this.multiplyOperator.Size = new System.Drawing.Size(38, 38);
            this.multiplyOperator.TabIndex = 20;
            this.multiplyOperator.Text = "*";
            this.multiplyOperator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divideOperator
            // 
            this.divideOperator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.divideOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.divideOperator.Location = new System.Drawing.Point(308, 358);
            this.divideOperator.Name = "divideOperator";
            this.divideOperator.Size = new System.Drawing.Size(38, 38);
            this.divideOperator.TabIndex = 21;
            this.divideOperator.Text = "/";
            this.divideOperator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerQuiz
            // 
            this.timerQuiz.Interval = 1000;
            this.timerQuiz.Tick += new System.EventHandler(this.timerQuiz_Tick);
            // 
            // timeLeftText
            // 
            this.timeLeftText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeLeftText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.timeLeftText.Location = new System.Drawing.Point(12, 27);
            this.timeLeftText.Name = "timeLeftText";
            this.timeLeftText.Size = new System.Drawing.Size(136, 77);
            this.timeLeftText.TabIndex = 22;
            this.timeLeftText.Text = "Time Left:";
            this.timeLeftText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timeBar
            // 
            this.timeBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeBar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.timeBar.ForeColor = System.Drawing.Color.Cyan;
            this.timeBar.Location = new System.Drawing.Point(154, 27);
            this.timeBar.MarqueeAnimationSpeed = 1000;
            this.timeBar.Name = "timeBar";
            this.timeBar.Size = new System.Drawing.Size(634, 40);
            this.timeBar.Step = 1;
            this.timeBar.TabIndex = 1;
            // 
            // timeValue
            // 
            this.timeValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.timeValue.Location = new System.Drawing.Point(154, 70);
            this.timeValue.Name = "timeValue";
            this.timeValue.Size = new System.Drawing.Size(634, 34);
            this.timeValue.TabIndex = 23;
            this.timeValue.Text = "∞";
            this.timeValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerBarSecond
            // 
            this.timerBarSecond.Interval = 1;
            this.timerBarSecond.Tick += new System.EventHandler(this.timerBarSecond_Tick);
            // 
            // mathQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.timeValue);
            this.Controls.Add(this.timeLeftText);
            this.Controls.Add(this.divideOperator);
            this.Controls.Add(this.multiplyOperator);
            this.Controls.Add(this.minusOperator);
            this.Controls.Add(this.divideLeftLabel);
            this.Controls.Add(this.multiplyLeftLabel);
            this.Controls.Add(this.divideRightLabel);
            this.Controls.Add(this.multiplyRightLabel);
            this.Controls.Add(this.minusLeftLabel);
            this.Controls.Add(this.plusRightLabel);
            this.Controls.Add(this.plusOperator);
            this.Controls.Add(this.plusLeftLabel);
            this.Controls.Add(this.minusRightLabel);
            this.Controls.Add(this.plusEqual);
            this.Controls.Add(this.minusEqual);
            this.Controls.Add(this.multiplyEqual);
            this.Controls.Add(this.divideEqual);
            this.Controls.Add(this.multiplySolution);
            this.Controls.Add(this.minusSolution);
            this.Controls.Add(this.plusSolution);
            this.Controls.Add(this.divideSolution);
            this.Controls.Add(this.timeBar);
            this.Controls.Add(this.userInteractable);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "mathQuiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Math Quiz App";
            ((System.ComponentModel.ISupportInitialize)(this.divideSolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plusSolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minusSolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiplySolution)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button userInteractable;
        private System.Windows.Forms.NumericUpDown divideSolution;
        private System.Windows.Forms.NumericUpDown plusSolution;
        private System.Windows.Forms.NumericUpDown minusSolution;
        private System.Windows.Forms.NumericUpDown multiplySolution;
        private System.Windows.Forms.Label divideEqual;
        private System.Windows.Forms.Label multiplyEqual;
        private System.Windows.Forms.Label minusEqual;
        private System.Windows.Forms.Label plusEqual;
        private System.Windows.Forms.Label minusRightLabel;
        private System.Windows.Forms.Label plusLeftLabel;
        private System.Windows.Forms.Label plusOperator;
        private System.Windows.Forms.Label plusRightLabel;
        private System.Windows.Forms.Label minusLeftLabel;
        private System.Windows.Forms.Label multiplyRightLabel;
        private System.Windows.Forms.Label divideRightLabel;
        private System.Windows.Forms.Label multiplyLeftLabel;
        private System.Windows.Forms.Label divideLeftLabel;
        private System.Windows.Forms.Label minusOperator;
        private System.Windows.Forms.Label multiplyOperator;
        private System.Windows.Forms.Label divideOperator;
        private System.Windows.Forms.Timer timerQuiz;
        private System.Windows.Forms.Label timeLeftText;
        private System.Windows.Forms.ProgressBar timeBar;
        private System.Windows.Forms.Label timeValue;
        private System.Windows.Forms.Timer timerBarSecond;
    }
}


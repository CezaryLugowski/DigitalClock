namespace DigitalClock
{
    partial class DigitalClock
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.clockLabel = new System.Windows.Forms.Label();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.redButton = new System.Windows.Forms.Button();
            this.orangeButton = new System.Windows.Forms.Button();
            this.yellowButton = new System.Windows.Forms.Button();
            this.greanButton = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.Button();
            this.violetButton = new System.Windows.Forms.Button();
            this.pinkButton = new System.Windows.Forms.Button();
            this.styleButton1 = new System.Windows.Forms.Button();
            this.styleButton2 = new System.Windows.Forms.Button();
            this.styleButton3 = new System.Windows.Forms.Button();
            this.styleButton4 = new System.Windows.Forms.Button();
            this.styleButton5 = new System.Windows.Forms.Button();
            this.styleButton6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clockLabel
            // 
            this.clockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clockLabel.ForeColor = System.Drawing.Color.Red;
            this.clockLabel.Location = new System.Drawing.Point(12, 9);
            this.clockLabel.Name = "clockLabel";
            this.clockLabel.Size = new System.Drawing.Size(1262, 536);
            this.clockLabel.TabIndex = 0;
            this.clockLabel.Text = "Loading...";
            this.clockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clockTimer
            // 
            this.clockTimer.Interval = 1000;
            this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick);
            // 
            // redButton
            // 
            this.redButton.BackColor = System.Drawing.Color.Red;
            this.redButton.Location = new System.Drawing.Point(13, 519);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(27, 23);
            this.redButton.TabIndex = 1;
            this.redButton.UseVisualStyleBackColor = false;
            this.redButton.Click += new System.EventHandler(this.redButton_Click);
            // 
            // orangeButton
            // 
            this.orangeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.orangeButton.Location = new System.Drawing.Point(46, 519);
            this.orangeButton.Name = "orangeButton";
            this.orangeButton.Size = new System.Drawing.Size(27, 23);
            this.orangeButton.TabIndex = 2;
            this.orangeButton.UseVisualStyleBackColor = false;
            this.orangeButton.Click += new System.EventHandler(this.orangeButton_Click);
            // 
            // yellowButton
            // 
            this.yellowButton.BackColor = System.Drawing.Color.Yellow;
            this.yellowButton.Location = new System.Drawing.Point(79, 519);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(27, 23);
            this.yellowButton.TabIndex = 3;
            this.yellowButton.UseVisualStyleBackColor = false;
            this.yellowButton.Click += new System.EventHandler(this.yellowButton_Click);
            // 
            // greanButton
            // 
            this.greanButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.greanButton.Location = new System.Drawing.Point(112, 519);
            this.greanButton.Name = "greanButton";
            this.greanButton.Size = new System.Drawing.Size(27, 23);
            this.greanButton.TabIndex = 4;
            this.greanButton.UseVisualStyleBackColor = false;
            this.greanButton.Click += new System.EventHandler(this.greanButton_Click);
            // 
            // blueButton
            // 
            this.blueButton.BackColor = System.Drawing.Color.Blue;
            this.blueButton.Location = new System.Drawing.Point(145, 519);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(27, 23);
            this.blueButton.TabIndex = 5;
            this.blueButton.UseVisualStyleBackColor = false;
            this.blueButton.Click += new System.EventHandler(this.blueButton_Click);
            // 
            // violetButton
            // 
            this.violetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.violetButton.Location = new System.Drawing.Point(178, 519);
            this.violetButton.Name = "violetButton";
            this.violetButton.Size = new System.Drawing.Size(27, 23);
            this.violetButton.TabIndex = 6;
            this.violetButton.UseVisualStyleBackColor = false;
            this.violetButton.Click += new System.EventHandler(this.violetButton_Click);
            // 
            // pinkButton
            // 
            this.pinkButton.BackColor = System.Drawing.Color.HotPink;
            this.pinkButton.Location = new System.Drawing.Point(211, 519);
            this.pinkButton.Name = "pinkButton";
            this.pinkButton.Size = new System.Drawing.Size(27, 23);
            this.pinkButton.TabIndex = 7;
            this.pinkButton.UseVisualStyleBackColor = false;
            this.pinkButton.Click += new System.EventHandler(this.pinkButton_Click);
            // 
            // styleButton1
            // 
            this.styleButton1.BackColor = System.Drawing.Color.White;
            this.styleButton1.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.styleButton1.Location = new System.Drawing.Point(370, 518);
            this.styleButton1.Name = "styleButton1";
            this.styleButton1.Size = new System.Drawing.Size(75, 23);
            this.styleButton1.TabIndex = 8;
            this.styleButton1.Text = "Style 1";
            this.styleButton1.UseVisualStyleBackColor = false;
            this.styleButton1.Click += new System.EventHandler(this.styleButton1_Click);
            // 
            // styleButton2
            // 
            this.styleButton2.BackColor = System.Drawing.Color.White;
            this.styleButton2.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.styleButton2.Location = new System.Drawing.Point(451, 518);
            this.styleButton2.Name = "styleButton2";
            this.styleButton2.Size = new System.Drawing.Size(75, 23);
            this.styleButton2.TabIndex = 9;
            this.styleButton2.Text = "Style 2";
            this.styleButton2.UseVisualStyleBackColor = false;
            this.styleButton2.Click += new System.EventHandler(this.styleButton2_Click);
            // 
            // styleButton3
            // 
            this.styleButton3.BackColor = System.Drawing.Color.White;
            this.styleButton3.Font = new System.Drawing.Font("Sitka Banner", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.styleButton3.Location = new System.Drawing.Point(532, 518);
            this.styleButton3.Name = "styleButton3";
            this.styleButton3.Size = new System.Drawing.Size(75, 23);
            this.styleButton3.TabIndex = 10;
            this.styleButton3.Text = "Style 3";
            this.styleButton3.UseVisualStyleBackColor = false;
            this.styleButton3.Click += new System.EventHandler(this.styleButton3_Click);
            // 
            // styleButton4
            // 
            this.styleButton4.BackColor = System.Drawing.Color.White;
            this.styleButton4.Font = new System.Drawing.Font("Algerian", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.styleButton4.Location = new System.Drawing.Point(613, 518);
            this.styleButton4.Name = "styleButton4";
            this.styleButton4.Size = new System.Drawing.Size(75, 23);
            this.styleButton4.TabIndex = 11;
            this.styleButton4.Text = "Style 4";
            this.styleButton4.UseVisualStyleBackColor = false;
            this.styleButton4.Click += new System.EventHandler(this.styleButton4_Click);
            // 
            // styleButton5
            // 
            this.styleButton5.BackColor = System.Drawing.Color.White;
            this.styleButton5.Font = new System.Drawing.Font("Blackadder ITC", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.styleButton5.Location = new System.Drawing.Point(694, 518);
            this.styleButton5.Name = "styleButton5";
            this.styleButton5.Size = new System.Drawing.Size(75, 23);
            this.styleButton5.TabIndex = 12;
            this.styleButton5.Text = "Style 5";
            this.styleButton5.UseVisualStyleBackColor = false;
            this.styleButton5.Click += new System.EventHandler(this.styleButton5_Click);
            // 
            // styleButton6
            // 
            this.styleButton6.BackColor = System.Drawing.Color.White;
            this.styleButton6.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.styleButton6.Location = new System.Drawing.Point(775, 518);
            this.styleButton6.Name = "styleButton6";
            this.styleButton6.Size = new System.Drawing.Size(75, 23);
            this.styleButton6.TabIndex = 13;
            this.styleButton6.Text = "Style 6";
            this.styleButton6.UseVisualStyleBackColor = false;
            this.styleButton6.Click += new System.EventHandler(this.styleButton6_Click);
            // 
            // DigitalClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1286, 554);
            this.Controls.Add(this.styleButton6);
            this.Controls.Add(this.styleButton5);
            this.Controls.Add(this.styleButton4);
            this.Controls.Add(this.styleButton3);
            this.Controls.Add(this.styleButton2);
            this.Controls.Add(this.styleButton1);
            this.Controls.Add(this.pinkButton);
            this.Controls.Add(this.violetButton);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.greanButton);
            this.Controls.Add(this.yellowButton);
            this.Controls.Add(this.orangeButton);
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.clockLabel);
            this.Name = "DigitalClock";
            this.Text = "Digital Clock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer clockTimer;
        private System.Windows.Forms.Label clockLabel;
        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button orangeButton;
        private System.Windows.Forms.Button yellowButton;
        private System.Windows.Forms.Button greanButton;
        private System.Windows.Forms.Button blueButton;
        private System.Windows.Forms.Button violetButton;
        private System.Windows.Forms.Button pinkButton;
        private System.Windows.Forms.Button styleButton1;
        private System.Windows.Forms.Button styleButton2;
        private System.Windows.Forms.Button styleButton3;
        private System.Windows.Forms.Button styleButton4;
        private System.Windows.Forms.Button styleButton5;
        private System.Windows.Forms.Button styleButton6;
    }
}


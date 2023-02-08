using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalClock
{
    public partial class DigitalClock : Form
    {
        public DigitalClock()
        {
            InitializeComponent();
            redButton.FlatStyle = FlatStyle.Flat;
            orangeButton.FlatStyle = FlatStyle.Flat;
            yellowButton.FlatStyle = FlatStyle.Flat;
            greanButton.FlatStyle = FlatStyle.Flat;
            blueButton.FlatStyle = FlatStyle.Flat;
            violetButton.FlatStyle = FlatStyle.Flat;
            pinkButton.FlatStyle = FlatStyle.Flat;
            styleButton1.FlatStyle = FlatStyle.Flat;
            styleButton2.FlatStyle = FlatStyle.Flat;
            styleButton3.FlatStyle = FlatStyle.Flat;
            styleButton4.FlatStyle = FlatStyle.Flat;
            styleButton5.FlatStyle = FlatStyle.Flat;
            styleButton6.FlatStyle = FlatStyle.Flat;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clockTimer.Start();
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            clockLabel.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void pinkButton_Click(object sender, EventArgs e)
        {
            clockLabel.ForeColor= Color.HotPink;
        }

        private void violetButton_Click(object sender, EventArgs e)
        {
            clockLabel.ForeColor = Color.Violet;
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            clockLabel.ForeColor = Color.Blue;
        }

        private void greanButton_Click(object sender, EventArgs e)
        {
            clockLabel.ForeColor = Color.Green;
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            clockLabel.ForeColor = Color.Yellow;
        }

        private void orangeButton_Click(object sender, EventArgs e)
        {
            clockLabel.ForeColor = Color.Orange;
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            clockLabel.ForeColor = Color.Red;
        }

        private void styleButton1_Click(object sender, EventArgs e)
        {
            clockLabel.Font = new Font("Impact", 90, FontStyle.Regular);
        }

        private void styleButton2_Click(object sender, EventArgs e)
        {
            clockLabel.Font = new Font("Consolas", 90, FontStyle.Regular);
        }

        private void styleButton3_Click(object sender, EventArgs e)
        {
            clockLabel.Font = new Font("Sitka Banner", 90, FontStyle.Regular);
        }

        private void styleButton4_Click(object sender, EventArgs e)
        {
            clockLabel.Font = new Font("Algerian", 90, FontStyle.Regular);
        }

        private void styleButton5_Click(object sender, EventArgs e)
        {
            clockLabel.Font = new Font("Blackadder ITC", 90, FontStyle.Regular);
        }

        private void styleButton6_Click(object sender, EventArgs e)
        {
            clockLabel.Font = new Font("Franklin Gothic Medium Cond", 90, FontStyle.Regular);
        }
    }
}

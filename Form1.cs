using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emblem
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
            pictureBox2.Image = new Bitmap(pictureBox2.Width, pictureBox2.Height);
        }
        int count = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            int rand = r.Next(5, 434);
            int rand2 = r.Next(5, 434);
            int rand3 = r.Next(5, 234);
            CEmblem emblem = new CEmblem(rand, rand2, rand3, "Emblem" + count, Color.Black);
            emblem.Show();
            emblem.Draw(pictureBox2);
            comboBox1.Items.Add(emblem);  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null) {
                CEmblem emblem = (CEmblem)comboBox1.SelectedItem;
                emblem.Hide();
                emblem.Draw(pictureBox2);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                CEmblem emblem = (CEmblem)comboBox1.SelectedItem;
                emblem.Show();
                emblem.Draw(pictureBox2);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                CEmblem emblem = (CEmblem)comboBox1.SelectedItem;
                if (emblem.currentColor == Color.White) { return; }
                emblem.Hide();
                emblem.Draw(pictureBox2);
                emblem.MoveUp();
                emblem.Show();
                emblem.Draw(pictureBox2);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                CEmblem emblem = (CEmblem)comboBox1.SelectedItem;
                if (emblem.currentColor == Color.White) { return; }
                emblem.Hide();
                emblem.Draw(pictureBox2);
                emblem.MoveLeft();
                emblem.Show();
                emblem.Draw(pictureBox2);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                CEmblem emblem = (CEmblem)comboBox1.SelectedItem;
                if (emblem.currentColor == Color.White) { return; }
                emblem.Hide();
                emblem.Draw(pictureBox2);
                emblem.MoveRight();
                emblem.Show();
                emblem.Draw(pictureBox2);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                CEmblem emblem = (CEmblem)comboBox1.SelectedItem;
                if (emblem.currentColor == Color.White) { return; }
                emblem.Hide();
                emblem.Draw(pictureBox2);
                emblem.MoveDown();
                emblem.Show();
                emblem.Draw(pictureBox2);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                CEmblem emblem = (CEmblem)comboBox1.SelectedItem;
                if (emblem.currentColor == Color.White) { return; }
                emblem.Hide();
                emblem.Draw(pictureBox2);
                emblem.ReduceSize();
                emblem.Show();
                emblem.Draw(pictureBox2);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                CEmblem emblem = (CEmblem)comboBox1.SelectedItem;
                if (emblem.currentColor == Color.White) { return; }
                emblem.Hide();
                emblem.Draw(pictureBox2);
                emblem.IncreaseSize();
                emblem.Show();
                emblem.Draw(pictureBox2);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            emblem.Draw(pictureBox2,emblem.angle);
            comboBox1.Items.Add(emblem);
            comboBox1.SelectedItem = emblem;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null) {
                CEmblem emblem = (CEmblem)comboBox1.SelectedItem;
                emblem.Hide();
                emblem.Draw(pictureBox2, emblem.angle);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                CEmblem emblem = (CEmblem)comboBox1.SelectedItem;
                emblem.Show();
                emblem.Draw(pictureBox2, emblem.angle);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                CEmblem emblem = (CEmblem)comboBox1.SelectedItem;
                if (emblem.currentColor == Color.White) { return; }
                emblem.Hide();
                emblem.Draw(pictureBox2, emblem.angle);
                emblem.MoveUp();
                emblem.Show();
                emblem.Draw(pictureBox2, emblem.angle);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                CEmblem emblem = (CEmblem)comboBox1.SelectedItem;
                if (emblem.currentColor == Color.White) { return; }
                emblem.Hide();
                emblem.Draw(pictureBox2, emblem.angle);
                emblem.MoveLeft();
                emblem.Show();
                emblem.Draw(pictureBox2, emblem.angle);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                CEmblem emblem = (CEmblem)comboBox1.SelectedItem;
                if (emblem.currentColor == Color.White) { return; }
                emblem.Hide();
                emblem.Draw(pictureBox2, emblem.angle);
                emblem.MoveRight();
                emblem.Show();
                emblem.Draw(pictureBox2, emblem.angle);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                CEmblem emblem = (CEmblem)comboBox1.SelectedItem;
                if (emblem.currentColor == Color.White) { return; }
                emblem.Hide();
                emblem.Draw(pictureBox2, emblem.angle);
                emblem.MoveDown();
                emblem.Show();
                emblem.Draw(pictureBox2, emblem.angle);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                
                CEmblem emblem = (CEmblem)comboBox1.SelectedItem;
                if (emblem.CheckIfZero())
                {
                    button5.Enabled = false;
                }
                else
                {
                    button5.Enabled = true;
                }
                    if (emblem.currentColor == Color.White) { return; }
                    emblem.Hide();
                    emblem.Draw(pictureBox2, emblem.angle);
                    emblem.ReduceSize();
                    emblem.Show();
                    emblem.Draw(pictureBox2, emblem.angle);
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                CEmblem emblem = (CEmblem)comboBox1.SelectedItem;
                if (emblem.CheckIfZero())
                {
                    button5.Enabled = false;
                }
                else
                {
                    button5.Enabled = true;
                }
                if (emblem.currentColor == Color.White) { return; }
                emblem.Hide();
                emblem.Draw(pictureBox2, emblem.angle);
                emblem.IncreaseSize();
                emblem.Show();
                emblem.Draw(pictureBox2, emblem.angle);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                CEmblem emblem = (CEmblem)comboBox1.SelectedItem;
                if (emblem.currentColor == Color.White) { return; }
                emblem.Hide();
                emblem.Draw(pictureBox2, emblem.angle);
                emblem.SetLocation(emblem.GetX(), pictureBox2.Height - emblem.GetSize());
                emblem.Show();
                emblem.Draw(pictureBox2, emblem.angle);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                CEmblem emblem = (CEmblem)comboBox1.SelectedItem;
                if (emblem.currentColor == Color.White) { return; }
                emblem.Hide();
                emblem.Draw(pictureBox2,emblem.angle);
                emblem.SetLocation(emblem.GetX(), 0);
                emblem.Show();
                emblem.Draw(pictureBox2, emblem.angle);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                CEmblem emblem = (CEmblem)comboBox1.SelectedItem;
                if (emblem.currentColor == Color.White) { return; }
                emblem.Hide();
                emblem.Draw(pictureBox2, emblem.angle);
                emblem.SetLocation(0, emblem.GetY());
                emblem.Show();
                emblem.Draw(pictureBox2, emblem.angle);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                CEmblem emblem = (CEmblem)comboBox1.SelectedItem;
                if (emblem.currentColor == Color.White) { return; }
                emblem.Hide();
                emblem.Draw(pictureBox2, emblem.angle);
                emblem.SetLocation(pictureBox2.Width-emblem.GetSize(), emblem.GetY());
                emblem.Show();
                emblem.Draw(pictureBox2, emblem.angle);
            }
        }

       void button14_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                CEmblem emblem = (CEmblem)comboBox1.SelectedItem;
                if (emblem.currentColor == Color.White) { return; }
                emblem.Hide();
                emblem.Draw(pictureBox2, emblem.angle);
                emblem.angle += 10;
                emblem.Show();
                emblem.Draw(pictureBox2, emblem.angle);
            }


        }
      
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            int a = 0; 
            if (checkBox1.Checked == true)
            {
                if (comboBox1.SelectedItem != null)
                {

                    CEmblem emblem = (CEmblem)comboBox1.SelectedItem;
                    emblem.animate = true;
                    
                    while (true)
                    {

                        emblem.Hide();
                        emblem.Draw(pictureBox2, emblem.angle);
                        emblem.angle += 5;
                        emblem.Show();
                        emblem.Draw(pictureBox2, emblem.angle);


                        if (emblem.angle ==180)
                        {
                            emblem.animate = false;
                            emblem.Hide();
                            emblem.Draw(pictureBox2, emblem.angle);
                            emblem.angle = 0;
                            emblem.Show();
                            emblem.Draw(pictureBox2, emblem.angle);
                            
                            break;
                        }
                        Thread.Sleep(50);
                    }
                }
            }           
        }
    }
}

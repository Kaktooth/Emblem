using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emblem
{
    class CEmblem
    {   Color color { get; set; }
        public Color currentColor { get; set; }
        string name { get; set; }
        int Size { get; set; }
        public bool animate = false;
        int X { get; set; }
        int Y { get; set; }
        public int angle { get; set; }
        Pen p = new Pen(Color.Red,1f);
        public CEmblem() { }
        public CEmblem(int x, int y, int size, string name, Color color)
        {
            this.X = x;
            this.Y = y;
            this.Size = size;
            this.name = name;
            this.color = color;
            currentColor = color;
        }
        public CEmblem(int x, int y, int size, Color color)
        {
            this.X = x;
            this.Y = y;
            this.Size = size;
            this.color = color;
            currentColor = color;
        }
        public void Hide()
        {
            currentColor = Color.White;
        }
        public void Show()
        {
            currentColor = color;
        }
        public void MoveRight()
        {
            X++;
        }
        public void MoveLeft()
        {
            X--;
        }
        public void MoveUp()
        {
            Y--;
        }
        public void MoveDown()
        {
            Y++;
        }
        public int GetX()
        {
            return X;
        }
        public int GetY()
        {
            return Y;
        }
        public int GetSize()
        {
            return Size;
        }
        public void SetLocation(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public bool CheckIfZero()
        {
            if (Size <= 0)
            {
                return true;
            }
            else { return false; }
        }
        public void IncreaseSize()
        {
            Size++;
        }
        public void ReduceSize()
        {
            Size--;
        }
        public override string ToString()
        {
            return name;
        }
        public void Draw2(PictureBox pictureBox)
        {
            p.Color = currentColor;
            using (var g = Graphics.FromImage(pictureBox.Image))
            {
                g.DrawEllipse(p, X, Y, Size, Size);
                double d = Size;
                float side = (float)(d * (Math.Sqrt(2f) / 2f));
                g.DrawRectangle(p, X+ Size/7, Y+ Size/7, side, side);
                Rectangle r = new Rectangle(X + Size / 7, Y + Size / 7, (int)side, (int)side);

                RotateRectangle(g, r, 45, p);
       
                pictureBox.Refresh();
            }
            
        }
        public void RotateRectangle(Graphics g, Rectangle r, float angle, Pen p)
        {
            using (Matrix m = new Matrix())
            {
                m.RotateAt(angle, new PointF(r.Left + (r.Width / 2),
                                          r.Top + (r.Height / 2)));
                g.Transform = m;
                g.DrawRectangle(p, r);
                g.ResetTransform();
            }
        }
        public void Draw(PictureBox pictureBox, float angle)
        {
            p.Color = currentColor;
            using (var g = Graphics.FromImage(pictureBox.Image))
            {
                g.DrawEllipse(p, X, Y, Size, Size);
                double d = Size;
                float side = (float)(d * (Math.Sqrt(2f) / 2f));
               
                Rectangle r = new Rectangle(X + Size / 7, Y + Size / 7, (int)side, (int)side);
                Rectangle r2 = new Rectangle(X + Size / 7, Y + Size / 7, (int)side, (int)side);
                if (animate)
                {
                    using (Matrix m = new Matrix())
                    {
                        m.RotateAt(angle, new PointF(r.Left + (r.Width / 2),
                                                  r.Top + (r.Height / 2)));

                        g.Transform = m;
                        g.DrawRectangle(p, r);
                        g.ResetTransform();
                        m.RotateAt(45+angle, new PointF(r2.Left + (r2.Width / 2),
                                                r2.Top + (r2.Height / 2)));

                        g.Transform = m;
                        g.DrawRectangle(p, r);
                        g.ResetTransform();
                    }
                }
                else
                {
                    using (Matrix m = new Matrix())
                    {
                        m.RotateAt(angle, new PointF(r.Left + (r.Width / 2),
                                                  r.Top + (r.Height / 2)));

                        g.Transform = m;
                        g.DrawRectangle(p, r);

                        m.RotateAt(45, new PointF(r2.Left + (r2.Width / 2),
                                                r2.Top + (r2.Height / 2)));

                        g.Transform = m;
                        g.DrawRectangle(p, r);
                        g.ResetTransform();
                    }
                }
                pictureBox.Refresh();
            }
        }
    }
}

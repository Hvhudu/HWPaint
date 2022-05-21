using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HWPaint
{
    public partial class Form1 : Form
    {
        SolidBrush brush;
        Graphics graphics;
        bool isDraw = false;
        public Form1()
        {
            InitializeComponent();
            this.MinimumSize = this.MaximumSize = this.Size;
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            brush = new SolidBrush(pan_Col.BackColor);
            graphics = panel1.CreateGraphics();
        }

        private void pan_Col_DoubleClick(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog()==DialogResult.OK)
            {
                pan_Col.BackColor = colorDialog1.Color;
                brush.Color = colorDialog1.Color;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isDraw = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isDraw = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(isDraw == true)
            {
                graphics.FillEllipse(brush, e.X, e.Y, trackBar1.Value, trackBar1.Value);
            }
        }

        private void Erase_Click(object sender, EventArgs e)
        {
            brush.Color = Color.White;
        }

        private void Pen_Click(object sender, EventArgs e)
        {
            brush.Color = pan_Col.BackColor;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            panel1.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pen pn = new Pen(pan_Col.BackColor, trackBar1.Value);
            int X = Convert.ToInt32(X_cord.Text);
            int Y = Convert.ToInt32(Y_cord.Text);
            int H = Convert.ToInt32(Height.Text);
            int W = Convert.ToInt32(Widtht.Text);

            Rectangle rect = new Rectangle(X, Y, W, H);
            graphics.DrawRectangle(pn, rect);
        }

        private void Fill_Click(object sender, EventArgs e)
        {
            //Brush br = new Brush();
            
            int X = Convert.ToInt32(X_cord.Text);
            int Y = Convert.ToInt32(Y_cord.Text);
            int H = Convert.ToInt32(Height.Text);
            int W = Convert.ToInt32(Widtht.Text);

            Rectangle rect = new Rectangle(X, Y, W, H);
            graphics.FillRectangle(Brushes.Red,rect);
        }
    }
}

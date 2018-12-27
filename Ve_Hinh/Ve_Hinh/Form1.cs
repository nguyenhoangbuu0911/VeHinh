using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ve_Hinh
{
    public partial class Form1 : Form
    {
        clsDiem D1 = new clsDiem();
        clsDiem D2 = new clsDiem();
        bool isDrawing = false;

        public Form1()
        {
            InitializeComponent();
        }

        

        private void pdDraw_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            D1.x = e.X;
            D1.y = e.Y;
        }

        private void pdDraw_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing == true)
            {
                System.Drawing.Graphics g = pdDraw.CreateGraphics();
                g.DrawLine(new Pen(Color.White), D1.x, D1.y, D2.x, D2.y);
                D2.x = e.X;
                D2.y = e.Y;

                g.DrawLine(new Pen(Color.Black), D1.x, D1.y, D2.x, D2.y);
            }
        }

        private void pdDraw_MouseUp(object sender, MouseEventArgs e)
        {
            D2.x = e.X;
            D2.y = e.Y;
            System.Drawing.Graphics g = pdDraw.CreateGraphics();
            g.DrawLine(new Pen(Color.Black), D1.x, D1.y, D2.x, D2.y);
            isDrawing = false;
        }
    }
}

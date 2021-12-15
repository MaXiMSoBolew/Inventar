using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentDragDrop;

namespace Inventar
{
    class Cell : PictureBox
    {
       static Image buf;
        public int cnt { get;  set; }
        Graphics graph;
        public Cell()
        {
            cnt = 0;
            Width = 100;
            Height = 100;
            graph = CreateGraphics();
            SizeMode = PictureBoxSizeMode.StretchImage;
            Image = Properties.Resources.empty;
            AllowDrop = true;
            DragDrop  += Cell_DragDrop;
            DragEnter += Cell_DragEnter;
            DragLeave += Cell_DragLeave;
            MouseMove += Cell_MouseMove;
            MouseDown += cell1_MouseDown;
        }
        private void cell1_MouseDown(object sender, MouseEventArgs e)
        {
            if (cnt != 0)
            { buf = this.Image;
                if (e.Button == MouseButtons.Left)
                {
                    this.InitializeDragAndDrop()
                        .Copy()
                        .Immediately()
                        .WithData(Properties.Resources.apple)
                        .WithPreview().BehindCursor();
                    Del();
                    
                } }
          
               
        }
        private void Cell_DragLeave(object sender, EventArgs e)
        {
            if (cnt <= 0)
                Image = Properties.Resources.empty;
            else
                ShowText(buf);
          
            
        }
        private void Cell_DragDrop(object sender, DragEventArgs e)
        {
            // int  x = Convert.ToInt32((string) e.Data.GetData(DataFormats.Text));
            if()
            if(cnt<=0)
           Image = buf;
            Add();
            ShowText(Image);
          


        }
        private void Cell_DragEnter(object sender, DragEventArgs e)
        {
           e.Effect = DragDropEffects.Copy;
            //Image = Properties.Resources._1;
        }

        private void Cell_MouseMove (object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && cnt>0)
            {
               this.InitializeDragAndDrop()
                    .Copy()
                    .Immediately()
                    .WithData(this.Image)
                    .WithPreview().BehindCursor();
                Del();
                ShowText(this.Image);
                buf = this.Image;
            }
        }

        public Cell(int w, int h)
        {
            cnt = 0;
            Width = w;
            Height = h;
            graph = CreateGraphics();
            SizeMode = PictureBoxSizeMode.StretchImage;
            //Image = Properties.Resources;
           
        }
        public void ShowText(Image image)
        {
            
            graph.Clear(Color.White);
            if (cnt == 0)
                graph.DrawImage(Properties.Resources.empty, 0, 0);
            else
            {
                Bitmap bitmap = new Bitmap(image, 100, 100);
                graph.DrawImage(bitmap, 0, 0);
                graph.DrawString(cnt.ToString(), new Font("Arial", 15), new SolidBrush(Color.Black), 80, 80);
            }

        }

        public void Add()
        {
            cnt++;

        }

        public void Del()
        {
            if (cnt > 0)
                cnt--;
        }
    }
}

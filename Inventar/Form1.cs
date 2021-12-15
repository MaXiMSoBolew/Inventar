using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentDragDrop;

namespace Inventar
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cell1.Image = Properties.Resources.ananas;
            cell1.AllowDrop = true;
            cell1.cnt = 100;
            cell2.Image = Properties.Resources.apple;
            cell2.AllowDrop = true;
            cell2.cnt = 100;
        }

      

        //private void cell1_MouseDown(object sender, MouseEventArgs e)
        //{
        //    if (e.Button== MouseButtons.Left)
        //    {
        //        cell1.InitializeDragAndDrop()
        //            .Copy()
        //            .Immediately()
        //            .WithData(Properties.Resources.apple)
        //            .WithPreview().BehindCursor();
        //    }
        //}

        private void cell1_Click(object sender, EventArgs e)
        {

        }

        private void cell1_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}

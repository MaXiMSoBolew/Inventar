using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventar
{
    class Inv : Panel
    {
        List<Cell> cells;
        int _count = 0;
        int x { get; set; }
        public Inv()
        {
            Count = 3;
        }
/*Количество!*/
        public int Count
        {
            get { return _count; }
            set
            {
                Controls.Clear();
                _count = value;
                Height = _count * 100 + _count;
                Width = _count * 100 + _count;
                cells = new List<Cell>();
                int I = 0;
                for (int j = 0; j < _count; j++)
                    for (int i = 0; i < _count; i++)
                    {
                        cells.Add(new Cell());
                        cells[I].Top = i * 101;
                        cells[I].Left = j * 101;
                        Controls.Add(cells[I]);
                        I++;
                    }
            }
        }

    }
}
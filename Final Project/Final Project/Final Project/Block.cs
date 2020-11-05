using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Block : UserControl
    {
        public new string Name { get; }
        public int row { get; set; }
        public int col { get; set; }

        public Block(int row, int col)
        {
            InitializeComponent();
            this.Name = row.ToString() + ", " + col.ToString();
            this.row = row;
            this.col = col;
        }

        public int blockColor
        {
            set
            {
                this.BackColor = Color.FromArgb(value);
            }
        }
    }

}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Project_GameOfLife_lib;

namespace Project_GameOfLife
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Class1 obj = new Class1();
            Popcorn popcorn = obj.giveMePopcorn(0, "salty");
            MessageBox.Show(popcorn.tellMe());
        }
    }
}

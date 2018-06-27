using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            plot();
        }

        public void plot()
        {



            int x = 10, y = 0, incr, totalIncr=0;

            for(int i=1; i<= 8; i++)
            {
                incr = (i % 4 != 0) ? 0 : 1;
                if (i % 4 == 0)
                {
                    totalIncr++;
                }
                x = 10 + totalIncr*20; 
                y = (10-(i%4))*30;
                Label lbl = new Label();
                lbl.Location = new Point(x,y);
                lbl.Text = i.ToString();
                this.Controls.Add(lbl);
                lbl = null;
            }
        }
    }
}

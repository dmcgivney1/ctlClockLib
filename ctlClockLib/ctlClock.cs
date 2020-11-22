using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ctlClockLib
{
    public partial class ctlClock : UserControl
    {

        private Color colFColor;
        private Color colBColor;

        public Color ClockBlockColor
        {
            get { return colBColor; }

            set
            {
                colBColor = value;
                lblDisplay.BackColor = colBColor;
            }
        }



        public Color ClockForClor
        {
            get { return colFColor; }

            set
            {
                colFColor = value;
                lblDisplay.ForeColor = colFColor;
            }

        }
        public
    ctlClock()
        {
            InitializeComponent();
        }



        protected virtual void timer1_Tick(object sender, EventArgs e)
        {
            // Causes the label to display the current time.
            lblDisplay.Text = DateTime.Now.ToLongTimeString();

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class WebForm : Form
    {
        public WebForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = "https://www.google.com/search?q=" + compountBox.Text + "+antoine+coefficients";
            System.Diagnostics.Process.Start(url);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string url = "http://www.eng.auburn.edu/~drmills/mans486/Diffusion%20Tube/Antoine_coefficient_table.PDF";
            System.Diagnostics.Process.Start(url);
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            string url = "http://i-systems.dechema.de/detherm/mixture.php?";
            System.Diagnostics.Process.Start(url);
        }
    }
}

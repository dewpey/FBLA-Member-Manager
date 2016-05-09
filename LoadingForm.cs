using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Inforum
{

    public partial class LoadingForm : Form
    {

        public LoadingForm()
        {
            //Initialize the form
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Close the loading form
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Close the loading form
            this.Close();
        }
    }
}

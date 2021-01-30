using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace Artificial_intelligence.Forms
{
    public partial class FrmAforge : Form
    {
        public FrmAforge()
        {
            InitializeComponent();
        }

        FilterInfoCollection fico;
        VideoCaptureDevice vcd;


        private void FrmAforge_Load(object sender, EventArgs e)
        {
            fico = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo f in fico)
            {
                comboBox1.Items.Add(f.Name);
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_2
{
    public partial class Activity2 : Form
    {
        public Activity2()
        {
            InitializeComponent();
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            double weight = Convert.ToDouble(InputWeightTB.Text);

            weight /= 4.2;

            OutputWeightTB.Text = weight.ToString();

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

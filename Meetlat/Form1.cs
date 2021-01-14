using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meetlat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcLength_Click(object sender, EventArgs e)
        {
            double length = Convert.ToDouble(txtInput.Text);
            Meetlat meet = new Meetlat(length);
            lblM.Text = $"{meet.LengteInM}";
            lblCm.Text = $"{meet.LengteInCm}";
            lblKm.Text = $"{meet.LengteInKm}";
            lblFeet.Text = $"{meet.LengteInVoet}";
        }
    }
}

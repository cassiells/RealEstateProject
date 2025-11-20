using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstateProject
{
    public partial class Tenants : Form
    {
        public Tenants()
        {
            InitializeComponent();
        }

        private void Tenants_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}

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
    public partial class Form2 : Form
    {
        dashboard dashboard;
        Agents agents;
        Tenants tenants;
        Landlords landlords;
        Accounts accounts;
        Properties properties;
        Leases leases;
        Payments payments;
        MaintenanceRequest maintenancerequest;
        Logout logout;




        private readonly object TitleLabel;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            ButtonOff();
            btndashboard.FillColor = Color.LightSteelBlue;
            btndashboard.FillColor2 = Color.DarkBlue;

            if (dashboard == null)
            {
                dashboard = new dashboard();
                dashboard.FormClosed += Dashboard_FormClosed;
                dashboard.MdiParent = this;
                dashboard.Show();

            }
            else
            {
                dashboard.Activate();
            }
        }


        private void Dashboard_FormClosed(object? sender, FormClosedEventArgs e)
        {
            dashboard = null;
        }

        private void btnagents_Click(object sender, EventArgs e)
        {
            ButtonOff();
            btnagents.FillColor = Color.LightSteelBlue;
            btnagents.FillColor2 = Color.DarkBlue;

        }

        private void btntenants_Click(object sender, EventArgs e)
        {
            ButtonOff();
            btntenants.FillColor = Color.LightSteelBlue;
            btntenants.FillColor2 = Color.DarkBlue;
        }

        private void btnlandlords_Click(object sender, EventArgs e)
        {
            ButtonOff();
            btnlandlords.FillColor = Color.LightSteelBlue;
            btnlandlords.FillColor2 = Color.DarkBlue;
        }

        private void btnaccounts_Click(object sender, EventArgs e)
        {
            ButtonOff();
            btnaccounts.FillColor = Color.LightSteelBlue;
            btnaccounts.FillColor2 = Color.DarkBlue;
        }

        private void btnproperties_Click(object sender, EventArgs e)
        {
            ButtonOff();
            btnproperties.FillColor = Color.LightSteelBlue;
            btnproperties.FillColor2 = Color.DarkBlue;
        }

        private void btnleases_Click(object sender, EventArgs e)
        {
            ButtonOff();
            btnleases.FillColor = Color.LightSteelBlue;
            btnleases.FillColor2 = Color.DarkBlue;
        }

        private void btnpayments_Click(object sender, EventArgs e)
        {
            ButtonOff();
            btnpayments.FillColor = Color.LightSteelBlue;
            btnpayments.FillColor2 = Color.DarkBlue;

        }

        private void btnmaintenancerequest_Click(object sender, EventArgs e)
        {
            ButtonOff();
            btnmaintenancerequest.FillColor = Color.LightSteelBlue;
            btnmaintenancerequest.FillColor2 = Color.DarkBlue;
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            ButtonOff();
            btnlogout.FillColor = Color.LightSteelBlue;
            btnlogout.FillColor2 = Color.DarkBlue;
        }

        private void ButtonOff()
        {
            btndashboard.FillColor = Color.Transparent;
            btndashboard.FillColor2 = Color.Transparent;

            btnagents.FillColor = Color.Transparent;
            btnagents.FillColor2 = Color.Transparent;

            btntenants.FillColor = Color.Transparent;
            btntenants.FillColor2 = Color.Transparent;

            btnlandlords.FillColor = Color.Transparent;
            btnlandlords.FillColor2 = Color.Transparent;

            btnaccounts.FillColor = Color.Transparent;
            btnaccounts.FillColor2 = Color.Transparent;

            btnproperties.FillColor = Color.Transparent;
            btnproperties.FillColor2 = Color.Transparent;

            btnleases.FillColor = Color.Transparent;
            btnleases.FillColor2 = Color.Transparent;

            btnpayments.FillColor = Color.Transparent;
            btnpayments.FillColor2 = Color.Transparent;

            btnmaintenancerequest.FillColor = Color.Transparent;
            btnmaintenancerequest.FillColor2 = Color.Transparent;

            btnlogout.FillColor = Color.Transparent;
            btnlogout.FillColor2 = Color.Transparent;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}

using System.Drawing.Text;

namespace RealEstateProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            ButtonOff();
            btnlogin.FillColor = Color.LightSteelBlue;
            btnlogin.FillColor2 = Color.DarkBlue;



        }

        private void ButtonOff()
        {
            ButtonOff();
            btnlogin.FillColor = Color.Transparent;
            btnlogin.FillColor2 = Color.Transparent;
        }

        private void passwordtextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}




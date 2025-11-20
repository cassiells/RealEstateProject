namespace RealEstateProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            panel2 = new Panel();
            btnlogin = new Guna.UI2.WinForms.Guna2GradientButton();
            comboBox1 = new ComboBox();
            label2 = new Label();
            passwordtextbox = new Guna.UI2.WinForms.Guna2TextBox();
            usernametextbox = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            panel1 = new Panel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2GradientPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            guna2GradientPanel1.BackgroundImage = (Image)resources.GetObject("guna2GradientPanel1.BackgroundImage");
            guna2GradientPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            guna2GradientPanel1.Controls.Add(panel2);
            guna2GradientPanel1.Controls.Add(panel1);
            guna2GradientPanel1.CustomizableEdges = customizableEdges7;
            guna2GradientPanel1.FillColor = Color.Transparent;
            guna2GradientPanel1.FillColor2 = Color.Transparent;
            guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            guna2GradientPanel1.Location = new Point(-1, 0);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2GradientPanel1.Size = new Size(1904, 1033);
            guna2GradientPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnlogin);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(passwordtextbox);
            panel2.Controls.Add(usernametextbox);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(1071, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(820, 1018);
            panel2.TabIndex = 1;
            // 
            // btnlogin
            // 
            btnlogin.BorderColor = Color.SteelBlue;
            btnlogin.BorderRadius = 15;
            btnlogin.BorderThickness = 2;
            btnlogin.CustomizableEdges = customizableEdges1;
            btnlogin.DisabledState.BorderColor = Color.DarkGray;
            btnlogin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnlogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnlogin.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnlogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnlogin.FillColor = Color.Transparent;
            btnlogin.FillColor2 = Color.Transparent;
            btnlogin.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogin.ForeColor = Color.White;
            btnlogin.Location = new Point(300, 738);
            btnlogin.Name = "btnlogin";
            btnlogin.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnlogin.Size = new Size(225, 56);
            btnlogin.TabIndex = 6;
            btnlogin.Text = "Login";
            btnlogin.Click += guna2GradientButton1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Admin", "Accountant", "Agent", "Landlord" });
            comboBox1.Location = new Point(159, 620);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(510, 28);
            comboBox1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(176, 538);
            label2.Name = "label2";
            label2.Size = new Size(484, 17);
            label2.TabIndex = 4;
            label2.Text = "Password must be at least 8 characters, including numbers and special characters";
            label2.Click += label2_Click;
            // 
            // passwordtextbox
            // 
            passwordtextbox.BorderColor = Color.AliceBlue;
            passwordtextbox.BorderRadius = 15;
            passwordtextbox.BorderThickness = 2;
            passwordtextbox.CustomizableEdges = customizableEdges3;
            passwordtextbox.DefaultText = "";
            passwordtextbox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            passwordtextbox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            passwordtextbox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            passwordtextbox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            passwordtextbox.FillColor = Color.AliceBlue;
            passwordtextbox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            passwordtextbox.Font = new Font("Segoe UI", 9F);
            passwordtextbox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            passwordtextbox.Location = new Point(159, 483);
            passwordtextbox.Margin = new Padding(3, 4, 3, 4);
            passwordtextbox.Name = "passwordtextbox";
            passwordtextbox.PlaceholderForeColor = Color.Gray;
            passwordtextbox.PlaceholderText = "Enter password";
            passwordtextbox.SelectedText = "";
            passwordtextbox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            passwordtextbox.Size = new Size(510, 51);
            passwordtextbox.TabIndex = 2;
            passwordtextbox.TextChanged += passwordtextbox_TextChanged;
            // 
            // usernametextbox
            // 
            usernametextbox.BorderColor = Color.AliceBlue;
            usernametextbox.BorderRadius = 15;
            usernametextbox.BorderThickness = 2;
            usernametextbox.CustomizableEdges = customizableEdges5;
            usernametextbox.DefaultText = "";
            usernametextbox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            usernametextbox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            usernametextbox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            usernametextbox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            usernametextbox.FillColor = Color.AliceBlue;
            usernametextbox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            usernametextbox.Font = new Font("Segoe UI", 9F);
            usernametextbox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            usernametextbox.Location = new Point(159, 365);
            usernametextbox.Margin = new Padding(3, 4, 3, 4);
            usernametextbox.Name = "usernametextbox";
            usernametextbox.PlaceholderForeColor = Color.Gray;
            usernametextbox.PlaceholderText = "Enter username";
            usernametextbox.SelectedText = "";
            usernametextbox.ShadowDecoration.CustomizableEdges = customizableEdges6;
            usernametextbox.Size = new Size(510, 51);
            usernametextbox.TabIndex = 0;
            usernametextbox.TextChanged += guna2TextBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Azure;
            label1.Location = new Point(340, 179);
            label1.Name = "label1";
            label1.Size = new Size(150, 62);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(13, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1052, 1009);
            panel1.TabIndex = 0;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Location = new Point(241, 293);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(121, 22);
            guna2HtmlLabel1.TabIndex = 3;
            guna2HtmlLabel1.Text = "guna2HtmlLabel1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1902, 1033);
            Controls.Add(guna2GradientPanel1);
            Name = "Form1";
            Text = "Form1";
            guna2GradientPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox passwordtextbox;
        private Guna.UI2.WinForms.Guna2TextBox usernametextbox;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Label label2;
        private ComboBox comboBox1;
        private Guna.UI2.WinForms.Guna2GradientButton btnlogin;
    }
}

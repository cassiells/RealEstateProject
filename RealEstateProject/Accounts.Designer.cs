namespace RealEstateProject
{
    partial class Accounts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2CustomCheckBox1 = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            SuspendLayout();
            // 
            // guna2CustomCheckBox1
            // 
            guna2CustomCheckBox1.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2CustomCheckBox1.CheckedState.BorderRadius = 2;
            guna2CustomCheckBox1.CheckedState.BorderThickness = 0;
            guna2CustomCheckBox1.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            guna2CustomCheckBox1.CustomizableEdges = customizableEdges3;
            guna2CustomCheckBox1.Location = new Point(692, 208);
            guna2CustomCheckBox1.Name = "guna2CustomCheckBox1";
            guna2CustomCheckBox1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2CustomCheckBox1.Size = new Size(89, 25);
            guna2CustomCheckBox1.TabIndex = 0;
            guna2CustomCheckBox1.Text = "guna2CustomCheckBox1";
            guna2CustomCheckBox1.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            guna2CustomCheckBox1.UncheckedState.BorderRadius = 2;
            guna2CustomCheckBox1.UncheckedState.BorderThickness = 0;
            guna2CustomCheckBox1.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            // 
            // Accounts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(guna2CustomCheckBox1);
            Name = "Accounts";
            Text = "Accounts";
            Load += Accounts_Load;
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomCheckBox guna2CustomCheckBox1;
    }
}
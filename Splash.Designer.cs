namespace DBMS
{
    partial class Splash
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            label1 = new Label();
            guna2CircleProgressBar1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            guna2CircleProgressBar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Engravers MT", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(47, 25);
            label1.Name = "label1";
            label1.Size = new Size(720, 32);
            label1.TabIndex = 0;
            label1.Text = "Blood Bank Management System";
            label1.Click += label1_Click;
            // 
            // guna2CircleProgressBar1
            // 
            guna2CircleProgressBar1.BackColor = Color.Transparent;
            guna2CircleProgressBar1.Controls.Add(pictureBox1);
            guna2CircleProgressBar1.FillColor = Color.FromArgb(200, 213, 218, 223);
            guna2CircleProgressBar1.FillThickness = 10;
            guna2CircleProgressBar1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            guna2CircleProgressBar1.ForeColor = Color.White;
            guna2CircleProgressBar1.Location = new Point(278, 73);
            guna2CircleProgressBar1.Minimum = 0;
            guna2CircleProgressBar1.Name = "guna2CircleProgressBar1";
            guna2CircleProgressBar1.ProgressThickness = 10;
            guna2CircleProgressBar1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleProgressBar1.Size = new Size(172, 172);
            guna2CircleProgressBar1.TabIndex = 2;
            guna2CircleProgressBar1.Text = "guna2CircleProgressBar1";
            guna2CircleProgressBar1.ValueChanged += guna2CircleProgressBar1_ValueChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(42, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(91, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Engravers MT", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(303, 265);
            label2.Name = "label2";
            label2.Size = new Size(124, 24);
            label2.TabIndex = 3;
            label2.Text = "Naveen";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(779, 306);
            Controls.Add(label2);
            Controls.Add(guna2CircleProgressBar1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            guna2CircleProgressBar1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar1;
        private PictureBox pictureBox1;
        private Label label2;
    }
}
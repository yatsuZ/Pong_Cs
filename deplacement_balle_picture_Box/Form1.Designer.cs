namespace deplacement_balle_picture_Box
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.raquetteGauche = new System.Windows.Forms.PictureBox();
            this.raquetteDroite = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raquetteGauche)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raquetteDroite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.raquetteGauche);
            this.groupBox1.Controls.Add(this.raquetteDroite);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(-2, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(803, 453);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // raquetteGauche
            // 
            this.raquetteGauche.Image = global::deplacement_balle_picture_Box.Properties.Resources.Palette;
            this.raquetteGauche.Location = new System.Drawing.Point(14, 172);
            this.raquetteGauche.Name = "raquetteGauche";
            this.raquetteGauche.Size = new System.Drawing.Size(22, 152);
            this.raquetteGauche.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.raquetteGauche.TabIndex = 3;
            this.raquetteGauche.TabStop = false;
            this.raquetteGauche.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // raquetteDroite
            // 
            this.raquetteDroite.Image = global::deplacement_balle_picture_Box.Properties.Resources.Palette;
            this.raquetteDroite.Location = new System.Drawing.Point(757, 172);
            this.raquetteDroite.Name = "raquetteDroite";
            this.raquetteDroite.Size = new System.Drawing.Size(22, 152);
            this.raquetteDroite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.raquetteDroite.TabIndex = 1;
            this.raquetteDroite.TabStop = false;
            this.raquetteDroite.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::deplacement_balle_picture_Box.Properties.Resources.ball_red_blur;
            this.pictureBox1.Location = new System.Drawing.Point(392, 216);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raquetteGauche)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raquetteDroite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private PictureBox raquetteDroite;
        private PictureBox raquetteGauche;
    }
}
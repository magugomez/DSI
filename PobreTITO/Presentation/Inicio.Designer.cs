namespace Presentation
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnUserData = new System.Windows.Forms.Button();
            this.btnMisReclamos = new System.Windows.Forms.Button();
            this.btnNewReclamo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCerrarSesion = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.LightBlue;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(216, 450);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // btnUserData
            // 
            this.btnUserData.BackColor = System.Drawing.Color.LightBlue;
            this.btnUserData.FlatAppearance.BorderSize = 0;
            this.btnUserData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserData.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUserData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnUserData.Location = new System.Drawing.Point(24, 165);
            this.btnUserData.Name = "btnUserData";
            this.btnUserData.Size = new System.Drawing.Size(172, 30);
            this.btnUserData.TabIndex = 2;
            this.btnUserData.Text = "Mis datos";
            this.btnUserData.UseVisualStyleBackColor = false;
            // 
            // btnMisReclamos
            // 
            this.btnMisReclamos.BackColor = System.Drawing.Color.LightBlue;
            this.btnMisReclamos.FlatAppearance.BorderSize = 0;
            this.btnMisReclamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMisReclamos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMisReclamos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnMisReclamos.Location = new System.Drawing.Point(24, 201);
            this.btnMisReclamos.Name = "btnMisReclamos";
            this.btnMisReclamos.Size = new System.Drawing.Size(172, 30);
            this.btnMisReclamos.TabIndex = 3;
            this.btnMisReclamos.Text = "Mis reclamos";
            this.btnMisReclamos.UseVisualStyleBackColor = false;
            this.btnMisReclamos.Click += new System.EventHandler(this.btnMisReclamos_Click);
            // 
            // btnNewReclamo
            // 
            this.btnNewReclamo.BackColor = System.Drawing.Color.LightBlue;
            this.btnNewReclamo.FlatAppearance.BorderSize = 0;
            this.btnNewReclamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewReclamo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNewReclamo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            this.btnNewReclamo.Location = new System.Drawing.Point(24, 237);
            this.btnNewReclamo.Name = "btnNewReclamo";
            this.btnNewReclamo.Size = new System.Drawing.Size(172, 30);
            this.btnNewReclamo.TabIndex = 4;
            this.btnNewReclamo.Text = "Nuevo reclamo";
            this.btnNewReclamo.UseVisualStyleBackColor = false;
            this.btnNewReclamo.Click += new System.EventHandler(this.btnNewReclamo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(92, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre usuario";
            // 
            // btnClose
            // 
            this.btnClose.Image = global::Presentation.Properties.Resources.delete_cross_remove_cancel_icon_219222;
            this.btnClose.Location = new System.Drawing.Point(763, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 6;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Image = global::Presentation.Properties.Resources.remove_minimize_minus_delete_icon_219231;
            this.btnMinimize.Location = new System.Drawing.Point(732, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(25, 25);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimize.TabIndex = 7;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lblCerrarSesion
            // 
            this.lblCerrarSesion.AutoSize = true;
            this.lblCerrarSesion.BackColor = System.Drawing.Color.LightBlue;
            this.lblCerrarSesion.DisabledLinkColor = System.Drawing.Color.Transparent;
            this.lblCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblCerrarSesion.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblCerrarSesion.Location = new System.Drawing.Point(94, 59);
            this.lblCerrarSesion.Name = "lblCerrarSesion";
            this.lblCerrarSesion.Size = new System.Drawing.Size(75, 15);
            this.lblCerrarSesion.TabIndex = 9;
            this.lblCerrarSesion.TabStop = true;
            this.lblCerrarSesion.Text = "Cerrar sesión";
            this.lblCerrarSesion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCerrarSesion_LinkClicked);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCerrarSesion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNewReclamo);
            this.Controls.Add(this.btnMisReclamos);
            this.Controls.Add(this.btnUserData);
            this.Controls.Add(this.splitter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Splitter splitter1;
        private Button btnUserData;
        private Button btnMisReclamos;
        private Button btnNewReclamo;
        private Label label1;
        private PictureBox btnClose;
        private PictureBox btnMinimize;
        private PictureBox pictureBox1;
        private LinkLabel lblCerrarSesion;
    }
}
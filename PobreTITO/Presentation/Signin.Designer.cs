namespace Presentation
{
    partial class Signin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnSign = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(215, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "PobreTITO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(281, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "¡Bienvenido vecino!";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.tbEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbEmail.Location = new System.Drawing.Point(233, 177);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(347, 26);
            this.tbEmail.TabIndex = 2;
            this.tbEmail.Text = "Email";
            this.tbEmail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.tbEmail.Enter += new System.EventHandler(this.tbEmail_Enter);
            this.tbEmail.Leave += new System.EventHandler(this.tbEmail_Leave);
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.tbName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbName.Location = new System.Drawing.Point(233, 214);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(347, 26);
            this.tbName.TabIndex = 3;
            this.tbName.Text = "Nombre completo";
            this.tbName.Enter += new System.EventHandler(this.tbName_Enter);
            this.tbName.Leave += new System.EventHandler(this.tbName_Leave);
            // 
            // tbUser
            // 
            this.tbUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.tbUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbUser.Location = new System.Drawing.Point(233, 251);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(347, 26);
            this.tbUser.TabIndex = 4;
            this.tbUser.Text = "Nombre de usuario";
            this.tbUser.Enter += new System.EventHandler(this.tbUser_Enter);
            this.tbUser.Leave += new System.EventHandler(this.tbUser_Leave);
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.tbPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPassword.Location = new System.Drawing.Point(233, 288);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(347, 26);
            this.tbPassword.TabIndex = 5;
            this.tbPassword.Text = "Contraseña";
            this.tbPassword.Enter += new System.EventHandler(this.tbPassword_Enter);
            this.tbPassword.Leave += new System.EventHandler(this.tbPassword_Leave);
            // 
            // btnSign
            // 
            this.btnSign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(95)))), ((int)(((byte)(142)))));
            this.btnSign.FlatAppearance.BorderSize = 0;
            this.btnSign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSign.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSign.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSign.Location = new System.Drawing.Point(328, 329);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(162, 32);
            this.btnSign.TabIndex = 6;
            this.btnSign.Text = "Registrarse";
            this.btnSign.UseVisualStyleBackColor = false;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(296, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "¿Ya tenes cuenta?";
            // 
            // btnLogin
            // 
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnLogin.Location = new System.Drawing.Point(405, 376);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(134, 34);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Iniciar sesión";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::Presentation.Properties.Resources.delete_cross_remove_cancel_icon_219222;
            this.btnClose.Location = new System.Drawing.Point(770, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(18, 18);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 9;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Image = global::Presentation.Properties.Resources.remove_minimize_minus_delete_icon_219231;
            this.btnMinimize.Location = new System.Drawing.Point(746, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(18, 18);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimize.TabIndex = 10;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // Signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Signin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbEmail;
        private TextBox tbName;
        private TextBox tbUser;
        private TextBox tbPassword;
        private Button btnSign;
        private Label label3;
        private Button btnLogin;
        private PictureBox btnClose;
        private PictureBox btnMinimize;
    }
}
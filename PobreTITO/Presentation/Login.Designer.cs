namespace Presentation
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSign = new System.Windows.Forms.Button();
            this.lblErrorMessage = new System.Windows.Forms.Label();
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
            this.label1.Location = new System.Drawing.Point(219, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "PobreTITO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.UseWaitCursor = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(331, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "¡Hola vecino!";
            this.label2.UseWaitCursor = true;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbUser
            // 
            this.tbUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.tbUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbUser.Location = new System.Drawing.Point(234, 194);
            this.tbUser.Margin = new System.Windows.Forms.Padding(0);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(352, 26);
            this.tbUser.TabIndex = 2;
            this.tbUser.Text = "Usuario";
            this.tbUser.UseWaitCursor = true;
            this.tbUser.Enter += new System.EventHandler(this.tbUser_Enter);
            this.tbUser.Leave += new System.EventHandler(this.tbUser_Leave);
            this.tbUser.MouseEnter += new System.EventHandler(this.tbUser_MouseEnter);
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.tbPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPassword.Location = new System.Drawing.Point(234, 240);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(0);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(352, 26);
            this.tbPassword.TabIndex = 3;
            this.tbPassword.Text = "Contraseña";
            this.tbPassword.UseWaitCursor = true;
            this.tbPassword.Enter += new System.EventHandler(this.tbPassword_Enter);
            this.tbPassword.Leave += new System.EventHandler(this.tbPassword_Leave);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(95)))), ((int)(((byte)(142)))));
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogin.Location = new System.Drawing.Point(331, 295);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(162, 32);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Iniciar sesión";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.UseWaitCursor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(297, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "¿No tenes cuenta?";
            this.label3.UseWaitCursor = true;
            // 
            // btnSign
            // 
            this.btnSign.FlatAppearance.BorderSize = 0;
            this.btnSign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSign.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSign.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnSign.Location = new System.Drawing.Point(410, 347);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(116, 32);
            this.btnSign.TabIndex = 6;
            this.btnSign.Text = "Registrarse";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.UseWaitCursor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblErrorMessage.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessage.Location = new System.Drawing.Point(367, 162);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Padding = new System.Windows.Forms.Padding(5, 5, 5, 6);
            this.lblErrorMessage.Size = new System.Drawing.Size(94, 32);
            this.lblErrorMessage.TabIndex = 7;
            this.lblErrorMessage.Text = "*msgError";
            this.lblErrorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblErrorMessage.UseWaitCursor = true;
            this.lblErrorMessage.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(747, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(18, 18);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 9;
            this.btnClose.TabStop = false;
            this.btnClose.UseWaitCursor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(716, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(18, 18);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimize.TabIndex = 10;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.UseWaitCursor = true;
            this.btnMinimize.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(784, 434);
            this.ControlBox = false;
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbUser;
        private TextBox tbPassword;
        private Button btnLogin;
        private Label label3;
        private Button btnSign;
        private Label lblErrorMessage;
        private PictureBox btnClose;
        private PictureBox btnMinimize;
    }
}
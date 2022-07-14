namespace Presentation
{
    partial class Incidente
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
            this.label3 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.combTipo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbArea = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(142, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos del incidente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(211, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipo (elija solo uno)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(211, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descripción";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(222, 189);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(364, 23);
            this.tbDescription.TabIndex = 6;
            // 
            // combTipo
            // 
            this.combTipo.FormattingEnabled = true;
            this.combTipo.Items.AddRange(new object[] {
            "Seguridad pública",
            "Automovilistico",
            "Eléctrico"});
            this.combTipo.Location = new System.Drawing.Point(222, 129);
            this.combTipo.Name = "combTipo";
            this.combTipo.Size = new System.Drawing.Size(364, 23);
            this.combTipo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(211, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Area/barrio";
            // 
            // tbArea
            // 
            this.tbArea.Location = new System.Drawing.Point(222, 253);
            this.tbArea.Name = "tbArea";
            this.tbArea.Size = new System.Drawing.Size(364, 23);
            this.tbArea.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(211, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Dirección ";
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(222, 316);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(364, 23);
            this.tbDireccion.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(95)))), ((int)(((byte)(142)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(427, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 30);
            this.button1.TabIndex = 12;
            this.button1.Text = "Guardar reclamo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.Location = new System.Drawing.Point(592, 369);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 30);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(427, 67);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(37, 15);
            this.lblError.TabIndex = 14;
            this.lblError.Text = "*error";
            this.lblError.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Image = global::Presentation.Properties.Resources.delete_cross_remove_cancel_icon_219222;
            this.btnClose.Location = new System.Drawing.Point(770, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(18, 18);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 15;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Image = global::Presentation.Properties.Resources.remove_minimize_minus_delete_icon_219231;
            this.btnMinimize.Location = new System.Drawing.Point(746, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(18, 18);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimize.TabIndex = 16;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // Incidente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbArea);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.combTipo);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Incidente";
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
        private Label label3;
        private TextBox tbDescription;
        private ComboBox combTipo;
        private Label label4;
        private TextBox tbArea;
        private Label label5;
        private TextBox tbDireccion;
        private Button button1;
        private Button btnCancel;
        private Label lblError;
        private PictureBox btnClose;
        private PictureBox btnMinimize;
    }
}
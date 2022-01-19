namespace Escolar {
    partial class LoginProfesorForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginProfesorForm));
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnLoginProf = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblInfo.Location = new System.Drawing.Point(51, 45);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(219, 20);
            this.lblInfo.TabIndex = 6;
            this.lblInfo.Text = "Por favor, ingrese sus datos";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(19, 77);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 7;
            this.lblID.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(22, 93);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(283, 20);
            this.txtID.TabIndex = 8;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(19, 116);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(64, 13);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Contraseña:";
            // 
            // btnLoginProf
            // 
            this.btnLoginProf.Location = new System.Drawing.Point(38, 175);
            this.btnLoginProf.Name = "btnLoginProf";
            this.btnLoginProf.Size = new System.Drawing.Size(250, 58);
            this.btnLoginProf.TabIndex = 11;
            this.btnLoginProf.Text = "Ingresar";
            this.btnLoginProf.UseVisualStyleBackColor = true;
            this.btnLoginProf.Click += new System.EventHandler(this.btnLoginProf_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(22, 132);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(283, 20);
            this.txtPassword.TabIndex = 10;
            // 
            // LoginProfesorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 291);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLoginProf);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginProfesorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login (Profesor)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginProfesorForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnLoginProf;
        private System.Windows.Forms.TextBox txtPassword;
    }
}
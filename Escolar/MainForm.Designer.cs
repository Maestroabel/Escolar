namespace Escolar {
    partial class MainForm {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnLoginEst = new System.Windows.Forms.Button();
            this.btnLoginProf = new System.Windows.Forms.Button();
            this.lblConfirmar = new System.Windows.Forms.Label();
            this.btnRegistrarEst = new System.Windows.Forms.Button();
            this.btnRegistrarProf = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoginEst
            // 
            this.btnLoginEst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoginEst.Location = new System.Drawing.Point(122, 198);
            this.btnLoginEst.Name = "btnLoginEst";
            this.btnLoginEst.Size = new System.Drawing.Size(171, 59);
            this.btnLoginEst.TabIndex = 0;
            this.btnLoginEst.Text = "Estudiante";
            this.btnLoginEst.UseVisualStyleBackColor = true;
            this.btnLoginEst.Click += new System.EventHandler(this.btnLoginEst_Click);
            // 
            // btnLoginProf
            // 
            this.btnLoginProf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoginProf.Location = new System.Drawing.Point(502, 198);
            this.btnLoginProf.Name = "btnLoginProf";
            this.btnLoginProf.Size = new System.Drawing.Size(164, 59);
            this.btnLoginProf.TabIndex = 1;
            this.btnLoginProf.Text = "Profesor";
            this.btnLoginProf.UseVisualStyleBackColor = true;
            this.btnLoginProf.Click += new System.EventHandler(this.btnLoginProf_Click);
            // 
            // lblConfirmar
            // 
            this.lblConfirmar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConfirmar.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblConfirmar, 4);
            this.lblConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblConfirmar.Location = new System.Drawing.Point(243, 82);
            this.lblConfirmar.Name = "lblConfirmar";
            this.lblConfirmar.Size = new System.Drawing.Size(302, 31);
            this.lblConfirmar.TabIndex = 2;
            this.lblConfirmar.Text = "¿Cómo desea ingresar?";
            // 
            // btnRegistrarEst
            // 
            this.btnRegistrarEst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRegistrarEst.FlatAppearance.BorderSize = 0;
            this.btnRegistrarEst.Location = new System.Drawing.Point(122, 263);
            this.btnRegistrarEst.Name = "btnRegistrarEst";
            this.btnRegistrarEst.Size = new System.Drawing.Size(171, 27);
            this.btnRegistrarEst.TabIndex = 3;
            this.btnRegistrarEst.Text = "Registrar estudiante";
            this.btnRegistrarEst.UseVisualStyleBackColor = true;
            this.btnRegistrarEst.Click += new System.EventHandler(this.btnRegistrarEst_Click);
            // 
            // btnRegistrarProf
            // 
            this.btnRegistrarProf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRegistrarProf.FlatAppearance.BorderSize = 0;
            this.btnRegistrarProf.Location = new System.Drawing.Point(502, 263);
            this.btnRegistrarProf.Name = "btnRegistrarProf";
            this.btnRegistrarProf.Size = new System.Drawing.Size(164, 27);
            this.btnRegistrarProf.TabIndex = 4;
            this.btnRegistrarProf.Text = "Registrar profesor";
            this.btnRegistrarProf.UseVisualStyleBackColor = true;
            this.btnRegistrarProf.Click += new System.EventHandler(this.btnRegistrarProf_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.06329F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.40506F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.78481F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.91139F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.51899F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.18987F));
            this.tableLayoutPanel1.Controls.Add(this.lblConfirmar, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnRegistrarProf, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnLoginEst, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnLoginProf, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnRegistrarEst, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnAdminLogin, 5, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.551069F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.94062F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(790, 421);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdminLogin.Location = new System.Drawing.Point(672, 394);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(115, 24);
            this.btnAdminLogin.TabIndex = 5;
            this.btnAdminLogin.Text = "Administrador";
            this.btnAdminLogin.UseVisualStyleBackColor = true;
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 421);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(806, 460);
            this.Name = "MainForm";
            this.Text = "Ingresar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoginEst;
        private System.Windows.Forms.Button btnLoginProf;
        private System.Windows.Forms.Label lblConfirmar;
        private System.Windows.Forms.Button btnRegistrarEst;
        private System.Windows.Forms.Button btnRegistrarProf;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAdminLogin;
    }
}



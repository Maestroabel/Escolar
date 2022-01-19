namespace Escolar {
    partial class ProfesorForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfesorForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnImpartirAsig = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAsignarCal = new System.Windows.Forms.Button();
            this.btnVerAsig = new System.Windows.Forms.Button();
            this.btnVerCal = new System.Windows.Forms.Button();
            this.btnVerEst = new System.Windows.Forms.Button();
            this.btnBorrarProf = new System.Windows.Forms.Button();
            this.btnModificarCal = new System.Windows.Forms.Button();
            this.btnModificarProf = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.6914F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.69139F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.69139F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.727F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.50742F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.69139F));
            this.tableLayoutPanel1.Controls.Add(this.lblBienvenido, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCerrarSesion, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnImpartirAsig, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnAsignarCal, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnVerAsig, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnVerCal, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnVerEst, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnBorrarProf, 5, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnModificarCal, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnModificarProf, 4, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.81731F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.48974F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.31672F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.23586F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.23586F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.23586F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.31672F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.19648F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(675, 341);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBienvenido.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblBienvenido, 2);
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblBienvenido.Location = new System.Drawing.Point(3, 9);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(88, 18);
            this.lblBienvenido.TabIndex = 0;
            this.lblBienvenido.Text = "Bienvenido, ";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCerrarSesion.Location = new System.Drawing.Point(563, 3);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(109, 30);
            this.btnCerrarSesion.TabIndex = 1;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnImpartirAsig
            // 
            this.btnImpartirAsig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnImpartirAsig.Location = new System.Drawing.Point(3, 39);
            this.btnImpartirAsig.Name = "btnImpartirAsig";
            this.btnImpartirAsig.Size = new System.Drawing.Size(106, 39);
            this.btnImpartirAsig.TabIndex = 2;
            this.btnImpartirAsig.Text = "Impartir Asignatura";
            this.btnImpartirAsig.UseVisualStyleBackColor = true;
            this.btnImpartirAsig.Click += new System.EventHandler(this.btnImpartirAsig_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 6);
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.tableLayoutPanel1.SetRowSpan(this.dataGridView1, 5);
            this.dataGridView1.Size = new System.Drawing.Size(669, 208);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnAsignarCal
            // 
            this.btnAsignarCal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAsignarCal.Location = new System.Drawing.Point(115, 39);
            this.btnAsignarCal.Name = "btnAsignarCal";
            this.btnAsignarCal.Size = new System.Drawing.Size(106, 39);
            this.btnAsignarCal.TabIndex = 4;
            this.btnAsignarCal.Text = "Asignar Calificación";
            this.btnAsignarCal.UseVisualStyleBackColor = true;
            this.btnAsignarCal.Click += new System.EventHandler(this.btnAsignarCal_Click);
            // 
            // btnVerAsig
            // 
            this.btnVerAsig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVerAsig.Location = new System.Drawing.Point(339, 39);
            this.btnVerAsig.Name = "btnVerAsig";
            this.btnVerAsig.Size = new System.Drawing.Size(100, 39);
            this.btnVerAsig.TabIndex = 5;
            this.btnVerAsig.Text = "Ver Asignaturas";
            this.btnVerAsig.UseVisualStyleBackColor = true;
            this.btnVerAsig.Click += new System.EventHandler(this.btnVerAsig_Click);
            // 
            // btnVerCal
            // 
            this.btnVerCal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVerCal.Location = new System.Drawing.Point(445, 39);
            this.btnVerCal.Name = "btnVerCal";
            this.btnVerCal.Size = new System.Drawing.Size(112, 39);
            this.btnVerCal.TabIndex = 6;
            this.btnVerCal.Text = "Ver Calificaciones";
            this.btnVerCal.UseVisualStyleBackColor = true;
            this.btnVerCal.Click += new System.EventHandler(this.btnVerCal_Click);
            // 
            // btnVerEst
            // 
            this.btnVerEst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVerEst.Location = new System.Drawing.Point(563, 39);
            this.btnVerEst.Name = "btnVerEst";
            this.btnVerEst.Size = new System.Drawing.Size(109, 39);
            this.btnVerEst.TabIndex = 7;
            this.btnVerEst.Text = "Ver estudiantes";
            this.btnVerEst.UseVisualStyleBackColor = true;
            this.btnVerEst.Click += new System.EventHandler(this.btnVerEst_Click);
            // 
            // btnBorrarProf
            // 
            this.btnBorrarProf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBorrarProf.Location = new System.Drawing.Point(563, 298);
            this.btnBorrarProf.Name = "btnBorrarProf";
            this.btnBorrarProf.Size = new System.Drawing.Size(109, 40);
            this.btnBorrarProf.TabIndex = 8;
            this.btnBorrarProf.Text = "Eliminar Cuenta";
            this.btnBorrarProf.UseVisualStyleBackColor = true;
            this.btnBorrarProf.Click += new System.EventHandler(this.btnBorrarProf_Click);
            // 
            // btnModificarCal
            // 
            this.btnModificarCal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModificarCal.Location = new System.Drawing.Point(227, 39);
            this.btnModificarCal.Name = "btnModificarCal";
            this.btnModificarCal.Size = new System.Drawing.Size(106, 39);
            this.btnModificarCal.TabIndex = 9;
            this.btnModificarCal.Text = "Modificar Calificación";
            this.btnModificarCal.UseVisualStyleBackColor = true;
            this.btnModificarCal.Click += new System.EventHandler(this.btnModificarCal_Click);
            // 
            // btnModificarProf
            // 
            this.btnModificarProf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModificarProf.Location = new System.Drawing.Point(445, 298);
            this.btnModificarProf.Name = "btnModificarProf";
            this.btnModificarProf.Size = new System.Drawing.Size(112, 40);
            this.btnModificarProf.TabIndex = 10;
            this.btnModificarProf.Text = "Modificar Datos";
            this.btnModificarProf.UseVisualStyleBackColor = true;
            this.btnModificarProf.Click += new System.EventHandler(this.btnModificarProf_Click);
            // 
            // ProfesorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 341);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProfesorForm";
            this.Text = "Profesorado INTEC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ProfesorForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnImpartirAsig;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAsignarCal;
        private System.Windows.Forms.Button btnVerAsig;
        private System.Windows.Forms.Button btnVerCal;
        private System.Windows.Forms.Button btnVerEst;
        private System.Windows.Forms.Button btnBorrarProf;
        private System.Windows.Forms.Button btnModificarCal;
        private System.Windows.Forms.Button btnModificarProf;
    }
}

﻿namespace Escolar {
    partial class EstudianteForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstudianteForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnInscripcion = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnVerAsignaturas = new System.Windows.Forms.Button();
            this.btnVerCalificaciones = new System.Windows.Forms.Button();
            this.btnBorrarEst = new System.Windows.Forms.Button();
            this.btnModificarEst = new System.Windows.Forms.Button();
            this.btnRetirarAsignatura = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.lblBienvenido, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCerrarSesion, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnInscripcion, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnVerAsignaturas, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnVerCalificaciones, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnBorrarEst, 5, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnModificarEst, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnRetirarAsignatura, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.974532F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.87806F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.111654F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.78702F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.59377F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.59377F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.732394F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.39437F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(653, 355);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBienvenido.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblBienvenido, 2);
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblBienvenido.Location = new System.Drawing.Point(3, 6);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(88, 18);
            this.lblBienvenido.TabIndex = 0;
            this.lblBienvenido.Text = "Bienvenido, ";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCerrarSesion.Location = new System.Drawing.Point(543, 3);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(107, 25);
            this.btnCerrarSesion.TabIndex = 1;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnInscripcion
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnInscripcion, 2);
            this.btnInscripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInscripcion.Location = new System.Drawing.Point(3, 34);
            this.btnInscripcion.Name = "btnInscripcion";
            this.btnInscripcion.Size = new System.Drawing.Size(210, 35);
            this.btnInscripcion.TabIndex = 2;
            this.btnInscripcion.Text = "Inscribirse a Asignatura";
            this.btnInscripcion.UseVisualStyleBackColor = true;
            this.btnInscripcion.Click += new System.EventHandler(this.btnInscripcion_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 6);
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.tableLayoutPanel1.SetRowSpan(this.dataGridView1, 5);
            this.dataGridView1.Size = new System.Drawing.Size(647, 232);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnVerAsignaturas
            // 
            this.btnVerAsignaturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVerAsignaturas.Location = new System.Drawing.Point(327, 34);
            this.btnVerAsignaturas.Name = "btnVerAsignaturas";
            this.btnVerAsignaturas.Size = new System.Drawing.Size(102, 35);
            this.btnVerAsignaturas.TabIndex = 4;
            this.btnVerAsignaturas.Text = "Ver Asignaturas Inscritas";
            this.btnVerAsignaturas.UseVisualStyleBackColor = true;
            this.btnVerAsignaturas.Click += new System.EventHandler(this.btnVerAsignaturas_Click);
            // 
            // btnVerCalificaciones
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnVerCalificaciones, 2);
            this.btnVerCalificaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVerCalificaciones.Location = new System.Drawing.Point(435, 34);
            this.btnVerCalificaciones.Name = "btnVerCalificaciones";
            this.btnVerCalificaciones.Size = new System.Drawing.Size(215, 35);
            this.btnVerCalificaciones.TabIndex = 5;
            this.btnVerCalificaciones.Text = "Ver Calificaciones";
            this.btnVerCalificaciones.UseVisualStyleBackColor = true;
            this.btnVerCalificaciones.Click += new System.EventHandler(this.btnVerCalificaciones_Click);
            // 
            // btnBorrarEst
            // 
            this.btnBorrarEst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBorrarEst.Location = new System.Drawing.Point(543, 313);
            this.btnBorrarEst.Name = "btnBorrarEst";
            this.btnBorrarEst.Size = new System.Drawing.Size(107, 39);
            this.btnBorrarEst.TabIndex = 6;
            this.btnBorrarEst.Text = "Eliminar Cuenta";
            this.btnBorrarEst.UseVisualStyleBackColor = true;
            this.btnBorrarEst.Click += new System.EventHandler(this.btnBorrarEst_Click);
            // 
            // btnModificarEst
            // 
            this.btnModificarEst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModificarEst.Location = new System.Drawing.Point(435, 313);
            this.btnModificarEst.Name = "btnModificarEst";
            this.btnModificarEst.Size = new System.Drawing.Size(102, 39);
            this.btnModificarEst.TabIndex = 7;
            this.btnModificarEst.Text = "Modificar Datos";
            this.btnModificarEst.UseVisualStyleBackColor = true;
            this.btnModificarEst.Click += new System.EventHandler(this.btnModificarEst_Click);
            // 
            // btnRetirarAsignatura
            // 
            this.btnRetirarAsignatura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRetirarAsignatura.Location = new System.Drawing.Point(219, 34);
            this.btnRetirarAsignatura.Name = "btnRetirarAsignatura";
            this.btnRetirarAsignatura.Size = new System.Drawing.Size(102, 35);
            this.btnRetirarAsignatura.TabIndex = 8;
            this.btnRetirarAsignatura.Text = "Retirar Asignatura";
            this.btnRetirarAsignatura.UseVisualStyleBackColor = true;
            this.btnRetirarAsignatura.Click += new System.EventHandler(this.btnRetirarAsignatura_Click);
            // 
            // EstudianteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 355);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(522, 327);
            this.Name = "EstudianteForm";
            this.Text = "Estudiantado INTEC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EstudianteForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnInscripcion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnVerAsignaturas;
        private System.Windows.Forms.Button btnVerCalificaciones;
        private System.Windows.Forms.Button btnBorrarEst;
        private System.Windows.Forms.Button btnModificarEst;
        private System.Windows.Forms.Button btnRetirarAsignatura;
    }
}
namespace Escolar {
    partial class AsignarCaliForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsignarCaliForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtIDEstudiante = new System.Windows.Forms.TextBox();
            this.txtClaveAsignatura = new System.Windows.Forms.TextBox();
            this.txtIDProfesor = new System.Windows.Forms.TextBox();
            this.txtCalificacion = new System.Windows.Forms.TextBox();
            this.lblEstudianteID = new System.Windows.Forms.Label();
            this.lblClaveAsignatura = new System.Windows.Forms.Label();
            this.lblIDProfesor = new System.Windows.Forms.Label();
            this.IDCalificacion = new System.Windows.Forms.Label();
            this.btnAsignarCali = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtIDEstudiante, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtClaveAsignatura, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtIDProfesor, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtCalificacion, 6, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblEstudianteID, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblClaveAsignatura, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblIDProfesor, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.IDCalificacion, 6, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnAsignarCali, 8, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.16071F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.16071F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.16071F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.16071F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.57632F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.165109F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.329843F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.806283F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.46597F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 382);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 10);
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.tableLayoutPanel1.SetRowSpan(this.dataGridView1, 6);
            this.dataGridView1.Size = new System.Drawing.Size(794, 241);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // txtIDEstudiante
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtIDEstudiante, 2);
            this.txtIDEstudiante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtIDEstudiante.Location = new System.Drawing.Point(3, 277);
            this.txtIDEstudiante.Name = "txtIDEstudiante";
            this.txtIDEstudiante.ReadOnly = true;
            this.txtIDEstudiante.Size = new System.Drawing.Size(154, 20);
            this.txtIDEstudiante.TabIndex = 1;
            // 
            // txtClaveAsignatura
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtClaveAsignatura, 2);
            this.txtClaveAsignatura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtClaveAsignatura.Location = new System.Drawing.Point(163, 277);
            this.txtClaveAsignatura.Name = "txtClaveAsignatura";
            this.txtClaveAsignatura.ReadOnly = true;
            this.txtClaveAsignatura.Size = new System.Drawing.Size(154, 20);
            this.txtClaveAsignatura.TabIndex = 2;
            // 
            // txtIDProfesor
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtIDProfesor, 2);
            this.txtIDProfesor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtIDProfesor.Location = new System.Drawing.Point(323, 277);
            this.txtIDProfesor.Name = "txtIDProfesor";
            this.txtIDProfesor.ReadOnly = true;
            this.txtIDProfesor.Size = new System.Drawing.Size(154, 20);
            this.txtIDProfesor.TabIndex = 3;
            // 
            // txtCalificacion
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtCalificacion, 2);
            this.txtCalificacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCalificacion.Location = new System.Drawing.Point(483, 277);
            this.txtCalificacion.Name = "txtCalificacion";
            this.txtCalificacion.Size = new System.Drawing.Size(154, 20);
            this.txtCalificacion.TabIndex = 4;
            // 
            // lblEstudianteID
            // 
            this.lblEstudianteID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEstudianteID.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblEstudianteID, 2);
            this.lblEstudianteID.Location = new System.Drawing.Point(3, 254);
            this.lblEstudianteID.Name = "lblEstudianteID";
            this.lblEstudianteID.Size = new System.Drawing.Size(91, 13);
            this.lblEstudianteID.TabIndex = 5;
            this.lblEstudianteID.Text = "ID del Estudiante:";
            // 
            // lblClaveAsignatura
            // 
            this.lblClaveAsignatura.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblClaveAsignatura.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblClaveAsignatura, 2);
            this.lblClaveAsignatura.Location = new System.Drawing.Point(163, 254);
            this.lblClaveAsignatura.Name = "lblClaveAsignatura";
            this.lblClaveAsignatura.Size = new System.Drawing.Size(90, 13);
            this.lblClaveAsignatura.TabIndex = 6;
            this.lblClaveAsignatura.Text = "Clave Asignatura:";
            // 
            // lblIDProfesor
            // 
            this.lblIDProfesor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblIDProfesor.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblIDProfesor, 2);
            this.lblIDProfesor.Location = new System.Drawing.Point(323, 254);
            this.lblIDProfesor.Name = "lblIDProfesor";
            this.lblIDProfesor.Size = new System.Drawing.Size(80, 13);
            this.lblIDProfesor.TabIndex = 7;
            this.lblIDProfesor.Text = "ID del Profesor:";
            // 
            // IDCalificacion
            // 
            this.IDCalificacion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.IDCalificacion.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.IDCalificacion, 2);
            this.IDCalificacion.Location = new System.Drawing.Point(483, 254);
            this.IDCalificacion.Name = "IDCalificacion";
            this.IDCalificacion.Size = new System.Drawing.Size(64, 13);
            this.IDCalificacion.TabIndex = 8;
            this.IDCalificacion.Text = "Calificación:";
            // 
            // btnAsignarCali
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnAsignarCali, 2);
            this.btnAsignarCali.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAsignarCali.Location = new System.Drawing.Point(643, 302);
            this.btnAsignarCali.Name = "btnAsignarCali";
            this.btnAsignarCali.Size = new System.Drawing.Size(154, 77);
            this.btnAsignarCali.TabIndex = 9;
            this.btnAsignarCali.Text = "Asignar Calificación";
            this.btnAsignarCali.UseVisualStyleBackColor = true;
            this.btnAsignarCali.Click += new System.EventHandler(this.btnAsignarCali_Click);
            // 
            // AsignarCaliForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 382);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AsignarCaliForm";
            this.Text = "Asignar Calificación...";
            this.Load += new System.EventHandler(this.AsignarCaliForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtIDEstudiante;
        private System.Windows.Forms.TextBox txtClaveAsignatura;
        private System.Windows.Forms.TextBox txtIDProfesor;
        private System.Windows.Forms.TextBox txtCalificacion;
        private System.Windows.Forms.Label lblEstudianteID;
        private System.Windows.Forms.Label lblClaveAsignatura;
        private System.Windows.Forms.Label lblIDProfesor;
        private System.Windows.Forms.Label IDCalificacion;
        private System.Windows.Forms.Button btnAsignarCali;
    }
}
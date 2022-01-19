namespace Escolar
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnCrearAsig = new System.Windows.Forms.Button();
            this.btnModAsig = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnVerAsig = new System.Windows.Forms.Button();
            this.btnVerEst = new System.Windows.Forms.Button();
            this.btnVerProf = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1.Controls.Add(this.btnCrearAsig, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnModAsig, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnVerAsig, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnVerEst, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnVerProf, 5, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.12056F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.79953F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.32537F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.81109F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.12713F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.816317F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(641, 344);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBienvenido.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblBienvenido, 4);
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblBienvenido.Location = new System.Drawing.Point(3, 8);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(370, 18);
            this.lblBienvenido.TabIndex = 1;
            this.lblBienvenido.Text = "Bienvenido, Administrador. Seleccione una operación...";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCerrarSesion.Location = new System.Drawing.Point(533, 3);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(105, 28);
            this.btnCerrarSesion.TabIndex = 2;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnCrearAsig
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnCrearAsig, 2);
            this.btnCrearAsig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCrearAsig.Location = new System.Drawing.Point(3, 37);
            this.btnCrearAsig.Name = "btnCrearAsig";
            this.btnCrearAsig.Size = new System.Drawing.Size(206, 38);
            this.btnCrearAsig.TabIndex = 3;
            this.btnCrearAsig.Text = "Crear Asignatura";
            this.btnCrearAsig.UseVisualStyleBackColor = true;
            this.btnCrearAsig.Click += new System.EventHandler(this.btnCrearAsig_Click);
            // 
            // btnModAsig
            // 
            this.btnModAsig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModAsig.Location = new System.Drawing.Point(215, 37);
            this.btnModAsig.Name = "btnModAsig";
            this.btnModAsig.Size = new System.Drawing.Size(100, 38);
            this.btnModAsig.TabIndex = 4;
            this.btnModAsig.Text = "Modificar Asignatura";
            this.btnModAsig.UseVisualStyleBackColor = true;
            this.btnModAsig.Click += new System.EventHandler(this.btnModAsig_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 6);
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.tableLayoutPanel1.SetRowSpan(this.dataGridView1, 4);
            this.dataGridView1.Size = new System.Drawing.Size(635, 260);
            this.dataGridView1.TabIndex = 5;
            // 
            // btnVerAsig
            // 
            this.btnVerAsig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVerAsig.Location = new System.Drawing.Point(321, 37);
            this.btnVerAsig.Name = "btnVerAsig";
            this.btnVerAsig.Size = new System.Drawing.Size(100, 38);
            this.btnVerAsig.TabIndex = 6;
            this.btnVerAsig.Text = "Ver Asignaturas";
            this.btnVerAsig.UseVisualStyleBackColor = true;
            this.btnVerAsig.Click += new System.EventHandler(this.btnVerAsig_Click);
            // 
            // btnVerEst
            // 
            this.btnVerEst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVerEst.Location = new System.Drawing.Point(427, 37);
            this.btnVerEst.Name = "btnVerEst";
            this.btnVerEst.Size = new System.Drawing.Size(100, 38);
            this.btnVerEst.TabIndex = 7;
            this.btnVerEst.Text = "Ver Estudiantes";
            this.btnVerEst.UseVisualStyleBackColor = true;
            this.btnVerEst.Click += new System.EventHandler(this.btnVerEst_Click);
            // 
            // btnVerProf
            // 
            this.btnVerProf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVerProf.Location = new System.Drawing.Point(533, 37);
            this.btnVerProf.Name = "btnVerProf";
            this.btnVerProf.Size = new System.Drawing.Size(105, 38);
            this.btnVerProf.TabIndex = 8;
            this.btnVerProf.Text = "Ver Profesores";
            this.btnVerProf.UseVisualStyleBackColor = true;
            this.btnVerProf.Click += new System.EventHandler(this.btnVerProf_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 344);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MinimumSize = new System.Drawing.Size(657, 383);
            this.Name = "AdminForm";
            this.Text = "Administración INTEC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnCrearAsig;
        private System.Windows.Forms.Button btnModAsig;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnVerAsig;
        private System.Windows.Forms.Button btnVerEst;
        private System.Windows.Forms.Button btnVerProf;
    }
}
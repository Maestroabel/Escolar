namespace Escolar {
    partial class ModAsignaturaForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModAsignaturaForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtCreditos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCreditos = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.btnModAsig = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1.Controls.Add(this.txtCreditos, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtNombre, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblClave, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblNombre, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblCreditos, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtClave, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnModAsig, 2, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.19469F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0295F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.198813F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.42773F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.489676F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.4375F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(542, 339);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtCreditos
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtCreditos, 2);
            this.txtCreditos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCreditos.Location = new System.Drawing.Point(363, 252);
            this.txtCreditos.Name = "txtCreditos";
            this.txtCreditos.Size = new System.Drawing.Size(176, 20);
            this.txtCreditos.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtNombre, 2);
            this.txtNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNombre.Location = new System.Drawing.Point(183, 252);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(174, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 6);
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.dataGridView1, 3);
            this.dataGridView1.Size = new System.Drawing.Size(536, 202);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // lblClave
            // 
            this.lblClave.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(3, 232);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(37, 13);
            this.lblClave.TabIndex = 1;
            this.lblClave.Text = "Clave:";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(183, 232);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCreditos
            // 
            this.lblCreditos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCreditos.AutoSize = true;
            this.lblCreditos.Location = new System.Drawing.Point(363, 232);
            this.lblCreditos.Name = "lblCreditos";
            this.lblCreditos.Size = new System.Drawing.Size(48, 13);
            this.lblCreditos.TabIndex = 3;
            this.lblCreditos.Text = "Créditos:";
            // 
            // txtClave
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtClave, 2);
            this.txtClave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtClave.Location = new System.Drawing.Point(3, 252);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(174, 20);
            this.txtClave.TabIndex = 4;
            // 
            // btnModAsig
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnModAsig, 2);
            this.btnModAsig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModAsig.Location = new System.Drawing.Point(183, 279);
            this.btnModAsig.Name = "btnModAsig";
            this.btnModAsig.Size = new System.Drawing.Size(174, 38);
            this.btnModAsig.TabIndex = 7;
            this.btnModAsig.Text = "Actualizar";
            this.btnModAsig.UseVisualStyleBackColor = true;
            this.btnModAsig.Click += new System.EventHandler(this.btnModAsig_Click);
            // 
            // ModAsignaturaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 339);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ModAsignaturaForm";
            this.Text = "Modificar Asignatura";
            this.Load += new System.EventHandler(this.ModAsignaturaForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCreditos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCreditos;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Button btnModAsig;
    }
}

namespace CRUD_CSV_2019
{
    partial class frmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLeerCSV = new System.Windows.Forms.Button();
            this.btnModificarCSV = new System.Windows.Forms.Button();
            this.dgvCSV = new System.Windows.Forms.DataGridView();
            this.btnCrearCSV = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCSV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLeerCSV
            // 
            this.btnLeerCSV.Location = new System.Drawing.Point(987, 284);
            this.btnLeerCSV.Name = "btnLeerCSV";
            this.btnLeerCSV.Size = new System.Drawing.Size(75, 23);
            this.btnLeerCSV.TabIndex = 2;
            this.btnLeerCSV.Text = "Leer";
            this.btnLeerCSV.UseVisualStyleBackColor = true;
            this.btnLeerCSV.Click += new System.EventHandler(this.BtnLeerCSV_Click);
            // 
            // btnModificarCSV
            // 
            this.btnModificarCSV.Location = new System.Drawing.Point(987, 366);
            this.btnModificarCSV.Name = "btnModificarCSV";
            this.btnModificarCSV.Size = new System.Drawing.Size(75, 23);
            this.btnModificarCSV.TabIndex = 3;
            this.btnModificarCSV.Text = "Modificar";
            this.btnModificarCSV.UseVisualStyleBackColor = true;
            this.btnModificarCSV.Click += new System.EventHandler(this.btnModificarCSV_Click);
            // 
            // dgvCSV
            // 
            this.dgvCSV.AllowUserToDeleteRows = false;
            this.dgvCSV.AllowUserToOrderColumns = true;
            this.dgvCSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCSV.Location = new System.Drawing.Point(398, 13);
            this.dgvCSV.Name = "dgvCSV";
            this.dgvCSV.ReadOnly = true;
            this.dgvCSV.Size = new System.Drawing.Size(533, 505);
            this.dgvCSV.TabIndex = 5;
            // 
            // btnCrearCSV
            // 
            this.btnCrearCSV.Location = new System.Drawing.Point(987, 209);
            this.btnCrearCSV.Name = "btnCrearCSV";
            this.btnCrearCSV.Size = new System.Drawing.Size(75, 23);
            this.btnCrearCSV.TabIndex = 1;
            this.btnCrearCSV.Text = "Crear";
            this.btnCrearCSV.UseVisualStyleBackColor = true;
            this.btnCrearCSV.Click += new System.EventHandler(this.btnCrearCSV_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(987, 442);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtArchivo
            // 
            this.txtArchivo.Location = new System.Drawing.Point(12, 12);
            this.txtArchivo.Multiline = true;
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(380, 506);
            this.txtArchivo.TabIndex = 6;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 530);
            this.Controls.Add(this.txtArchivo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCrearCSV);
            this.Controls.Add(this.dgvCSV);
            this.Controls.Add(this.btnModificarCSV);
            this.Controls.Add(this.btnLeerCSV);
            this.Name = "frmInicio";
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLeerCSV;
        private System.Windows.Forms.Button btnModificarCSV;
        private System.Windows.Forms.DataGridView dgvCSV;
        private System.Windows.Forms.Button btnCrearCSV;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtArchivo;
    }
}


namespace practica_Clase1
{
    partial class frmFacturar
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
            this.dgv_detalle = new System.Windows.Forms.DataGridView();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_precio_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_precio_tot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_detalle
            // 
            this.dgv_detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.col_desc,
            this.col_cant,
            this.col_precio_unit,
            this.col_precio_tot});
            this.dgv_detalle.Location = new System.Drawing.Point(102, 202);
            this.dgv_detalle.Name = "dgv_detalle";
            this.dgv_detalle.RowHeadersVisible = false;
            this.dgv_detalle.Size = new System.Drawing.Size(553, 207);
            this.dgv_detalle.TabIndex = 1;
            this.dgv_detalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_detalle_CellContentClick);
            this.dgv_detalle.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_detalle_CellEndEdit);
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(77, 35);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(607, 150);
            this.dgvProductos.TabIndex = 2;
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "Código";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // col_desc
            // 
            this.col_desc.HeaderText = "Descripcion";
            this.col_desc.Name = "col_desc";
            this.col_desc.Width = 210;
            // 
            // col_cant
            // 
            this.col_cant.HeaderText = "Cantidad";
            this.col_cant.Name = "col_cant";
            this.col_cant.Width = 80;
            // 
            // col_precio_unit
            // 
            this.col_precio_unit.HeaderText = "Precio Unitario";
            this.col_precio_unit.Name = "col_precio_unit";
            this.col_precio_unit.Width = 80;
            // 
            // col_precio_tot
            // 
            this.col_precio_tot.HeaderText = "Precio Total";
            this.col_precio_tot.Name = "col_precio_tot";
            this.col_precio_tot.Width = 80;
            // 
            // frmFacturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 450);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.dgv_detalle);
            this.Name = "frmFacturar";
            this.Text = "frmFacturar";
            this.Load += new System.EventHandler(this.frmFacturar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_detalle;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cant;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_precio_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_precio_tot;
    }
}
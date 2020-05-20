namespace practica_Clase1
{
    partial class frmEscogerProducto
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
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvSeleccionado = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlrUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlrTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IdProducto1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlrUnitario1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccionado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Add,
            this.IdProducto1,
            this.descripcion1,
            this.vlrUnitario1});
            this.dgvProductos.Location = new System.Drawing.Point(84, 94);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.Size = new System.Drawing.Size(589, 150);
            this.dgvProductos.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(684, 94);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(92, 35);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvSeleccionado
            // 
            this.dgvSeleccionado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeleccionado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.descripcion,
            this.vlrUnitario,
            this.cantidad,
            this.vlrTotal});
            this.dgvSeleccionado.Location = new System.Drawing.Point(84, 276);
            this.dgvSeleccionado.Name = "dgvSeleccionado";
            this.dgvSeleccionado.RowHeadersVisible = false;
            this.dgvSeleccionado.Size = new System.Drawing.Size(581, 162);
            this.dgvSeleccionado.TabIndex = 5;
            this.dgvSeleccionado.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSeleccionado_CellEndEdit);
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "Código";
            this.IdProducto.Name = "IdProducto";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            // 
            // vlrUnitario
            // 
            this.vlrUnitario.HeaderText = "Valor Unitario";
            this.vlrUnitario.Name = "vlrUnitario";
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // vlrTotal
            // 
            this.vlrTotal.HeaderText = "Valr Total";
            this.vlrTotal.Name = "vlrTotal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nuestro pedido a nombre de:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(319, 27);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 17);
            this.lblNombre.TabIndex = 7;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(460, 27);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(0, 13);
            this.lblCedula.TabIndex = 8;
            this.lblCedula.Visible = false;
            // 
            // Add
            // 
            this.Add.HeaderText = "";
            this.Add.Name = "Add";
            // 
            // IdProducto1
            // 
            this.IdProducto1.HeaderText = "Código";
            this.IdProducto1.Name = "IdProducto1";
            this.IdProducto1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IdProducto1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // descripcion1
            // 
            this.descripcion1.HeaderText = "Descripción";
            this.descripcion1.Name = "descripcion1";
            // 
            // vlrUnitario1
            // 
            this.vlrUnitario1.HeaderText = "Valor Unitario";
            this.vlrUnitario1.Name = "vlrUnitario1";
            // 
            // frmEscogerProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSeleccionado);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvProductos);
            this.Name = "frmEscogerProducto";
            this.Text = "frmEscogerProducto";
            this.Load += new System.EventHandler(this.frmEscogerProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccionado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvSeleccionado;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlrUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlrTotal;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblNombre;
        public System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Add;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlrUnitario1;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace practica_Clase1
{
    public partial class frmFacturar : Form
    {
        int cantidad = 0;
        decimal precio_unit = 0;
        decimal precio_total = 0;
        SqlConnection cn;
        public frmFacturar()
        {
           
            InitializeComponent();
            cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\ESCRITORIO\\MEMORIANEGRA\\POO\\PRACTICA_CLASE1\\PRACTICA_CLASE1\\EMPRESA.MDF;Integrated Security=True;Connect Timeout=30");
            llenarProductos();
        }

        private void frmFacturar_Load(object sender, EventArgs e)
        {

        }

        void llenarProductos()
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select * From tblProducto  ", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                dgvProductos.DataSource = dt;
            }
            cn.Close();
   
        }



        private void dgv_detalle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            cn.Open();
            if (dgv_detalle.Columns[e.ColumnIndex].Name == "IdProducto")
            {
               
                //consulta el producto en la tabla y la compara con el txt del formulario
                SqlCommand cmd = new SqlCommand("Select * From tblProducto  where IdProducto ='" 
                    + dgv_detalle.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", cn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    dgv_detalle.Rows[e.RowIndex].Cells[1].Value = (Convert.ToString(dr["descripcion"]));
                    dgv_detalle.Rows[e.RowIndex].Cells[3].Value = (Convert.ToString(dr["vlrUnitario"]));
                }
                else
                {
                    MessageBox.Show("El producto no existe");
                    dgv_detalle.Rows[e.RowIndex].Cells[0].Value="";
                    
                }
            }



            if (dgv_detalle.Columns[e.ColumnIndex].Name == "col_cant")
            {
                try
                {
                    cantidad = int.Parse(dgv_detalle.Rows[e.RowIndex].Cells[2].Value.ToString());
                    precio_unit = int.Parse(dgv_detalle.Rows[e.RowIndex].Cells[3].Value.ToString());

                }
                catch (Exception)
                {
                    MessageBox.Show("Debe ingresar una cantidad!");
                }
                
                if ((cantidad != 0) || !(dgv_detalle.Rows[e.RowIndex].Cells[2].Value.Equals(""))) 
                {
                    precio_total = cantidad * precio_unit; 
                    dgv_detalle.Rows[e.RowIndex].Cells[4].Value  = precio_total;
                }
                else
                {
                    MessageBox.Show("Debe ingresar una cantidad!");
                }
            }
            cn.Close();
        }

        private void dgv_detalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

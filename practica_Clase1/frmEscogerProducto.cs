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
    public partial class frmEscogerProducto : Form
    {
        SqlConnection cn;
        int sw = 0;
        public frmEscogerProducto()
        {
            InitializeComponent();
            cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\ESCRITORIO\\MEMORIANEGRA\\POO\\PRACTICA_CLASE1\\PRACTICA_CLASE1\\EMPRESA.MDF;Integrated Security=True;Connect Timeout=30");
            llenarProductos();
        }

        private void frmEscogerProducto_Load(object sender, EventArgs e)
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
                //insertar tantas filas como tenga el resultado de la consulta
                int numero = dt.Rows.Count;
                dgvProductos.Rows.Add(numero-1);
                //
                for (int i=0;i< dt.Rows.Count;i++)
                {
                    dgvProductos.Rows[i].Cells[1].Value = dt.Rows[i][0].ToString();
                    dgvProductos.Rows[i].Cells[2].Value = dt.Rows[i][1].ToString();
                    dgvProductos.Rows[i].Cells[3].Value = dt.Rows[i][2].ToString();
                   
                }
               
            }
            cn.Close();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["Add"].Value);
                if (isSelected)
                {
     
                        int n = dgvSeleccionado.Rows.Add();
                        dgvSeleccionado.Rows[n].Cells[0].Value = row.Cells[1].Value.ToString();
                        dgvSeleccionado.Rows[n].Cells[1].Value = row.Cells[2].Value.ToString();
                        dgvSeleccionado.Rows[n].Cells[2].Value = row.Cells[3].Value.ToString();
                      
                    }
                    
                }
            }

        private void dgvSeleccionado_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int cantidad=0, precio_unit=0, precio_total;
            if (dgvSeleccionado.Columns[e.ColumnIndex].Name == "cantidad")
            {
                try
                {

                    cantidad = int.Parse(dgvSeleccionado.Rows[e.RowIndex].Cells[3].Value.ToString());
                    precio_unit = int.Parse(dgvSeleccionado.Rows[e.RowIndex].Cells[2].Value.ToString());
                }
                catch (Exception)
                {
                    MessageBox.Show("Debe ingresar una cantidad!");
                }

                if ((cantidad!= 0) && !(dgvSeleccionado.Rows[e.RowIndex].Cells[2].Value.Equals("")))
                {
                    precio_total = cantidad * precio_unit;
                    dgvSeleccionado.Rows[e.RowIndex].Cells[4].Value = precio_total;
                }
                else
                {
                    MessageBox.Show("Debe ingresar una cantidad!");
                }
            }
            
        }
    }

      
    }


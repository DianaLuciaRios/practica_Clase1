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
    public partial class frmEmpleado : Form
    {
        public SqlConnection cn;
        int i,count, boton;

        public frmEmpleado()
        {

            InitializeComponent();
            cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Escritorio\\MemoriaNegra\\POO\\practica_Clase1\\practica_Clase1\\Empresa.mdf;Integrated Security=True;Connect Timeout=30");
            //abre la conexion
            cn.Open();
            llenar();
            
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {

        }


        
        public void llenar()
        {
            SqlCommand cmd = new SqlCommand("Select * From tblEmpleado  ", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            txtCedula.Text = dt.Rows[i][0].ToString();
            txtNombre.Text = dt.Rows[i][1].ToString();
            txtDireccion.Text= dt.Rows[i][2].ToString();
            txtTelefono.Text= dt.Rows[i][3].ToString();
            count = dt.Rows.Count;
        }



        private void btnUltimo_Click(object sender, EventArgs e)
        {
            i = count-1;
            llenar();
        }



        private void tnAnterior_Click(object sender, EventArgs e)
        {
            i = i - 1;
            if(i==-1)
            {
                MessageBox.Show("LLegaste al primer registro");
                i = 0;
            }
            llenar();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            i = i + 1;
            if (i == count)
            {
                MessageBox.Show("LLegaste al ultimo registro");
                i = count-1;
            }
            llenar();
        }


        private void btnConsulta_Click(object sender, EventArgs e)
        {
            boton = 2;
            limpiar();
        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void txtCedula_Leave(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * From tblEmpleado  where cedula ='" + txtCedula.Text + "'", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (boton==1)
            {
                if(dt.Rows.Count!=0)
                {
                    MessageBox.Show("El Empleado ya existe");
                }
                
            }


            if (boton==2 || boton==3)
            {
                if (dt.Rows.Count != 0)
                {
                   txtCedula.Text = dt.Rows[0][0].ToString();
                   txtNombre.Text = dt.Rows[0][1].ToString();
                   txtDireccion.Text = dt.Rows[0][2].ToString();
                   txtTelefono.Text = dt.Rows[0][3].ToString();
                }
                else
                {
                    MessageBox.Show("El Empleado no existe");
                    limpiar();
                }
            }



            if(boton==4)
            {
                if (dt.Rows.Count != 0)
                {
                    txtCedula.Text = dt.Rows[0][0].ToString();
                    txtNombre.Text = dt.Rows[0][1].ToString();
                    txtDireccion.Text = dt.Rows[0][2].ToString();
                    txtTelefono.Text = dt.Rows[0][3].ToString();



                    var result = MessageBox.Show("Realmente desea borrarme ?", "Mensaje de Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);





                    if (result==DialogResult.Yes)
                    {
                        SqlCommand comando = new SqlCommand("delete tblEmpleado  where cedula ='" + txtCedula.Text + "'", cn);
                        comando.ExecuteNonQuery();
                    }
                }
                else
                {
                    MessageBox.Show("El Empleado no existe");
                }
            }
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            boton = 1;
            limpiar();
           

        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {
            boton = 3;
            limpiar();
        }

        private void btnRetiro_Click(object sender, EventArgs e)
        {
            boton = 4;
            limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(boton==1)
            {
                SqlCommand comando = new SqlCommand
                    ("insert into tblEmpleado  values('" + txtCedula.Text + "','" + txtNombre.Text + "','" + txtDireccion.Text + "','" + txtTelefono.Text + "' )", cn);
                comando.ExecuteNonQuery();
                MessageBox.Show("Empleado ingresado con exito");
            }
            if(boton==3)
            {
                SqlCommand comando = new SqlCommand("update tblEmpleado  set nombre ='" + txtNombre.Text + "',direccion ='" + txtDireccion.Text + "',telefono ='" + txtTelefono.Text + "'", cn);
                comando.ExecuteNonQuery();
                MessageBox.Show("Empleado modificado con exito");
            }
        }

        private void btnIraMercar_Click(object sender, EventArgs e)
        {
            frmEscogerProducto forma = new frmEscogerProducto();
            forma.lblNombre.Text = txtNombre.Text;
            forma.lblCedula.Text = txtCedula.Text;
            forma.Show();
        }

        void limpiar()
        {
            txtCedula.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCedula.Focus();
        }




        private void btnPrimero_Click(object sender, EventArgs e)
        {
            i = 0;
            llenar();
        }
    }
}

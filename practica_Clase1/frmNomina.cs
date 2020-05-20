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

    public partial class frmNomina : Form
    {
        SqlConnection cn;

        public frmNomina()
        {
            InitializeComponent();

            cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\ESCRITORIO\\MEMORIANEGRA\\POO\\PRACTICA_CLASE1\\PRACTICA_CLASE1\\EMPRESA.MDF;Integrated Security=True;Connect Timeout=30") ;
            //abre la conexion
            cn.Open();
        }





        private void cmbHorario_SelectedIndexChanged(object sender, EventArgs e)
        {
            Double NHT = Convert.ToDouble(txtNht.Text);
            Double salbash = Convert.ToDouble(txtSalbas.Text);
            Double salbruto,retefuente,segsocial,vlrExtras=0,subsidio = 0;
            Double totaldeven, totaldedu,salneto,hextras = 0;
            if(NHT>40)
            {
                hextras = NHT - 40;
                salbruto = salbash * 40;
                vlrExtras = hextras * salbash * 1.35;
                txtVlrExtras.Text = Convert.ToString(vlrExtras);
            }
            else
            {
                salbruto = NHT * salbash;
            }
            retefuente = salbruto * 0.1;
            txtRetefuente.Text = Convert.ToString(retefuente);
            segsocial = salbruto * 0.04;
            txtSeguridad.Text = Convert.ToString(segsocial);
            if (salbruto<900000)
            {
                subsidio = 100000;
                txtSubsidio.Text = Convert.ToString(subsidio);
            }
            txtSalBruto.Text = Convert.ToString(salbruto);
           
            if (cmbHorario.Text.Equals("Nocturno"))
            {
                salbruto = salbruto * 1.25;
            }
            totaldeven = salbruto + vlrExtras + subsidio;
            txtTotaldeven.Text = Convert.ToString(totaldeven);
            totaldedu = segsocial + retefuente;
            txtDeducciones.Text = Convert.ToString(totaldedu);
            salneto = totaldeven - totaldedu;
            txtSalNeto.Text = Convert.ToString(salneto);

        }

        private void frmNomina_Load(object sender, EventArgs e)
        {
            timer1.Start();
       
            txtFecha.Text = Convert.ToString(DateTime.Now.ToShortDateString());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNht_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtNht_Leave(object sender, EventArgs e)
        {
            
            if(Convert.ToInt32(txtNht.Text)>40)
            {
                txtExtras.Text = Convert.ToString
                    (Convert.ToDouble(txtNht.Text) - 40);
            }

            
        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCedula_Leave(object sender, EventArgs e)
        {
    
                //consulta la cedula en la tabla y la compara con el txt del formulario
                SqlCommand cmd = new SqlCommand("Select * From tblEmpleado  " +
                    "where cedula ='" + txtCedula.Text + "'", cn);

                
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtNombre.Text=(Convert.ToString(dr["nombre"]));

                }
                else
                {
                    MessageBox.Show("La cédula no existe");
                    txtCedula.Clear();
                    txtCedula.Focus();
                }
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           txtHora.Text = DateTime.Now.ToString("hh:mm:ss");
        }
    }
}

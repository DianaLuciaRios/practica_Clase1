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
    public partial class Form1 : Form
    {
        public SqlConnection cn;
        public Form1()
        {
            InitializeComponent();
            //cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=g:\\POO\\practica_Clase1\\practica_Clase1\\Empresa.mdf;Integrated Security=True;Connect Timeout=30");
            //cn.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            //SqlCommand cmd = new SqlCommand("Select nombre, telefono From tblEmpleado", cn);
            //SqlDataReader dr = cmd.ExecuteReader();
            //while (dr.Read() == true)
            //{
            //    listBox1.Items.Add(dr[0].ToString()+ "  ,  " + dr[1].ToString());
            //}


            dataGridView1.Rows[0].Cells[0].Value = 10;
            dataGridView1.Rows[0].Cells[1].Value = 200;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String valor = listBox1.SelectedItem.ToString();
    
            listBox2.Items.Add(listBox1.SelectedItem.ToString());
        }

        private void dataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows[0].Cells[2].Value = Convert.ToString(
               Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value) *
                Convert.ToInt32(dataGridView1.Rows[0].Cells[1].Value));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }
    }
}

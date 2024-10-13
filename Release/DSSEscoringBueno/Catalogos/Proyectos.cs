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
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DSSEscoringBueno.Catalogos
{
    public partial class Proyectos : Form
    {
        string conexion = "Data Source=JOSUECHIN\\JOSUECHINBD;Initial Catalog=\"DB_DSS\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public Proyectos()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
        
            // Conectar a la base de datos y ejecutar la consulta --- Eliminar todo se usara refernecia del backen 
            using (SqlConnection connection = new SqlConnection(conexion))
            {
                try
                {
                    // Abrir la conexión
                    connection.Open();

                    // Consulta SQL para obtener el último registro basado en el ID más alto
                    string query = "SELECT TOP 1 ID_Proy FROM Proyecto ORDER BY ID_Proy DESC";

                    // Crear el comando SQL
                    SqlCommand command = new SqlCommand(query, connection);

                    // Ejecutar la consulta y obtener el resultado
                    object result = command.ExecuteScalar();

                    // Verificar si se obtuvo algún resultado
                    if (result != null)
                    {
                        // Mostrar el nombre en textBox1
                        txtId.Text = result.ToString();
                    }
                    else
                    {
                        // Si no se encontró ningún registro
                        MessageBox.Show("No se encontró ningún registro.");
                    }
                }
                catch (Exception ex)
                {
                    // Manejar cualquier error de conexión o consulta
                    MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
                }
            }
        }

        private void Proyectos_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //incompleto --- Eliminar se tomara como referencia el backen
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("insert into Proyecto(Nombre_Proy,Objetivo_Proy) values ('" + txtNombre + "','" + txtObjetivo + "')", cn);
                cmd.CommandType = CommandType.Text;

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            
            {
                
            }
                
        }

        //abre el menu principal 
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea Cerrar la ventana anterior", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Form menuPrincipal = new MenuPrincipal();
                menuPrincipal.Show();
                this.Hide();
            }
            else
            {
                Form menuPrincipal = new MenuPrincipal();
                menuPrincipal.Show();
            }
        }

        private void Limpiar()
        {
            txtId.Text = "0";
            txtNombre.Text = "";
            txtObjetivo.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}

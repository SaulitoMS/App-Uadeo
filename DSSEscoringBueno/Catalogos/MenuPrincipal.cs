using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSSEscoringBueno.Catalogos
{
    public partial class MenuPrincipal : Form
    {
        
        public MenuPrincipal()
        {
            InitializeComponent();

            ComBoxCatalogos.Items.Add("Proyectos");
            ComBoxCatalogos.Items.Add("Alternativas");
            ComBoxCatalogos.Items.Add("Criterios");
            ComBoxCatalogos.Items.Add("Pesos");
            ComBoxCatalogos.Items.Add("Matriz");
            ComBoxCatalogos.Items.Add("Score");

            ComBoxCatalogos.SelectedIndexChanged += ComBoxCatalogos_SelectedIndexChanged;
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Variable para evitar múltiples aperturas de formularios
        private bool isFormOpened = false;

        // Método para verificar si un formulario ya está abierto
        private bool IsFormAlreadyOpen(Type formType)
        {
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm.GetType() == formType)
                {
                    return true; // Si ya está abierto, devuelve true
                }
            }
            return false; // Si no está abierto, devuelve false
        }

        private void ComBoxCatalogos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isFormOpened)
            {
                isFormOpened = true;

                int selectedIndex = ComBoxCatalogos.SelectedIndex;

                Form newForm = null;

                switch (selectedIndex)
                {
                    case 0:
                        if (IsFormAlreadyOpen(typeof(Proyectos)))
                        {
                            MessageBox.Show("El de Proyectos ya está abierto. No se puede abrir dos veces.");
                            return;
                        }
                        newForm = new Proyectos();
                        break;                  
                    //Copiese, peguese y editese como sea necesario 

                    default:
                        break;
                }
                if (newForm != null)
                {
                    isFormOpened = true;
                    newForm.Show();
                    this.Hide();
                }
            }
            

            
        }
    }
}

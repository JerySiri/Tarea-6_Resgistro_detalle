using Registro_Detalle.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Registro_Detalle.Entidades;

namespace Registro_Detalle.UI.Consulta
{
    public partial class cRolesForm : Form
    {
        public cRolesForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cRolesForm_Load(object sender, EventArgs e)
        {

        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {

            var lista = new List<Roles>();
            
            if (!string.IsNullOrWhiteSpace(CriterioTextBox.Text))
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0: //RolesId
                        lista = RolesBLL.GetList(r => r.RolId == Utilitarios.ToInt(CriterioTextBox.Text));
                        break;
                    case 1://Descripcion
                        lista = RolesBLL.GetList(r =>  r.Descripcion.Contains(CriterioTextBox.Text));
                        break;  
                }
            }
            else
            {
                lista = RolesBLL.GetList(r => true);
            }
            ConsultaRolesDataGridView.DataSource = null;
            ConsultaRolesDataGridView.DataSource = lista;
        }
    }
}

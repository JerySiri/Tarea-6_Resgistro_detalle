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

        private void BuscarButton_Click(object sender, EventArgs e)
        {

            var lista = new List<Roles>();


            if (!string.IsNullOrWhiteSpace(CriterioTextBox.Text))
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0://todos
                        if (ActivosRadioButton.Checked == true)
                        {
                            lista = RolesBLL.GetList(r => r.esActivo == true);
                        }
                        else if (InactivosRadioButton.Checked == true)
                        {
                            lista = RolesBLL.GetList(r => r.esActivo == false);
                        }
                        else
                        {
                            lista = RolesBLL.GetList(lista => true);
                        }
                        break;

                    case 1: //RolesId
                       
                        if (ActivosRadioButton.Checked == true)
                        {
                            lista = RolesBLL.GetList(r => r.RolId == Utilitarios.ToInt(CriterioTextBox.Text) && r.esActivo == true);
                        }
                        else if (InactivosRadioButton.Checked == true)
                        {
                            lista = RolesBLL.GetList(r => r.RolId == Utilitarios.ToInt(CriterioTextBox.Text) && r.esActivo == false );
                        }
                        else
                        {
                            lista = RolesBLL.GetList(r => r.RolId == Utilitarios.ToInt(CriterioTextBox.Text));
                        }                       
                        break;
                    case 2://Descripcion
                        if (ActivosRadioButton.Checked == true)
                        {
                            lista = RolesBLL.GetList(r => r.Descripcion.Contains(CriterioTextBox.Text)  && r.esActivo == true);
                        }
                        else if (InactivosRadioButton.Checked == true)
                        {
                            lista = RolesBLL.GetList(r => r.Descripcion.Contains(CriterioTextBox.Text) && r.esActivo == false);
                        }
                        else
                        {
                            lista = RolesBLL.GetList(r => r.Descripcion.Contains(CriterioTextBox.Text));
                        }
                        break;  
                }
            }
            else
            {
                if (ActivosRadioButton.Checked == true)
                {
                    lista = RolesBLL.GetList(r => r.esActivo == true);
                }
                else if (InactivosRadioButton.Checked == true)
                {
                    lista = RolesBLL.GetList(r => r.esActivo == false);
                }
                else
                {
                    lista = RolesBLL.GetList(lista => true);
                }

                
            }

            if(UsarFiltroFechascheckBox.Checked == true)
            {
                lista = lista.Where(c => c.FechaCreacion.Date >= DesdeDateTimePicker.Value.Date && c.FechaCreacion.Date <= HastaFechaDateTimePicker.Value.Date).ToList();
            }

            ConsultaRolesDataGridView.DataSource = null;
            ConsultaRolesDataGridView.DataSource = lista;
        }

        private void ImprimirButton_Click(object sender, EventArgs e)
        {
            var lista = new List<Roles>();
            if(lista.Count == 0)
            {
                MessageBox.Show("No hay datos que imprimir.", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cRolesForm_Load(object sender, EventArgs e)
        {
            // pone las fechas inactivas
            DesdeDateTimePicker.Enabled = false;
            HastaFechaDateTimePicker.Enabled = false;

            //selecciona desde el inicio el radioButton todos
            TodosRadioButton.Checked = true;

            FiltroComboBox.SelectedIndex = 0;
        }

        private void UsarFiltroFechascheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(UsarFiltroFechascheckBox.Checked == true)
            {
                DesdeDateTimePicker.Enabled = true;
                HastaFechaDateTimePicker.Enabled = true;
            }
            if(UsarFiltroFechascheckBox.Checked == false)
            {
                DesdeDateTimePicker.Enabled = false;
                HastaFechaDateTimePicker.Enabled = false;
            }
        }
    }
}

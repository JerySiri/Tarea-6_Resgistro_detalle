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
using Registro_Detalle.BLL;


namespace Registro_Detalle.UI.Consulta
{
    public partial class cUsuariosForm : Form
    {
        public cUsuariosForm()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            var lista = new List<Usuarios>();


            if (!string.IsNullOrWhiteSpace(CriterioTextBox.Text))
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0: //Todos
                        if (ActivosRadioButton.Checked == true)
                        {
                            lista = UsuariosBLL.GetList(r => r.Activo == true);
                        }
                        else if (InactivosRadioButton.Checked == true)
                        {
                            lista = UsuariosBLL.GetList(r => r.Activo == false);
                        }
                        else
                        {
                            lista = UsuariosBLL.GetList(lista => true);
                        }
                        break;

                    case 1: //Usuario Id
                        if (ActivosRadioButton.Checked == true)
                        {
                            lista = UsuariosBLL.GetList(u => u.UsuarioId == Utilitarios.ToInt(CriterioTextBox.Text) && u.Activo == true);
                        }
                        else if (InactivosRadioButton.Checked == true)
                        {
                            lista = UsuariosBLL.GetList(u => u.UsuarioId == Utilitarios.ToInt(CriterioTextBox.Text) && u.Activo == false);
                        }
                        else
                        {
                            lista = UsuariosBLL.GetList(u => u.UsuarioId == Utilitarios.ToInt(CriterioTextBox.Text));
                        }
                        break;
                    case 2://alias
                        if (ActivosRadioButton.Checked == true)
                        {
                            lista = UsuariosBLL.GetList(u => u.Alias.Contains(CriterioTextBox.Text) && u.Activo == true);
                            
                        }
                        else if (InactivosRadioButton.Checked == true)
                        {
                            lista = UsuariosBLL.GetList(u => u.Alias.Contains(CriterioTextBox.Text) && u.Activo == false);
                        }
                        else
                        {
                            lista = UsuariosBLL.GetList(u => u.Alias.Contains(CriterioTextBox.Text));
                        }
                        break;
                    case 3: //Nombre
                        if (ActivosRadioButton.Checked == true)
                        {
                            lista = UsuariosBLL.GetList(u => u.Nombre.Contains(CriterioTextBox.Text) && u.Activo == true);

                        }
                        else if (InactivosRadioButton.Checked == true)
                        {
                            lista = UsuariosBLL.GetList(u => u.Nombre.Contains(CriterioTextBox.Text) && u.Activo == false);
                        }
                        else
                        {
                            lista = UsuariosBLL.GetList(u => u.Nombre.Contains(CriterioTextBox.Text));
                        }
                        break;
                }
            }
            else
            {
                if (ActivosRadioButton.Checked == true)
                {
                    lista = UsuariosBLL.GetList(r => r.Activo == true);
                }
                else if (InactivosRadioButton.Checked == true)
                {
                    lista = UsuariosBLL.GetList(r => r.Activo == false);
                }
                else
                {
                    lista = UsuariosBLL.GetList(lista => true);
                }


            }

            if (UsarFiltroFechascheckBox.Checked == true)
            {
                lista = lista.Where(c => c.FechaIngreso.Date >= DesdeDateTimePicker.Value.Date && c.FechaIngreso.Date <= HastaFechaDateTimePicker.Value.Date).ToList();
            }

            ConsultaUsuariosDataGridView.DataSource = null;
            ConsultaUsuariosDataGridView.DataSource = lista;
        
        }

        private void ImprimirButton_Click(object sender, EventArgs e)
        {
            var lista = new List<Roles>();
            if (lista.Count == 0)
            {
                MessageBox.Show("No hay datos que imprimir.", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cUsuarios_Load(object sender, EventArgs e)
        {
            // pone las fechas inactivas
            DesdeDateTimePicker.Enabled = false;
            HastaFechaDateTimePicker.Enabled = false;

            //selecciona desde el inicio el radioButton todos
            TodosRadioButton.Checked = true;

            //lo posiciona en el primer indice 
            FiltroComboBox.SelectedIndex = 0;
        }

        private void UsarFiltroFechascheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (UsarFiltroFechascheckBox.Checked == true)
            {
                DesdeDateTimePicker.Enabled = true;
                HastaFechaDateTimePicker.Enabled = true;
            }
            if (UsarFiltroFechascheckBox.Checked == false)
            {
                DesdeDateTimePicker.Enabled = false;
                HastaFechaDateTimePicker.Enabled = false;
            }
        }
    }
}

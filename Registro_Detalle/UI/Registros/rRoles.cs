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


namespace Registro_Detalle.UI.Registros
{
    public partial class rRolesForm : Form
    {
        public List<RolesDetalle> RolDetalle { get; set; }
        public rRolesForm()
        {
            InitializeComponent();
            this.RolDetalle = new List<RolesDetalle>();
        }

        private void Limpiar()
        {
            RolesIdNumericUpDown.Value = 0;
            FechaCreacionDateTimePicker.Value = DateTime.Now;
            DescripcionTextBox.Clear();
            esActivoCheckBox.Checked = false;

            PermisosComboBox.SelectedIndex = 0;
            esAsignadoCheckBox.Checked = false;
            this.RolDetalle = new List<RolesDetalle>();
            CargarGrid();
        }
        private void CargarGrid()
        {
            RolesDetalleDataGridView.DataSource = null;
            RolesDetalleDataGridView.DataSource = this.RolDetalle;
        }

        private Roles LlenarClase()
        {
            Roles rol = new Roles();
            rol.RolId = (int)RolesIdNumericUpDown.Value;
            rol.Descripcion = DescripcionTextBox.Text;
            rol.FechaCreacion = FechaCreacionDateTimePicker.Value;
            rol.esActivo = esActivoCheckBox.Checked;

            rol.RolesDetalle = this.RolDetalle;

            return rol;
        }

        private void LlenarCampos(Roles rol)
        {
            RolesIdNumericUpDown.Value = rol.RolId;
            DescripcionTextBox.Text = rol.Descripcion;
            FechaCreacionDateTimePicker.Value = rol.FechaCreacion;
            esActivoCheckBox.Checked = rol.esActivo;

            this.RolDetalle = rol.RolesDetalle;
        }

        private bool Validar()
        {
            bool paso = true;

            MyErrorProvider.Clear();

            if (DescripcionTextBox.Text == String.Empty)
            {
                MyErrorProvider.SetError(DescripcionTextBox, "El Campo nombre no puede estar vacio");
                DescripcionTextBox.Focus();
                paso = false;
            }

            if ( RolesIdNumericUpDown.Value == 0)
            {
                MyErrorProvider.SetError(RolesIdNumericUpDown, "No se puede guardar ningun campo con valor 0");
                RolesIdNumericUpDown.Focus();
                paso = false;
            }

            if (PermisosBLL.ExisteDescripcion(DescripcionTextBox.Text, (int)RolesIdNumericUpDown.Value))
            {
                MyErrorProvider.SetError(DescripcionTextBox, "El Campo Descripcion no puede estar vacio");
                DescripcionTextBox.Focus();
                paso = false;
            }
            
            if (this.RolDetalle.Count == 0)
            {
                MyErrorProvider.SetError(RolesDetalleGroupBox, "Debes Agregar un telefono");
                RolesDetalleGroupBox.Focus();
                paso = false;
            }

            return paso;
        }

        private void rRolesForm_Load(object sender, EventArgs e)
        {
            PermisosComboBox.DataSource = PermisosBLL.GetRoles();
            PermisosComboBox.DisplayMember = "Descripcion";
            PermisosComboBox.ValueMember = "PermisoId";
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Roles roles = RolesBLL.Buscar((int)RolesIdNumericUpDown.Value);

            if (roles != null)
            {
                LlenarCampos(roles);
                CargarGrid();
            }    
            else
                MessageBox.Show("Usuario No existe.", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            if (RolesDetalleDataGridView.DataSource != null)
                this.RolDetalle = (List<RolesDetalle>)RolesDetalleDataGridView.DataSource;

            this.RolDetalle.Add(new RolesDetalle
                (
                    Id: 0,
                    RolId: (int)RolesIdNumericUpDown.Value,
                    PermisoId: (int)PermisosComboBox.SelectedIndex + 1,
                    esAsignado: esAsignadoCheckBox.Checked
                )
            );

            Permisos permiso = PermisosBLL.Buscar((int)PermisosComboBox.SelectedIndex + 1);
            permiso.VecesAsignado = ++permiso.VecesAsignado;

            if(!PermisosBLL.Guardar(permiso))
                MessageBox.Show("Erro al cambian cantidad de veces asignada de permisos!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            CargarGrid();
        }

        private void RemoverButton_Click(object sender, EventArgs e)
        {
            if (RolesDetalleDataGridView.Rows.Count > 0 || RolesDetalleDataGridView.CurrentRow != null)
            {
                RolDetalle.RemoveAt(RolesDetalleDataGridView.CurrentRow.Index);
                
                CargarGrid();
            }
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Roles rol;

            if (!Validar())
                return;

            rol = LlenarClase();

            var paso = RolesBLL.Guardar(rol);

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Transaccione exitosa!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Transaccion fallida!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (RolesBLL.Eliminar((int)RolesIdNumericUpDown.Value))
            {
                Limpiar();
                MessageBox.Show("Transaccione exitosa!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No pudo ser eliminado", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}

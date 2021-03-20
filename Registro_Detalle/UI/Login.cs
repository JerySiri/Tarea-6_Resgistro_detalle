using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Registro_Detalle.UI;
using Registro_Detalle.BLL;

namespace Registro_Detalle.UI
{
    public partial class Login : Form
    {
        

        public Login()
        {
            InitializeComponent();
            
        }
        Form menu = new MenuForm();

        private void IniciarSesionButton_Click(object sender, EventArgs e)
        {
            bool paso = UsuariosBLL.Validar(AliasTextBox .Text, ClaveTextBox.Text);

            if (paso)
            {
                this.Hide();
                menu.ShowDialog();
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Error Nombre Usuario o Clave incorrecta!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                MyErrorProvider.SetError(AliasTextBox, "Error Nombre Usuario o Clave incorrecta");
                
                AliasTextBox.Focus();
                ClaveTextBox.Clear();

            }
        }
    }
}

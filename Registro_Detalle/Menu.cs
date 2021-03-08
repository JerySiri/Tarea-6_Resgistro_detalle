﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Registro_Detalle.UI.Registros;
using Registro_Detalle.UI.Consulta;
namespace Registro_Detalle
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            this.rRolesToolStripMenuItem.Click += new EventHandler(this.rRolesToolStripMenuItem_ItemClicked);
            this.cRolesToolStripMenuItem1.Click += new EventHandler(this.cRolesToolStripMenuItem_ItemClicked);
        }

        private void rRolesToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var rRoles = new rRolesForm();
            rRoles.MdiParent = this;
            rRoles.Show();
        }

        private void cRolesToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var cRoles = new cRolesForm();
            cRoles.MdiParent = this;
            cRoles.Show();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}

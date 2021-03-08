
namespace Registro_Detalle
{
    partial class MenuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rRolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AyudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRolesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArchivoToolStripMenuItem,
            this.EditarToolStripMenuItem,
            this.RegistroToolStripMenuItem,
            this.ConsultaToolStripMenuItem,
            this.AyudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ArchivoToolStripMenuItem
            // 
            this.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem";
            this.ArchivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.ArchivoToolStripMenuItem.Text = "&Archivo";
            // 
            // EditarToolStripMenuItem
            // 
            this.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem";
            this.EditarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.EditarToolStripMenuItem.Text = "&Editar";
            // 
            // RegistroToolStripMenuItem
            // 
            this.RegistroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rRolesToolStripMenuItem});
            this.RegistroToolStripMenuItem.Name = "RegistroToolStripMenuItem";
            this.RegistroToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.RegistroToolStripMenuItem.Text = "&Registro";
            // 
            // rRolesToolStripMenuItem
            // 
            this.rRolesToolStripMenuItem.Name = "rRolesToolStripMenuItem";
            this.rRolesToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.rRolesToolStripMenuItem.Text = "Registro de Roles";
            // 
            // ConsultaToolStripMenuItem
            // 
            this.ConsultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cRolesToolStripMenuItem1});
            this.ConsultaToolStripMenuItem.Name = "ConsultaToolStripMenuItem";
            this.ConsultaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.ConsultaToolStripMenuItem.Text = "&Consulta";
            // 
            // AyudaToolStripMenuItem
            // 
            this.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem";
            this.AyudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.AyudaToolStripMenuItem.Text = "&Ayuda";
            // 
            // cRolesToolStripMenuItem1
            // 
            this.cRolesToolStripMenuItem1.Name = "cRolesToolStripMenuItem1";
            this.cRolesToolStripMenuItem1.Size = new System.Drawing.Size(169, 22);
            this.cRolesToolStripMenuItem1.Text = "&Consulta De Roles";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuForm";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RegistroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rRolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConsultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AyudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cRolesToolStripMenuItem1;
    }
}



namespace Registro_Detalle.UI.Registros
{
    partial class rRolesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rRolesForm));
            this.RolesIdLabel = new System.Windows.Forms.Label();
            this.DescripcionLabel = new System.Windows.Forms.Label();
            this.RolesIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.esActivoCheckBox = new System.Windows.Forms.CheckBox();
            this.RolesDetalleGroupBox = new System.Windows.Forms.GroupBox();
            this.RolesDetalleDataGridView = new System.Windows.Forms.DataGridView();
            this.RemoverButton = new System.Windows.Forms.Button();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.esAsignadoCheckBox = new System.Windows.Forms.CheckBox();
            this.PermisosComboBox = new System.Windows.Forms.ComboBox();
            this.PermisosLabel = new System.Windows.Forms.Label();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RolesIdNumericUpDown)).BeginInit();
            this.RolesDetalleGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RolesDetalleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // RolesIdLabel
            // 
            this.RolesIdLabel.AutoSize = true;
            this.RolesIdLabel.Location = new System.Drawing.Point(15, 21);
            this.RolesIdLabel.Name = "RolesIdLabel";
            this.RolesIdLabel.Size = new System.Drawing.Size(18, 15);
            this.RolesIdLabel.TabIndex = 0;
            this.RolesIdLabel.Text = "ID";
            // 
            // DescripcionLabel
            // 
            this.DescripcionLabel.AutoSize = true;
            this.DescripcionLabel.Location = new System.Drawing.Point(15, 48);
            this.DescripcionLabel.Name = "DescripcionLabel";
            this.DescripcionLabel.Size = new System.Drawing.Size(69, 15);
            this.DescripcionLabel.TabIndex = 2;
            this.DescripcionLabel.Text = "Descripción";
            // 
            // RolesIdNumericUpDown
            // 
            this.RolesIdNumericUpDown.Location = new System.Drawing.Point(90, 16);
            this.RolesIdNumericUpDown.Name = "RolesIdNumericUpDown";
            this.RolesIdNumericUpDown.Size = new System.Drawing.Size(112, 23);
            this.RolesIdNumericUpDown.TabIndex = 3;
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(90, 45);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(366, 23);
            this.DescripcionTextBox.TabIndex = 5;
            // 
            // esActivoCheckBox
            // 
            this.esActivoCheckBox.AutoSize = true;
            this.esActivoCheckBox.Location = new System.Drawing.Point(398, 19);
            this.esActivoCheckBox.Name = "esActivoCheckBox";
            this.esActivoCheckBox.Size = new System.Drawing.Size(60, 19);
            this.esActivoCheckBox.TabIndex = 6;
            this.esActivoCheckBox.Text = "Activo";
            this.esActivoCheckBox.UseVisualStyleBackColor = true;
            // 
            // RolesDetalleGroupBox
            // 
            this.RolesDetalleGroupBox.Controls.Add(this.RolesDetalleDataGridView);
            this.RolesDetalleGroupBox.Controls.Add(this.RemoverButton);
            this.RolesDetalleGroupBox.Controls.Add(this.AgregarButton);
            this.RolesDetalleGroupBox.Controls.Add(this.esAsignadoCheckBox);
            this.RolesDetalleGroupBox.Controls.Add(this.PermisosComboBox);
            this.RolesDetalleGroupBox.Controls.Add(this.PermisosLabel);
            this.RolesDetalleGroupBox.Location = new System.Drawing.Point(13, 76);
            this.RolesDetalleGroupBox.Name = "RolesDetalleGroupBox";
            this.RolesDetalleGroupBox.Size = new System.Drawing.Size(443, 263);
            this.RolesDetalleGroupBox.TabIndex = 7;
            this.RolesDetalleGroupBox.TabStop = false;
            this.RolesDetalleGroupBox.Text = "Roles Detalle";
            // 
            // RolesDetalleDataGridView
            // 
            this.RolesDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RolesDetalleDataGridView.Location = new System.Drawing.Point(7, 52);
            this.RolesDetalleDataGridView.Name = "RolesDetalleDataGridView";
            this.RolesDetalleDataGridView.RowTemplate.Height = 25;
            this.RolesDetalleDataGridView.Size = new System.Drawing.Size(428, 169);
            this.RolesDetalleDataGridView.TabIndex = 5;
            // 
            // RemoverButton
            // 
            this.RemoverButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoverButton.Image")));
            this.RemoverButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoverButton.Location = new System.Drawing.Point(7, 227);
            this.RemoverButton.Name = "RemoverButton";
            this.RemoverButton.Size = new System.Drawing.Size(82, 23);
            this.RemoverButton.TabIndex = 4;
            this.RemoverButton.Text = "Remover";
            this.RemoverButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoverButton.UseVisualStyleBackColor = true;
            this.RemoverButton.Click += new System.EventHandler(this.RemoverButton_Click);
            // 
            // AgregarButton
            // 
            this.AgregarButton.Image = ((System.Drawing.Image)(resources.GetObject("AgregarButton.Image")));
            this.AgregarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AgregarButton.Location = new System.Drawing.Point(351, 22);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(84, 23);
            this.AgregarButton.TabIndex = 3;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // esAsignadoCheckBox
            // 
            this.esAsignadoCheckBox.AutoSize = true;
            this.esAsignadoCheckBox.Location = new System.Drawing.Point(217, 26);
            this.esAsignadoCheckBox.Name = "esAsignadoCheckBox";
            this.esAsignadoCheckBox.Size = new System.Drawing.Size(76, 19);
            this.esAsignadoCheckBox.TabIndex = 2;
            this.esAsignadoCheckBox.Text = "Asignado";
            this.esAsignadoCheckBox.UseVisualStyleBackColor = true;
            // 
            // PermisosComboBox
            // 
            this.PermisosComboBox.FormattingEnabled = true;
            this.PermisosComboBox.Location = new System.Drawing.Point(74, 23);
            this.PermisosComboBox.Name = "PermisosComboBox";
            this.PermisosComboBox.Size = new System.Drawing.Size(121, 23);
            this.PermisosComboBox.TabIndex = 1;
            // 
            // PermisosLabel
            // 
            this.PermisosLabel.AutoSize = true;
            this.PermisosLabel.Location = new System.Drawing.Point(7, 26);
            this.PermisosLabel.Name = "PermisosLabel";
            this.PermisosLabel.Size = new System.Drawing.Size(50, 15);
            this.PermisosLabel.TabIndex = 0;
            this.PermisosLabel.Text = "Permiso";
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButton.Image")));
            this.BuscarButton.Location = new System.Drawing.Point(208, 16);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(37, 23);
            this.BuscarButton.TabIndex = 8;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoButton.Image")));
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NuevoButton.Location = new System.Drawing.Point(270, 345);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(75, 47);
            this.NuevoButton.TabIndex = 9;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButton.Image")));
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarButton.Location = new System.Drawing.Point(190, 345);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 47);
            this.GuardarButton.TabIndex = 10;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarButton.Image")));
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarButton.Location = new System.Drawing.Point(110, 345);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(75, 47);
            this.EliminarButton.TabIndex = 11;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // rRolesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 404);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.RolesDetalleGroupBox);
            this.Controls.Add(this.esActivoCheckBox);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.RolesIdNumericUpDown);
            this.Controls.Add(this.DescripcionLabel);
            this.Controls.Add(this.RolesIdLabel);
            this.Name = "rRolesForm";
            this.Text = "Registros De Roles";
            this.Load += new System.EventHandler(this.rRolesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RolesIdNumericUpDown)).EndInit();
            this.RolesDetalleGroupBox.ResumeLayout(false);
            this.RolesDetalleGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RolesDetalleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RolesIdLabel;
        private System.Windows.Forms.Label DescripcionLabel;
        private System.Windows.Forms.NumericUpDown RolesIdNumericUpDown;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.CheckBox esActivoCheckBox;
        private System.Windows.Forms.GroupBox RolesDetalleGroupBox;
        private System.Windows.Forms.DataGridView RolesDetalleDataGridView;
        private System.Windows.Forms.Button RemoverButton;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.CheckBox esAsignadoCheckBox;
        private System.Windows.Forms.ComboBox PermisosComboBox;
        private System.Windows.Forms.Label PermisosLabel;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}
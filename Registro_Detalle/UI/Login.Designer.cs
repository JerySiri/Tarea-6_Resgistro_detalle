
namespace Registro_Detalle.UI
{
    partial class Login
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
            this.AliasLabel = new System.Windows.Forms.Label();
            this.AliasTextBox = new System.Windows.Forms.TextBox();
            this.ClaveTextBox = new System.Windows.Forms.TextBox();
            this.ClaveLabel = new System.Windows.Forms.Label();
            this.IniciarSesionButton = new System.Windows.Forms.Button();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // AliasLabel
            // 
            this.AliasLabel.AutoSize = true;
            this.AliasLabel.Location = new System.Drawing.Point(12, 13);
            this.AliasLabel.Name = "AliasLabel";
            this.AliasLabel.Size = new System.Drawing.Size(32, 15);
            this.AliasLabel.TabIndex = 0;
            this.AliasLabel.Text = "Alias";
            // 
            // AliasTextBox
            // 
            this.AliasTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AliasTextBox.Location = new System.Drawing.Point(13, 32);
            this.AliasTextBox.Name = "AliasTextBox";
            this.AliasTextBox.Size = new System.Drawing.Size(217, 23);
            this.AliasTextBox.TabIndex = 1;
            // 
            // ClaveTextBox
            // 
            this.ClaveTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ClaveTextBox.Location = new System.Drawing.Point(13, 78);
            this.ClaveTextBox.Name = "ClaveTextBox";
            this.ClaveTextBox.Size = new System.Drawing.Size(219, 23);
            this.ClaveTextBox.TabIndex = 3;
            this.ClaveTextBox.UseSystemPasswordChar = true;
            // 
            // ClaveLabel
            // 
            this.ClaveLabel.AutoSize = true;
            this.ClaveLabel.Location = new System.Drawing.Point(12, 59);
            this.ClaveLabel.Name = "ClaveLabel";
            this.ClaveLabel.Size = new System.Drawing.Size(36, 15);
            this.ClaveLabel.TabIndex = 2;
            this.ClaveLabel.Text = "Clave";
            // 
            // IniciarSesionButton
            // 
            this.IniciarSesionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.IniciarSesionButton.Location = new System.Drawing.Point(11, 117);
            this.IniciarSesionButton.Name = "IniciarSesionButton";
            this.IniciarSesionButton.Size = new System.Drawing.Size(219, 34);
            this.IniciarSesionButton.TabIndex = 4;
            this.IniciarSesionButton.Text = "Iniciar Sesión";
            this.IniciarSesionButton.UseVisualStyleBackColor = true;
            this.IniciarSesionButton.Click += new System.EventHandler(this.IniciarSesionButton_Click);
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 164);
            this.Controls.Add(this.IniciarSesionButton);
            this.Controls.Add(this.ClaveTextBox);
            this.Controls.Add(this.ClaveLabel);
            this.Controls.Add(this.AliasTextBox);
            this.Controls.Add(this.AliasLabel);
            this.MinimumSize = new System.Drawing.Size(262, 203);
            this.Name = "Login";
            this.Text = "Inicio De Sesión";
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AliasLabel;
        private System.Windows.Forms.TextBox AliasTextBox;
        private System.Windows.Forms.TextBox ClaveTextBox;
        private System.Windows.Forms.Label ClaveLabel;
        private System.Windows.Forms.Button IniciarSesionButton;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}
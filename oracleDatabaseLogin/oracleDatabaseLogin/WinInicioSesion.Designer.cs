//skin de material design

using MaterialSkin;
using MaterialSkin.Controls;
using System.Drawing;


//conexion base de datos

namespace oracleDatabaseLogin
{
    partial class WinInicioSesion:MaterialForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        


        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnIngresar = new MaterialSkin.Controls.MaterialFlatButton();
            this.BtnRegistrarse = new MaterialSkin.Controls.MaterialFlatButton();
            this.TxtUserName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.AutoSize = true;
            this.BtnIngresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnIngresar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnIngresar.Depth = 0;
            this.BtnIngresar.Icon = null;
            this.BtnIngresar.Location = new System.Drawing.Point(180, 307);
            this.BtnIngresar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnIngresar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Primary = false;
            this.BtnIngresar.Size = new System.Drawing.Size(86, 36);
            this.BtnIngresar.TabIndex = 1;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // BtnRegistrarse
            // 
            this.BtnRegistrarse.AutoSize = true;
            this.BtnRegistrarse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnRegistrarse.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnRegistrarse.Depth = 0;
            this.BtnRegistrarse.Icon = null;
            this.BtnRegistrarse.Location = new System.Drawing.Point(168, 376);
            this.BtnRegistrarse.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnRegistrarse.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnRegistrarse.Name = "BtnRegistrarse";
            this.BtnRegistrarse.Primary = false;
            this.BtnRegistrarse.Size = new System.Drawing.Size(109, 36);
            this.BtnRegistrarse.TabIndex = 2;
            this.BtnRegistrarse.Text = "Registrarse";
            this.BtnRegistrarse.UseVisualStyleBackColor = false;
            this.BtnRegistrarse.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // TxtUserName
            // 
            this.TxtUserName.BackColor = System.Drawing.SystemColors.Info;
            this.TxtUserName.Depth = 0;
            this.TxtUserName.Hint = "";
            this.TxtUserName.Location = new System.Drawing.Point(127, 167);
            this.TxtUserName.MaxLength = 32767;
            this.TxtUserName.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.PasswordChar = '\0';
            this.TxtUserName.SelectedText = "";
            this.TxtUserName.SelectionLength = 0;
            this.TxtUserName.SelectionStart = 0;
            this.TxtUserName.Size = new System.Drawing.Size(193, 23);
            this.TxtUserName.TabIndex = 3;
            this.TxtUserName.TabStop = false;
            this.TxtUserName.UseSystemPasswordChar = true;
            // 
            // TxtPassword
            // 
            this.TxtPassword.BackColor = System.Drawing.SystemColors.Info;
            this.TxtPassword.Depth = 0;
            this.TxtPassword.Hint = "";
            this.TxtPassword.Location = new System.Drawing.Point(127, 275);
            this.TxtPassword.MaxLength = 32767;
            this.TxtPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '\0';
            this.TxtPassword.SelectedText = "";
            this.TxtPassword.SelectionLength = 0;
            this.TxtPassword.SelectionStart = 0;
            this.TxtPassword.Size = new System.Drawing.Size(193, 23);
            this.TxtPassword.TabIndex = 4;
            this.TxtPassword.TabStop = false;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(123, 120);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(61, 19);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "Usuario";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(123, 233);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(46, 19);
            this.materialLabel2.TabIndex = 8;
            this.materialLabel2.Text = "Clave";
            this.materialLabel2.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // WinInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(452, 450);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.BtnRegistrarse);
            this.Controls.Add(this.BtnIngresar);
            this.Name = "WinInicioSesion";
            this.Text = "Inicio de Sesion";
            this.Load += new System.EventHandler(this.WinInicioSesion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialFlatButton BtnIngresar;
        private MaterialFlatButton BtnRegistrarse;
        private MaterialSingleLineTextField TxtUserName;
        private MaterialSingleLineTextField TxtPassword;
        private MaterialLabel materialLabel1;
        private MaterialLabel materialLabel2;
    }
}


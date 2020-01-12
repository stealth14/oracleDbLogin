using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//skin de material design

using MaterialSkin;
using MaterialSkin.Controls;
using System.Drawing;

namespace oracleDatabaseLogin
{
    public partial class WinAreaPrincipal : MaterialForm
    {

        //material skin manager
        public MaterialSkinManager materialSkinManager;
        public WinAreaPrincipal()
        {
            InitializeComponent();

            ///inicializa skin manager
            this.materialSkinManager = MaterialSkinManager.Instance;

            //agrega manager a instancia de la forma
            this.materialSkinManager.AddFormToManage(this);

            //establece tema principal
            this.materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            //establece esquema de colores para controles
            this.materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {

            WinInicioSesion inicio = new WinInicioSesion();

            inicio.Show();

            this.Close();

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using MaterialSkin;
using MaterialSkin.Controls;

namespace oracleDatabaseLogin
{
    public partial class WinInicioSesion : MaterialForm
    {
        public MaterialSkinManager materialSkinManager;


        public WinInicioSesion()
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
            WinAreaPrincipal areaPrincipal = new WinAreaPrincipal();

            
            areaPrincipal.Show();
            this.Hide();
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void WinInicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfaExemplo
{
    public partial class FrmCadAPS : Form
    {
        public FrmCadAPS()
        {
            InitializeComponent();
        }

        private void cmbForma_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbForma.Text)
            {
                case "Quadrado":
                    SelecionarQuadrado();
                    break;
                case "Triangulo":
                    SelecionarTriangulo();
                    break;

                default:
                    break;
            }
        }

        private void SelecionarQuadrado()
        {
            ExibirBase(true);
            ExibirAltura(false);
            lblRaio.Visible = txtRaio.Visible = false;
            cmbTriangulo.Visible = false;
        }

        private void ExibirAltura(bool visivel)
        {
            lblAltura.Visible = txtAltura.Visible = visivel;
        }

        private void ExibirBase(bool visivel)
        {
            lblBase.Visible = txtBase.Visible = visivel;
        }

        private void SelecionarTriangulo()
        {
            cmbTriangulo.Visible = cmbForma.Text.Equals("Triangulo");
            ExibirBase(true);
            ExibirAltura(true);
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            if (cmbForma.Text.Equals("Quadrado"))
            {

            }
        }
    }
}

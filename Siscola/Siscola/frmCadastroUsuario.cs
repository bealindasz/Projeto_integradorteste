using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Siscola.Data;
using System.Security.Cryptography;


namespace Siscola
{
    public partial class frmCadastroUsuario : Form
    {
        public frmCadastroUsuario()
        {
            InitializeComponent();
        }
        string senhaMd5 = "";
        // Senha MD5

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void frmCadastroUsuario_Load(object sender, EventArgs e)
        {
            txtCargo.Items.Add(" ");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '\0';
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {

            txtSenha.PasswordChar = '*';
        }
        public void Limpar()
        {
            txtLogin.Clear();
            txtNome.Clear();
            txtSenha.Clear();
            txtCargo.SelectedIndex = 2;
            txtNome.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {


        }

    }




}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorDeSenhas
{
    public partial class frmMenu : Form
    {
        string sugestao { get; set; }

        public frmMenu()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            await ChamarGerar();
            textBox1.Text = sugestao;
        }

        private async Task ChamarGerar()
        {
            using (Gerador gerador = new Gerador())
                sugestao = await gerador.GerarSenhaAleatoria();

        }
    }
}

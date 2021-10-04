using CSB.Application.Windows.Inicializacao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void abrirPastaDeInicializaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InicializacaoUtils.AbrirPastaInicializacao();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tópicosDeAjudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você que lute para aprender a usar esse software.", "Ajuda");
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new StringBuilder();
            about.AppendLine("Canivete Suíco do Bira");
            about.AppendLine();
            about.AppendLine($"Versão {Assembly.GetExecutingAssembly().GetName().Version}");
            about.AppendLine();
            about.AppendLine("Você está usando esse software por sua conta em risco. Não me responsabilizo por nada.");

            MessageBox.Show(about.ToString(), "Sobre...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void verificarPorAtualizaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pague-me por um servidor que um dia (talvez) eu faça algum esquema de atualizações automáticas.", "Olar");
        }
    }
}

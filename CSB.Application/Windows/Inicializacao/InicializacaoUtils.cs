using CSB.Resources;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSB.Application.Windows.Inicializacao
{
    public static class InicializacaoUtils
    {
        public static void AbrirPastaInicializacao()
        {
            Process.Start(Comandos.StartupFolder);
        }
    }
}

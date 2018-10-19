using System;
using System.Collections.Generic;
using System.Text;

namespace GeneradorScriptsAutoIt
{
    class ComandoWinWaitActive : Comando
    {
        public ComandoWinWaitActive() 
        {
          Nombre = "Esperar que se active una ventana";
        }

        public override string Escribir()
        {
            return "WinWaitActive(\""+this.Objetivo+"\", \"\",0)";
        }

        public override void Ejecutar()
        {
            AutoIt.AutoItX.WinWaitActive(this.Objetivo, "", 0);
        }
    }
}

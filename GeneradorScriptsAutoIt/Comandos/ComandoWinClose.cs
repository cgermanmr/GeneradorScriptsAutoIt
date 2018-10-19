using System;
using System.Collections.Generic;
using System.Text;

namespace GeneradorScriptsAutoIt
{
    class ComandoWinClose : Comando
    {

        public ComandoWinClose() 
        {
          Nombre = "Cerrar una ventana";
        }
        public override string Escribir()
        {
            return "WinClose(\"" + this.Objetivo + "\", \"\")";
        }

        public override void Ejecutar()
        {
            AutoIt.AutoItX.WinClose(this.Objetivo, "");
        }
    }
}

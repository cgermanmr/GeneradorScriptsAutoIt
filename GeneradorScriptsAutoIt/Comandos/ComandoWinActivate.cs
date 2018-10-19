using System;
using System.Collections.Generic;
using System.Text;

namespace GeneradorScriptsAutoIt
{
    class ComandoWinActivate : Comando
    {

        public ComandoWinActivate() 
        {
          Nombre = "Activar una ventana";
        }

        public override string Escribir()
        {
            return "WinActivate(\""+ this.Objetivo +"\", \"\")";
        }

        public override void Ejecutar()
        {
            AutoIt.AutoItX.WinActivate(this.Objetivo, "");
        }
    }
}

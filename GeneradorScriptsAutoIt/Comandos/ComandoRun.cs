using System;
using System.Collections.Generic;
using System.Text;
using AutoIt;

namespace GeneradorScriptsAutoIt
{
    class ComandoRun : Comando
    {

        public ComandoRun() 
        {
          Nombre = "Abrir o ejecutar un programa";
        }

        public override string Escribir()
        {
            return "Run(\"" + this.Valor + "\",\"\",@SW_SHOWNORMAL)"+ Environment.NewLine + "Sleep(1000)";
        }

        public override void Ejecutar()
        {
            AutoItX.Run(this.Valor, "", AutoItX.SW_NORMAL);
        }
    }
}

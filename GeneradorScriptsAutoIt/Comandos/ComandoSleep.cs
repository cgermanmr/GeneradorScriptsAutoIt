using System;
using System.Collections.Generic;
using System.Text;

namespace GeneradorScriptsAutoIt
{
    class ComandoSleep : Comando
    {

        public ComandoSleep() 
        {
          Nombre = "Detener script por un tiempo";
        }

        public override string Escribir()
        {
            return "Sleep("+this.Valor+")";
        }

        public override void Ejecutar()
        {
            AutoIt.AutoItX.Sleep(int.Parse(this.Valor));
        }
    }
}

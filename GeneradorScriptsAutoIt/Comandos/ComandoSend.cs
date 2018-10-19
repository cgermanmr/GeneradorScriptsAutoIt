using System;
using System.Collections.Generic;
using System.Text;

namespace GeneradorScriptsAutoIt
{
    class ComandoSend : Comando
    {

        public ComandoSend() 
        {
          Nombre = "Presionar teclas, enviar texto";
        }
        public override string Escribir()
        {
            return "Send(\"" + this.Valor + "\")";
        }

        public override void Ejecutar()
        {
            AutoIt.AutoItX.Send(this.Valor);
        }
    }
}

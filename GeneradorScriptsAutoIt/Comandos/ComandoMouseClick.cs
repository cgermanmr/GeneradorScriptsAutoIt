using System;
using System.Collections.Generic;
using System.Text;
using AutoIt;

namespace GeneradorScriptsAutoIt
{
    class ComandoMouseClick : Comando

    {
        public ComandoMouseClick() 
        {
          Nombre = "Click con botón izquierdo";
        }

        public override string Escribir()
        {
            return "MouseClick(\"left\")";
        }

        public override void Ejecutar()
        {
            AutoItX.MouseClick("LEFT");
        }
    }
}

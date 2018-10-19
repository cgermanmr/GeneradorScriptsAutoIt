using System;
using System.Collections.Generic;
using System.Text;

namespace GeneradorScriptsAutoIt
{
    class ComandoMouseDobleClick : Comando
    {
        public ComandoMouseDobleClick() 
        {
          Nombre = "Doble Click con botón derecho";
        }

        public override string Escribir()
        {
            return "MouseClick(\"left\", 0, 0, 2,500)";
        }

        public override void Ejecutar()
        {
            AutoIt.AutoItX.MouseClick("LEFT",0,0,2,500);
        }
    }
}

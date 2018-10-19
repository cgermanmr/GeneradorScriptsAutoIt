using System;
using System.Collections.Generic;
using System.Text;


namespace GeneradorScriptsAutoIt
{
    class ComandoMouseClickSecundario : Comando
    {
        public ComandoMouseClickSecundario() 
        {
          Nombre = "Click con botón derecho";
        }

        public override string Escribir()
        {
            return "MouseClick(\"right\")";
        }

        public override void Ejecutar()
        {
            AutoIt.AutoItX.MouseClick("RIGHT");
        }
    }
}

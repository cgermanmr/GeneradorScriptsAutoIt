using System;
using System.Collections.Generic;
using System.Text;

namespace GeneradorScriptsAutoIt
{
    class ComandoScreenCapture : Comando
    {

        public ComandoScreenCapture() 
        {
          Nombre = "Capturar pantalla";
        }
        public override string Escribir()
        {
            return "_ScreenCapture_Capture(\""+ this.Valor +"\")";
        }

        public override void Ejecutar()
        {
            
        }
    }
}

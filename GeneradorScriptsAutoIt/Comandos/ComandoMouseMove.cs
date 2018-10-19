using System;
using System.Collections.Generic;
using System.Text;

namespace GeneradorScriptsAutoIt
{
    class ComandoMouseMove : Comando
    {
        public ComandoMouseMove() 
        {
          Nombre = "Mover puntero a coordenadas X,Y";
        }

        public override string Escribir()
        {
            return "MouseMove("+ this.Valor +")";
        }

        public override void Ejecutar()
        {
            AutoIt.AutoItX.MouseMove(int.Parse(this.Valor.Split(',')[0]), int.Parse(this.Valor.Split(',')[1]));
        }
    }
}

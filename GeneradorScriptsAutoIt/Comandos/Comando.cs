using System;
using System.Collections.Generic;
using System.Text;

namespace GeneradorScriptsAutoIt
{
    abstract class Comando : ICloneable
    {
        public string Nombre { get; protected set; }
        public string Objetivo { get; set; }
        public string Valor { get; set; }
        public string Descripcion { get; set; }

        public abstract string Escribir();

        public abstract void Ejecutar();

        public override string ToString()
        {
            return Nombre;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}

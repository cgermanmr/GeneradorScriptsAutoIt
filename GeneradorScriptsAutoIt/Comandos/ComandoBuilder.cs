using System;
using System.Collections.Generic;
using System.Text;

namespace GeneradorScriptsAutoIt
{
    class ComandoBuilder
    {
       
       public static List<Comando> ObtenerComandos()
       {
           List<Comando> Comandos= new List<Comando>();

            Comandos.Add(new ComandoMouseClick());
            Comandos.Add(new ComandoMouseClickSecundario());
            Comandos.Add(new ComandoMouseDobleClick());
            Comandos.Add(new ComandoMouseMove());
            Comandos.Add(new ComandoRun());
            Comandos.Add(new ComandoScreenCapture());
            Comandos.Add(new ComandoSend());
            Comandos.Add(new ComandoSleep());
            Comandos.Add(new ComandoWinActivate());
            Comandos.Add(new ComandoWinClose());
            Comandos.Add(new ComandoWinWaitActive());
            return Comandos;
       }
    }
}

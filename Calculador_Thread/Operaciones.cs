using System;
using System.Threading;

namespace Calculador_Thread
{
   class Operaciones
    {
        public int operador1;
        public int operador2;
        private int resultado;

        // Constructor de la clase, la cual toma valores iniciales

        public Operaciones(int _operador1, int _operador2)
        {
            operador1=_operador1;
            operador2=_operador2;
        }

        public void Sumar()
        {
            lock (this)
            {
                resultado = operador1 + operador2;
                //Bloqueamos el Hilo actual durante un segundo
                Thread.Sleep(1000);
                Console.WriteLine("El resultado de la Suma es:" + resultado);
            }
       }

        public void Restar()
        {
            lock (this)
            {
                resultado = operador1 - operador2;
                //Bloqueamos el Hilo actual durante un segundo
                Thread.Sleep(1000);
                Console.WriteLine("El resultado de la Resta es:" + resultado);
            }
        }

        public void Multiplicar()
        {
            lock (this)
            {
                resultado = operador1 * operador2;
                //Bloqueamos el hilo actual durante un segundo
                Thread.Sleep(1000);
                Console.WriteLine("El resultado de la Multiplicacion es:" + resultado);
            }
        }
    }
}

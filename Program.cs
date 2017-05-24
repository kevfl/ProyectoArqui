using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Arqui
{
    class Program
    {
        public static int quantum;      

        static void Main(string[] args)
        {
            int QUANTUM;
            int reloj;
            int cantHilillos;
            String direccionHilillos;
            int velocidad;
            bool lento = false;

            Console.Write("Ingrese la cantidad de hilillos que desea ejecutar");
            cantHilillos = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la direccion donde se encuentran los archivos de los hilillos");
            direccionHilillos = Console.ReadLine();

            Console.Write("Ingrese el quantum para la ejecucion de cada hilillo \n");
            QUANTUM = int.Parse(Console.ReadLine());

            Console.Write("\n Si desea utilizar la ejecucion lenta, ingrese el numero 1");
            Console.Write("\n En caso contrario, ingrese cualquier otro numero");
            velocidad = int.Parse(Console.ReadLine());

            /**
             * Aqui va el metodo que lee los archivos de los hilillos.
             */

            if (velocidad == 1) {
                lento = true;
            }

            /**
             * Primero se inicializan las memorias
             */

            Thread core1 = new Thread(() => Cores(quantum));
            Thread core2 = new Thread(() => Cores(quantum));

            core1.Name = "1";
            core2.Name = "2";

            core1.Start();
            core2.Start();
        }


        /**
        * En este metodo se realizan todas las funciones de un core.
        */

        public static void Cores(int quant){
            int[] registros;                    //Registros del core
            int[,] cacheInstrucciones;          //Cache de instrucciones del nucleo
            int PC;                             //PC de la instruccion a ejecutar
            int codigoOperacion;                //Codigo de operacion de la instruccion a ejecutar
            int registroFuente1;                //Registro fuente 1
            int registroFuente2;                //Registro fuente 2
            int registroDestino;                //Registro destino
            int bloque;                         //Numero de bloque para buscar en cache
            int posicion;                       //Posicion para buscar en cache
            int palabra;                        //Palabra a buscar en cache
            int quantum;                        //Quantum para el hilillo ejecutandose
            int ID;                             //ID del hilillo ejecutandose
            int RL1;                            //Registro RL de la cache de datos 1
            int RL2;                            //Registro RL de la cache de datos 2

            registros = new int[32];
            cacheInstrucciones = new int[4, 6];
            PC = -1;
            ID = -1;
            
            //Se inicializan los registros del hilillo en 0
            for (int i = 0; i < 32; i++)
            {
                registros[i] = 0;
            }

            //Se inicializa la cache de instrucciones en 0
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    cacheInstrucciones[i, j] = 0;
                }
            }

            //Se ponen los bloques de la cache invalidos
            for (int i = 4; i < 6; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    cacheInstrucciones[i, j] = -1;
                }
            }

            /**
             * Falta agregar para que se ejecute cada vez que se carga un hilillo
             */

            switch (int.Parse(Thread.CurrentThread.Name)){
                case 1:
                    //Intentar entrar a la cache de datos 1
                    //Contar un ciclo de reloj
                    RL1 = -1;
                    break;

                case 2:
                    RL2 = -1;
                    break;
            }
        }
    }
}

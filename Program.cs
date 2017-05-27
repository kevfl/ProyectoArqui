using System;
using System.Collections;
using System.Threading;



namespace Arqui
{
    class Procesador
    {
        public static int QUANTUM;
        public static int reloj;
        public static int RL1;                            //Registro RL de la cache de datos 1
        public static int RL2;                            //Registro RL de la cache de datos 2
        public static ContextoHilillos hilillosPendientes;
        public static ContextoHilillos hilillosFinalizados;
        public static int[] busDatos = new int[1];
        public static int[] busInstrucciones = new int[1];

        static void Main(string[] args)
        {
            int cantHilillos;
            String direccionHilillos;
            int velocidad;
            bool lento = false;

            hilillosPendientes = new ContextoHilillos();
            hilillosFinalizados = new ContextoHilillos();

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

            Memorias mem = new Memorias();

            /**
             * Se crean los dos hilos correspondientes a cada nucleo
             */

            Thread core1 = new Thread(() => Cores(QUANTUM));
            Thread core2 = new Thread(() => Cores(QUANTUM));

            /**
             * Se le da un nombre a cada nucleo
             */

            core1.Name = "1";
            core2.Name = "2";

            /**
             * Inicia cada nucleo
             */

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
            int ciclos;                         //Ciclos de reloj utilizados por el hilillo
            int inicioCiclos;                   //Ciclo de reloj en donde inicia la ejecucion del hilillo

            registros = new int[32];
            cacheInstrucciones = new int[6, 4];
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

            bool colaVacia = true;
            while (colaVacia){
                while (!Monitor.TryEnter(hilillosPendientes)){
                    //Ciclo de reloj
                }
                //ciclo de reloj

                if (hilillosPendientes.Cantidad() > 0){
                    colaVacia = false;
                }
                else {
                    Monitor.Exit(hilillosPendientes);
                }
            }

            /**
             * Cada vez que se corre un hilillo se ponen los RL con valores invalidos.
             */

            switch (int.Parse(Thread.CurrentThread.Name)){
                case 1:
                    while (!Monitor.TryEnter(Memorias.cacheDatos1)){
                        //contar un ciclo de reloj.
                    }
                    //Contar un ciclo de reloj
                    RL1 = -1;
                    Monitor.Exit(Memorias.cacheDatos1);
                    break;

                case 2:
                    while (!Monitor.TryEnter(Memorias.cacheDatos2)){
                        //contar ciclo de reloj
                    }
                    //contar ciclo de reloj
                    RL2 = -1;
                    Monitor.Exit(Memorias.cacheDatos2);
                    break;
            }

            ciclos = 0;
            hilillosPendientes.Sacar(ref PC, ref registros, ref ciclos, ref ID);
            Monitor.Exit(hilillosPendientes);
            quantum = quant;
            inicioCiclos = reloj;

            while(quantum > 0){
                bloque = PC / 16;
                posicion = bloque % 4;
                palabra = (PC % 16) / 4;

                /**
                 * Se busca la instruccion en la cache de instrucciones propia
                 */

                if (cacheInstrucciones[4, posicion] != bloque || cacheInstrucciones[5 , posicion] != 1){
                    //Se da un fallo de cache.

                    while (!Monitor.TryEnter(busInstrucciones)){
                       //Ciclo de reloj
                    }
                    //ciclo de reloj

                    cacheInstrucciones[4, posicion] = bloque;
                    cacheInstrucciones[5, posicion] = 1;

                    /**
                     * Sacar el el bloque de la mem. de instrucciones 
                     */

                    //? ciclos

                    Monitor.Exit(busInstrucciones);
                }

                codigoOperacion = cacheInstrucciones[0, posicion];
                registroFuente1 = cacheInstrucciones[1, posicion];
                registroFuente2 = cacheInstrucciones[2, posicion];
                registroDestino = cacheInstrucciones[3, posicion];
                PC = PC + 4;

                switch (codigoOperacion){
                    case 8:                 //DADDI
                        registros[registroFuente2] = registros[registroFuente1] + registroDestino;
                        break;

                    case 32:                //DADD
                        registros[registroDestino] = registros[registroFuente1] + registros[registroFuente2];
                        break;

                    case 34:                //DSUB
                        registros[registroDestino] = registros[registroFuente1] - registros[registroFuente2];
                        break;

                    case 12:                //DMUL
                        registros[registroDestino] = registros[registroFuente1] * registros[registroFuente2];
                        break;

                    case 14:                //DDIV
                        registros[registroDestino] = registros[registroFuente1] / registros[registroFuente2];
                        break;

                    case 4:                 //BEQZ
                        if (registros[registroFuente1] == 0){
                            PC = PC + registros[registroDestino] * 4;
                        }
                        else {

                        }
                        break;

                    case 5:                 //BNEQ
                        if (registros[registroFuente1] != 0){
                            PC = PC + registros[registroDestino] * 4;
                        }
                        else{

                        }
                        break;

                    case 3:                 //JAL
                        registros[31] = PC;
                        PC = PC + registroDestino;
                        break;

                    case 2:                 //JR
                        PC = registros[registroFuente1];
                        break;

                    case 50:                //LL *Todavia no se implementa*
                        break;

                    case 51:                //SC *Todavia no se implementa*
                        break;

                    case 35:                //LW *Esperar a revisar los diagramas*
                        break;

                    case 43:                //SW *Esperar a revisar los diagramas*
                        break;

                    case 63:                 //FIN ???
                        break;
                }

                quantum--;

                if (quantum == 0) {
                    while(!Monitor.TryEnter(hilillosPendientes)){
                        //ciclo de reloj
                    }
                    //ciclo de reloj

                    hilillosPendientes.Guardar(PC, ref registros, ciclos, ID);
                    Monitor.Exit(hilillosPendientes);
                }
            }
        }
    }

    public class Memorias
    {
        public static int[] memoriaDatos = new int[96];                 //24 bloques de 4 * 4
        public static int[] memoriaInstrucciones = new int[640];        //40 bloques de 4 * 4

        public static int[,] cacheDatosCompartida = new int[6, 8];

        public static int[,] cacheDatos1 = new int[6, 4];
        public static int[,] cacheDatos2 = new int[6, 4];

        public Memorias()
        {
            for (int i = 0; i < 96; i++)
            {
                memoriaDatos[1] = 1;
                memoriaInstrucciones[i] = 1;
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    cacheDatos1[i, j] = 0;
                    cacheDatos2[i, j] = 0;
                }
            }

            for (int i = 4; i < 6; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    cacheDatos1[i, j] = -1;
                    cacheDatos2[i, j] = -1;
                }
            }

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    cacheDatosCompartida[i, j] = 0;
                }
            }

            for (int i = 4; i < 6; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    cacheDatosCompartida[i, j] = -1;
                }
            }
        }

        public static void escribirMemInstruc() {

        }

        public static void sacarInstruccion(){

        }

        public static void escribirMemDatos(){

        }

        public static void sacarDatos(){

        }

        public static void escribirCacheDatosComp(){

        }

        public static void sacarCacheDatosComp(){

        }

        public static void escribirCacheDatos1(){

        }

        public static void sacarCacheDatos1(){

        }

        public static void escribirCacheDatos2()
        {

        }

        public static void sacarCacheDatos2()
        {

        }
    }

    public class ContextoHilillos
    {
        private Queue cola;
        private struct Contexto
        {
            public int pc;
            public int[] registros;
            public int ciclosCPU;
            public int ciclosTotal;
            public int Id;

            /**
             * Contexto para un hilillo apenas se leen los archivos de texto.
             */

            public Contexto(int p_c, int id)
            {
                pc = p_c;
                ciclosCPU = 0;
                ciclosTotal = 0;
                Id = id;
                registros = new int[32];

                for (int i = 1; i < 32; i++)
                {
                    registros[i] = 0;
                }
            }

            /**
             * Contexto para un hilillo sin finalizar
             */

            public Contexto(int p_c, ref int[] reg, int cpu, int id)
            {
                pc = p_c;
                ciclosCPU = cpu;
                ciclosTotal = 0;
                Id = id;
                registros = new int[32];

                for (int i = 1; i < 32; i++)
                {
                    registros[i] = reg[i];
                }
            }

            /**
             * Contexto para un hilillo ya finalizado
             */

            public Contexto(int p_c, ref int[] reg, int cpu, int total, int id)
            {
                pc = p_c;
                ciclosCPU = cpu;
                ciclosTotal = total;
                Id = id;
                registros = new int[32];

                for (int i = 1; i < 32; i++)
                {
                    registros[i] = reg[i];
                }
            }
        }

        public ContextoHilillos()
        {
            cola = new Queue();
        }

        public void Guardar(int p_c, ref int[] reg, int cpu, int id)
        {
            Contexto hilillo = new Contexto(p_c, ref reg, cpu, id);
            cola.Enqueue(hilillo);
        }

        public void Sacar(ref int p_c, ref int[] reg, ref int ciclosActual, ref int id)
        {
            Contexto cont = (Contexto)cola.Dequeue();

            for (int i = 1; i < 32; i++)
            {
                reg[i] = cont.registros[i];
            }

            ciclosActual = cont.ciclosCPU;
            p_c = cont.pc;
            id = cont.Id;
        }

        public int Cantidad()
        {
            return cola.Count;
        }

        public void GuardarFinalizado(int p_c, ref int[] reg, int ciclos, int total, int id)
        {
            Contexto cont = new Contexto(p_c, ref reg, ciclos, total, id);
            cola.Enqueue(cont);
        }
    }

}

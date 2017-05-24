using System;

public class ContextoHilillos
{
    private Queue cola;
    public int hilillos;
    private struct Contexto {
        public int pc;
        public int[] registros;
        public int ciclosCPU;
        public int ciclosTotal;
        public int Id;

        /**
         * Contexto para un hilillo sin finalizar
         */

        public Contexto(int p_c, ref int[] reg, int cpu, int id){
            pc = p_c;
            ciclosCPU = cpu;
            ciclosTotal = 0;
            Id = id;
            registros = new int[32];

            for (int i = 1; i < 32; i++) {
                registros[i] = reg[i];
            }
        }

        /**
         * Contexto para un hilillo ya finalizado
         */

        public Contexto(int p_c, ref int[] reg, int cpu, int total, int id) {
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
        hilillos = 0;
	}

    public void Guardar(int p_c, ref int[] reg, int cpu, int id) {
        Contexto hilillo = new Contexto(p_c, ref reg, cpu, id);
        cola.Enqueue(hilillo);
        hilillos++;
    }

    public void Sacar(ref int p_c, ref int[] reg, ref int ciclosActual, ref int id) {
        Contexto cont = (Contexto)cola.Dequeue();

        for (int i = 1; i < 32; i++) {
            reg[i] = cont.registros[i];
        }

        ciclosActual = cont.ciclosCPU;
        p_c = cont.pc;
        id = cont.Id;
        hilillos--;
    }

    public int Cantidad(){
        return hilillos;
    }

    public void GuardarFinalizado(int p_c, ref int[] reg, int ciclos, int total, int id) {
        Contexto cont = new Contexto(p_c, ref reg, ciclos, total, id);
        cola.Enqueue(cont);
        hilillos++;
    }
}

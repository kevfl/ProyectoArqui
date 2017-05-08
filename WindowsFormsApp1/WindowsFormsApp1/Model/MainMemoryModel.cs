using System;
using System.Data.Entity;
using System.Linq;

//Clase de memoria principal, tanto instrucciones como datos.
public class MainMemory : DbContext
{
    private int[] memoryData;
    private int[] memoryInstruction;

    private int tamMemoryData;
    private int tamMemoryInstruction;

    //M�todo que inicializa la memoria de instrucciones y la de datos con 1's
    public MainMemory(int tamData, int tamInstruction)
        {
            memoryData = new int[tamData];
            memoryInstruction = new int[tamInstruction];

            SetTamMemoryData(tamData);
            SetTamMemoryInstrucion(tamInstruction);

            for (int i = 0; i < tamData; i++) {
                SetMemoryData(i, 1);
            }

            for (int i = 0; i < tamInstruction; i++){
                SetMemoryInstruction(i, 1);
            }
        }
    
    //M�todo que establece el tama�o de la memoria de datos.
    public void SetTamMemoryData(int tamData) {
            this.tamMemoryData = tamData;
        }

    //M�todo que devuelve el tama�o de la memoria de datos.
    public int GetTamMemoryData()
        {
            return tamMemoryData;
        }

    //M�todo que establece el tama�o de la memoria de instrucciones.
    public void SetTamMemoryInstrucion(int tamInstruction)
        {
            this.tamMemoryInstruction = tamInstruction;
        }

    //M�todo que devuelve el tama�o de la memoria de instrucciones.
    public int GetTamMemoryInstrucion()
    {
        return this.tamMemoryInstruction;
    }

    //M�todo que ingresa un dato en una posicion dada.
    public void SetMemoryData(int pos, int val)
        {
            memoryData[pos] = val;
        }

    //M�todo que devuelve el datos de una posicion dada.
    public int GetMemoryData(int pos)
        {
            return memoryData[pos];
        }

    //M�todo que ingresa una palabra de instruccion en una posicion dada.
    public void SetMemoryInstruction(int pos, int val)
        {
            memoryInstruction[pos] = val;
        }

    //M�todo que devuelve una palabra de instruccion de posicion dada.
    public int GetMemoryInstruction(int pos)
    {
        return memoryInstruction[pos];
    }

    public Instruction GetInstruction(int pos) {
        return new Instruction(GetMemoryInstruction(pos*16),
                         GetMemoryInstruction(pos * 16 + 1),
                         GetMemoryInstruction(pos * 16 + 2),
                         GetMemoryInstruction(pos * 16 + 3));
    }
}
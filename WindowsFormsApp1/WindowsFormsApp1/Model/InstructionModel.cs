using System;
using System.Data.Entity;
using System.Linq;

//Clase de memoria principal, tanto instrucciones como datos.
public class Instruction : DbContext
{
    private int i1,i2,i3,i4;

    public Instruction(int i1, int i2, int i3, int i4)
    {
        this.i1 = i1;
        this.i2 = i2;
        this.i3 = i3;
        this.i4 = i4;
    }

    public int GetInstructionValue(int i) {
        switch (i)
        {
            case 1:
                return i1;
            case 2:
                return i2;
            case 3:
                return i3;
            case 4:
                return i4;
            default:
                return 0;
        }
    }
}

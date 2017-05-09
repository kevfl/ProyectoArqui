using System;
using System.Data.Entity;
using System.Linq;

//Clase de memoria principal, tanto instrucciones como datos.
public class Block : DbContext
{
    private int i1, i2,i3, i4, flag, etiq;

    public Block(int i1, int i2, int i3, int i4, int flag, int etiq)
    {
        this.i1 = i1;
        this.i2 = i2;
        this.i3 = i3;
        this.i4 = i4;
        this.flag = flag;
        this.etiq = etiq;
    }

    public int GetDataValue(int i)
    {
        switch (i)
        {
            case 1:
                return i1;
            case 2:
                return i2;
            default:
                throw new Exception();
        }
    }

    public int GetEtiq() {
        return this.etiq;
    }

    public int GetFlag() {
        return this.flag;
    }

    public void SetValue(int i, int value, int flag){
        this.flag = flag;
        switch (i)
        {
            case 1:
                this.i1 = value;
                break;
            case 2:
                this.i2 = value;
                break;
            default:
                throw new Exception();
        }
    }

    public void SetValues(int value1, int value2, int flag){
        this.flag = flag;
        this.i1 = value1;
        this.i2 = value2;
    }

}

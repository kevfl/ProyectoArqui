using System;

public class Memorias
{
    public static int[] memoriaDatos = new int[96];
    public static int[] memoriaInstrucciones = new int[640];

    public static int[,] cacheDatosCompartida = new int[8,6];

    public static int[,] cacheDatos1 = new int[4,6];
    public static int[,] cacheDatos2 = new int[4,6];

    public static int[] busDatos = new int[1];
    public static int[] busInstrucciones = new int[1];


	public Memorias()
	{
        for (int i = 0; i < 96; i++) {
            memoriaDatos[1] = 1;
            memoriaInstrucciones [i] = 1;
        }

        for (int i = 0; i < 4; i++){
            for (int j = 0; j < 4; j++){
                cacheDatos1[i, j] = 0;
                cacheDatos2[i, j] = 0;
            }
        }

        for(int i = 4; i < 6; i++){
            for(int j = 0; j < 4; j++){
                cacheDatos1[i, j] = -1;
                cacheDatos2[i, j] = -1;
            }
        }

        for (int i = 0; i < 6; i++){
            for (int j = 0; j < 6; j++) {
                cacheDatosCompartida[i, j] = 0;
            }
        }

        for (int i = 6; i < 8; i++) {
            for (int j = 0; j < 8; j++) {
                cacheDatosCompartida[i, j] = -1;
            }
        }
	}
}

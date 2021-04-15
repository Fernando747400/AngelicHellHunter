using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class VariablesGlobales 
{
    private static int cuero_azar, sello_azar, corona_azar;
    private static bool cuero, sello, corona, talisman, llave1, llave2, enemigo_fase1_existe, enemigo_fase2_existe, enemigo_fase3_existe;
    private static float vida_jugador, vida_enemigo_fase1, vida_enemigo_fase2, vida_enemigo_fase3;
    private static bool primera_carga = true;

    public static bool Primera_carga
    {
        get
        {
            return primera_carga;
        }

        set
        {
            primera_carga = value;
        }
    }
    public static int Cuero_azar
    {
        get
        {
            return cuero_azar;
        }

        set
        {
            cuero_azar = value;
        }
    }

    public static int Sello_azar
    {
        get
        {
            return sello_azar;
        }

        set
        {
            sello_azar = value;
        }
    }
    public static int Corona_azar
    {
        get
        {
            return corona_azar;
        }

        set
        {
            corona_azar = value;
        }
    }

    public static bool Cuero
    {
        get
        {
            return cuero;
        }

        set
        {
            cuero = value;
        }
    }

    public static bool Sello
    {
        get
        {
            return sello;
        }

        set
        {
            sello = value;
        }
    }

    public static bool Corona
    {
        get
        {
            return corona;
        }

        set
        {
            corona = value;
        }
    }

    public static bool Talisman
    {
        get
        {
            return talisman;
        }

        set
        {
            talisman = value;
        }
    }

    public static bool Llave1
    {
        get
        {
            return llave1;
        }

        set
        {
            llave1 = value;
        }
    }

    public static bool Llave2
    {
        get
        {
            return llave2;
        }

        set
        {
            llave2 = value;
        }
    }

    public static bool Enemigo_fase1_existe
    {
        get
        {
            return enemigo_fase1_existe;
        }

        set
        {
            enemigo_fase1_existe = value;
        }
    }

    public static bool Enemigo_fase2_existe
    {
        get
        {
            return enemigo_fase2_existe;
        }

        set
        {
            enemigo_fase2_existe = value;
        }
    }

    public static bool Enemigo_fase3_existe
    {
        get
        {
            return enemigo_fase3_existe;
        }

        set
        {
            enemigo_fase3_existe = value;
        }
    }

    public static float Vida_jugador
    {
        get
        {
            return vida_jugador;
        }

        set
        {
            vida_jugador = value;
        }
    }

    public static float Vida_enemigo_fase1
    {
        get
        {
            return vida_enemigo_fase1;
        }

        set
        {
            vida_enemigo_fase1 = value;
        }
    }

    public static float Vida_enemigo_fase2
    {
        get
        {
            return vida_enemigo_fase2;
        }

        set
        {
            vida_enemigo_fase2 = value;
        }
    }

    public static float Vida_enemigo_fase3
    {
        get
        {
            return vida_enemigo_fase3;
        }

        set
        {
            vida_enemigo_fase3 = value;
        }
    }



}

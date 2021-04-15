using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculosIniciales : MonoBehaviour
{
    public void Awake()
    {
        
    }

    public void Start()
    {
        if (VariablesGlobales.Primera_carga)
        {
            objetos_reiniciar();
            vidas_reiniciar();
            RNG_recalcular();
            Debug.Log("Cuero" + VariablesGlobales.Cuero_azar);
            Debug.Log("Sello" + VariablesGlobales.Sello_azar);
            Debug.Log("Corona" + VariablesGlobales.Corona_azar);
            VariablesGlobales.Primera_carga = false;
            
        }
      
    }

    public void objetos_reiniciar()
    {
        VariablesGlobales.Cuero = false;
        VariablesGlobales.Sello = false;
        VariablesGlobales.Corona = false;
        VariablesGlobales.Talisman = false;
    }

    public void vidas_reiniciar()
    {
        VariablesGlobales.Vida_jugador = 100f;
        VariablesGlobales.Vida_enemigo_fase1 = 100f;
        VariablesGlobales.Vida_enemigo_fase2 = 100f;
        VariablesGlobales.Vida_enemigo_fase3 = 100f;
    }

    public void enemigos_reiniciar()
    {
        VariablesGlobales.Enemigo_fase1_existe = true;
        VariablesGlobales.Enemigo_fase2_existe = false;
        VariablesGlobales.Enemigo_fase3_existe = false;
    }


    public void RNG_recalcular()
    {
        Cuero_calcular();
        Sello_calcular();
        Corona_calcular();
    }

    public void Cuero_calcular()
    {
        VariablesGlobales.Cuero_azar = Random.Range(1, 5);
    }

    public void Sello_calcular()
    {
        VariablesGlobales.Sello_azar = Random.Range(1, 3);
    }

    public void Corona_calcular()
    {
        VariablesGlobales.Corona_azar = Random.Range(1, 3);
    }
}

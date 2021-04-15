using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaUI : MonoBehaviour
{
    private Image salud;
    private float vidaMaxima = 100f;
    void Start()
    {
        salud = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        salud.fillAmount = VariablesGlobales.Vida_jugador / vidaMaxima;
    }
}

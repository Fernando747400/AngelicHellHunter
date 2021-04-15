using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIGlobal : MonoBehaviour
{
    public Image cuero, sello, corona, llave1, llave2, talisman;
    void Start()
    {
        cuero.GetComponent<Image>();
        sello.GetComponent<Image>();
        corona.GetComponent<Image>();
        llave1.GetComponent<Image>();
        llave2.GetComponent<Image>();
        talisman.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (VariablesGlobales.Cuero == true)
        {
            cuero.enabled = true;
        }
        else cuero.enabled = false;

        if (VariablesGlobales.Sello == true)
        {
            sello.enabled = true;
        }
        else sello.enabled = false;

        if (VariablesGlobales.Corona == true)
        {
            corona.enabled = true;
        }
        else corona.enabled = false;

        if (VariablesGlobales.Llave1 == true)
        {
            llave1.enabled = true;
        }
        else llave1.enabled = false;

        if (VariablesGlobales.Llave2 == true)
        {
            llave2.enabled = true;
        }
        else llave2.enabled = false;

        if (VariablesGlobales.Talisman == true)
        {
            talisman.enabled = true;
        }
        else talisman.enabled = false;

    }
}

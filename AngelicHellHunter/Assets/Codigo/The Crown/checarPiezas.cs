using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checarPiezas : MonoBehaviour
{
    public GameObject Cuero, Sello, Corona;
    void Start()
    {
        Cuero = transform.GetComponent<GameObject>();
        Sello = transform.GetComponent<GameObject>();
        Corona = transform.GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (VariablesGlobales.Cuero == false)
        {
            Cuero.SetActive(false);
        }
        else Cuero.SetActive(true);

        if (VariablesGlobales.Corona == false)
        {
            Corona.SetActive(false);
        }
        else Corona.SetActive(true);

        if (VariablesGlobales.Sello == false)
        {
            Sello.SetActive(false);
        }
        else Sello.SetActive(true);
    }
}

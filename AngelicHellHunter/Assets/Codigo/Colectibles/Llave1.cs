using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Llave1 : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<MovimientoJugador>() != null)
        {
            VariablesGlobales.Llave1 = true;
            Destroy(this.gameObject);
        }
    }
}

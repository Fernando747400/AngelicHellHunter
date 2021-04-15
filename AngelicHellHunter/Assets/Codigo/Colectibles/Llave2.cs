using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Llave2 : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<MovimientoJugador>() != null)
        {
            VariablesGlobales.Llave2 = true;
            Destroy(this.gameObject);
        }
    
}
}

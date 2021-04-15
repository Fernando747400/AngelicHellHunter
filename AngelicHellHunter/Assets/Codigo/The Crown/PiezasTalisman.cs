using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PiezasTalisman : MonoBehaviour
{
    private Vector3 PosicionCorreta;
    public bool Encajada;
    public bool Seleccionada;
    public bool Ensulugar;

    public int cambiar = 0;

    // Start is called before the first frame update
    void Start()
    {
        PosicionCorreta = transform.position;
        transform.position = new Vector3(Random.Range(-0.5f, 0.5f), Random.Range(-1f, -0.5f));
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, PosicionCorreta) < 0.5F)
        {
            if (!Seleccionada)
            {
                if (Encajada == false)
                {
                    transform.position = PosicionCorreta;
                    GetComponent<SortingGroup>().sortingOrder = 0;

                    if (transform.position == PosicionCorreta)
                    {
                        Encajada = true;

                        if (Encajada == true)
                        {
                            Camera.main.GetComponent<TheCrown>().PiezasEncajadas++;

                        }
                    }

                }

            }


        }
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : MonoBehaviour
{
    [HideInInspector]  public Vector3 targetPos;
    [SerializeField] private float speed = 3;
    [SerializeField] private float timeToDie = 3;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, timeToDie);
    }

    // Update is called once per frame
    void Update()
    {
        MoveToTarget();
    }

    public void MoveToTarget()
    {
        transform.Translate((targetPos - transform.position).normalized * Time.deltaTime * speed);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}

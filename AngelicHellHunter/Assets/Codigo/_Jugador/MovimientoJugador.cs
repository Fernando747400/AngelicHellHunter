using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovimientoJugador : MonoBehaviour
{
    public float velocidad = 5f;
    float Xaxis, Yaxis;
    public Rigidbody2D rb;
    private Vector2 movimiento = new Vector2();
    private Animator animator;
    public bool animacion;
    public bool atack;
    public float Invunerable = 5f;
    public float vunerable = 0;
    public bool dañorecibido;


    public float tiempoInicial;
    public float TiempoLimite = 0.8f;

    [Header("Bullet")]
    [SerializeField] private float timeToSpawnBullet = 3;
    private float timingToSpawnBullet =0;
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform spawnBullet;
    [SerializeField] private Transform target;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        inputs();
        muerto();
    }

    public void FixedUpdate()
    {
        Moverse();
    }

    void inputs()
    {
        Xaxis = Input.GetAxisRaw("Horizontal");
        Yaxis = Input.GetAxisRaw("Vertical");
        movimiento = new Vector2(Xaxis, Yaxis).normalized;
        disparo();


        if (Xaxis != 0 || Yaxis != 0)
        {
            animator.SetBool("Move", true);
        }
        else
        {
            rb.velocity = Vector2.zero;
            animator.SetBool("Move", false);
        }

        if (Xaxis > 0)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        if (Xaxis < 0)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
    }

    void Moverse()
    {
        rb.velocity = new Vector2(movimiento.x * velocidad, movimiento.y * velocidad);
    }

    void disparo()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            atack = true;
            animator.SetBool("Shoot", true);
            tiempoInicial += Time.deltaTime;
 
                GameObject clone = Instantiate(bullet, spawnBullet.position, spawnBullet.rotation);
                clone.GetComponent<BulletEnemy>().targetPos = target.position;
            

        }
        if (atack == true)
        {
            tiempoInicial += Time.deltaTime;
        }
        if (tiempoInicial >= TiempoLimite)
        {
            animator.SetBool("Shoot", false);
            atack = false;
            tiempoInicial = 0;
        }

    }

    public void muerto()
    {
       if(VariablesGlobales.Vida_jugador == 0)
        {
            VariablesGlobales.Primera_carga = true;

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (dañorecibido == false)
        {
            if (collision.gameObject.tag == "Shoot")
            {
                VariablesGlobales.Vida_jugador -= 20;
                dañorecibido = true;
            }
        }
        if (dañorecibido == true)
        {
            vunerable++;
        }
        if (vunerable == Invunerable)
        {
            dañorecibido = false;
            vunerable = 0;
        }

    }
}

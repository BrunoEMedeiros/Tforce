using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    public float Speed;
    private Transform backPoint;
<<<<<<< HEAD
=======

>>>>>>> dcc816da616cb49e46a793affa4e494fcee44d35
    private Animator animator;
    private Rigidbody2D rig;

    void Start()
    {
        backPoint = GameObject.Find("backPoint").GetComponent<Transform>();
        animator = GetComponent<Animator>();
        rig = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
<<<<<<< HEAD
        if(GameController.current.PlayerIsAlive)
        {
            rig.velocity = new Vector2(-Speed, rig.velocity.y);

            if(transform.position.x < backPoint.position.x)      
            {
                Destroy(gameObject);
            }
=======
        //Mesma logica da bala só que para a esquerda
        //transform.Translate(Vector3.left * Speed * Time.deltaTime); 

        rig.velocity = new Vector2(-Speed, rig.velocity.y);

        if(transform.position.x < backPoint.position.x)      
        {
            Destroy(gameObject);
>>>>>>> dcc816da616cb49e46a793affa4e494fcee44d35
        }
    }

    //Metodo para verificar colisao da bala no inimigo
    void OnTriggerEnter2D(Collider2D collision) 
    {
        //Se o inimigo bateu na bala
        if(collision.gameObject.tag == "bullet")
        {
<<<<<<< HEAD
            GetComponent<CircleCollider2D>().enabled = false;
            GameController.current.AddScore(10); // Ao matar inimigo ganha 10 moedas
=======
>>>>>>> dcc816da616cb49e46a793affa4e494fcee44d35
            animator.SetTrigger("destroy");
            Destroy(gameObject, 1f);
        }
        
    }
}

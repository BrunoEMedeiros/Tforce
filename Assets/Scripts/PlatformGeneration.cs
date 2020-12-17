using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGeneration : MonoBehaviour
{
<<<<<<< HEAD
   public GameObject Platform; //Plataforma
   public Transform point; // ponto onde acaba a camera

   public float minDistance;
   public float maxDistance;

   private float platformWidth; // tamanho da plataforma
   

    void Start()
    {
        if(Platform.GetComponent<BoxCollider2D>())
        {
            //Pegando o tamanho do colisor
            platformWidth = Platform.GetComponent<BoxCollider2D>().size.x;
        }
        else
        {
            //Pegando tamanho do colisor com formas diferentes
=======
    public GameObject Platform;
    public Transform point;
    public float Distance;

    private float platformWidth; 

    void Start()
    {
        if(Platform.GetComponent<BoxCollider2D>()){
            platformWidth = Platform.GetComponent<BoxCollider2D>().size.x;

        }else{
>>>>>>> 7982a888086c8e4bd4d6256961fe5b425affa6c8
            platformWidth = Platform.GetComponent<PolygonCollider2D>().bounds.size.x;
        }
    }

<<<<<<< HEAD
   
    void Update()
    {
        //Logica para gerar plataformas // Se objeto estiver fora da camera
        if(transform.position.x < point.position.x)
        {

            float Distance = Random.Range(minDistance, maxDistance);
            
            //Gera nova plataforma
            transform.position = new Vector3(transform.position.x + platformWidth + Distance, 
                transform.position.y, 0);

            //Instaciando nova plataforma na cena
            Instantiate(Platform, transform.position, transform.rotation);
        }
=======
    void Update()
    {
        Distance = Random.Range(3f, 8f);

        if(transform.position.x < point.position.x){
            transform.position = new Vector3(transform.position.x + platformWidth + Distance, transform.position.y, transform.position.z);
            Instantiate(Platform, transform.position, transform.rotation);
        }   
>>>>>>> 7982a888086c8e4bd4d6256961fe5b425affa6c8
    }
}

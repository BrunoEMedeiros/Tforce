using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
<<<<<<< HEAD
    
    private Transform backPoint;

=======


    private Transform backPoint;
    
>>>>>>> 7982a888086c8e4bd4d6256961fe5b425affa6c8
    void Start()
    {
        backPoint = GameObject.Find("backPoint").GetComponent<Transform>();
    }

    void Update()
    {
<<<<<<< HEAD
        if(transform.position.x < backPoint.position.x)
        {
            Destroy(gameObject);
        }
        
=======
        if(transform.position.x < backPoint.position.x){
            Destroy(gameObject);
        }
>>>>>>> 7982a888086c8e4bd4d6256961fe5b425affa6c8
    }
}

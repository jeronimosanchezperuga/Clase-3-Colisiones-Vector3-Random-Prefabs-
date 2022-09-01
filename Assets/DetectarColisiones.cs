using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectarColisiones : MonoBehaviour
{

    public int puntaje;
    // Start is called before the first frame update
    void Start()
    {
        puntaje = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D()
    {
        Destroy(gameObject);
    }

    void OnTriggerEnter2D()
    {
        puntaje++;
    }


}



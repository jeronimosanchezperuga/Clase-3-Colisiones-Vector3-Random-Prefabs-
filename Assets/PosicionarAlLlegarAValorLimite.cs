using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosicionarAlLlegarAValorLimite : MonoBehaviour
{
    public float posicionX;
    public float limiteX;
    public Vector3 posicionInicial;
    public float numeroAlAzar;
    public float alturaMax;
    public float alturaMin;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        posicionX = transform.position.x;

        if (posicionX < limiteX)
        {
            numeroAlAzar = Random.Range(alturaMin, alturaMax);
            transform.position = posicionInicial + (Vector3.up * numeroAlAzar);
            
            
        }
        
    }
}

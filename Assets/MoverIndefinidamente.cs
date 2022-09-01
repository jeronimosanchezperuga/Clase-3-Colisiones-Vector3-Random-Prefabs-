using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverIndefinidamente : MonoBehaviour
{
    public float velocidad;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(velocidad,0,0);
    }
}

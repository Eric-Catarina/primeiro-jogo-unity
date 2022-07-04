using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moeda : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        
    }
    float velocidadeMoeda = 1.75f;
    int direcao = -1;
    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0,velocidadeMoeda,0) *Time.deltaTime * velocidadeMoeda * direcao;
        if (transform.position.y <-5){
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Distance : MonoBehaviour
{
    [SerializeField]
    private Transform checkpoint;  //ref a la posicion del punto B
    
    public float distanceB;  //valor de distancia
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        UpdatePosition();
        
        



    }

    public void UpdatePosition() {
        distanceB = (checkpoint.transform.position.x - transform.position.x);

    }
}

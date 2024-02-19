using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Barra : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject finish;

    Image barraEnergia;
    float maxDistance;
   

    

    private void Awake() {
       
    }
    // Start is called before the first frame update
    void Start()
    {
       
        barraEnergia = GetComponent<Image>();
        maxDistance = finish.transform.position.x + finish.transform.position.y;

        barraEnergia.fillAmount = (player.transform.position.x + player.transform.position.y)/ maxDistance;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (barraEnergia.fillAmount < 1) {
            barraEnergia.fillAmount = (player.transform.position.x + player.transform.position.y)/ maxDistance;

        }
        
       
        

        
            
    }

    

    
}

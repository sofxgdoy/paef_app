using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Barra : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject beginning;
    [SerializeField] GameObject finish;

    Image barraEnergia;
    float maxDistance;
    float movedDistance;
    float llenado;
   

    

    private void Awake() {
       
    }
    // Start is called before the first frame update
    void Start()
    {
       
        barraEnergia = GetComponent<Image>();
        maxDistance = Vector3.Distance(beginning.transform.position, finish.transform.position); //ponele q son 10
        Debug.Log("maxDistance=" + maxDistance);
        movedDistance=  Vector3.Distance(player.transform.position, beginning.transform.position); //0
        Debug.Log("movedDistance=" + movedDistance);

        barraEnergia.fillAmount = 0; //esto quedaria, 0/10, which is fine, 0
        Debug.Log("barraEnergia.fillAmount=" + barraEnergia.fillAmount);
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        /*llenado = movedDistance/maxDistance; //
        Debug.Log("llenado=" + llenado);*/

        if (barraEnergia.fillAmount < 1) {
            barraEnergia.fillAmount =  (Vector3.Distance(beginning.transform.position, finish.transform.position) - Vector3.Distance(player.transform.position, finish.transform.position))/Vector3.Distance(beginning.transform.position, finish.transform.position);
            Debug.Log("Llenado"+ barraEnergia.fillAmount);

        }
        
       
        

        
            
    }

    

    
}

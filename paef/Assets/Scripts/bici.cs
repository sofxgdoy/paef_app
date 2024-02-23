using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bici : MonoBehaviour
{
    private float startPosX;
    private float startPosY;
    private float speed = 0.5f;
    private bool isBeingHeld= false; //para chequear si se esta agarrando

    // Start is called before the first frame update
    
    // HASTA AHORA ESTA SOLO EL GRAB DEL CLICK.
    // Update is called once per frame
    void Update()
    {
        if(isBeingHeld == true)
        {
            
            Vector3 mousePos;
            mousePos = Input.mousePosition; 
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, 0);

        } else {
            GetComponent<TrailRenderer>().Clear();
           // 

        }
        
    }

    /*void OnCollision2DEnter(Collision2D collision){
        Debug.Log("Collisión?");
        
        
        this.gameObject.transform.localPosition = new Vector3(-7, 3, 0);
        
        
    }*/

    //esto chequea q si choca contra las cuadras retoma su posición inicial
    void OnCollisionEnter2D(Collision2D col){
        Debug.Log("OnCollisionEnter");
        if (col.gameObject.tag == "Cuadras") {
            isBeingHeld=false;
            this.transform.position = new Vector3(0, 0f, 0);
        }
    }

    private void OnMouseDown()  //esto seria el mov con la bici clickeada
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition; 
            mousePos = Camera.main.ScreenToWorldPoint(mousePos); //punto ingame
        
            startPosX = mousePos.x - this.transform.localPosition.x;
            startPosY = mousePos.y - this.transform.localPosition.y;
            isBeingHeld = true;

        }
        


    }

    private void OnMouseUp()  //cuando se suelta el mouse, tmb vuelve a su posición inicial
    {
        isBeingHeld = false;
        this.gameObject.transform.localPosition = new Vector3(0, 0f, 0);

        

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bici : MonoBehaviour
{
    private float startPosX;
    private float startPosY;
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
            this.gameObject.transform.localPosition = new Vector3(-7, 3, 0);

        }
        
    }

    private void OnMouseDown()
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

    private void OnMouseUp()
    {
        isBeingHeld = false;
        

    }
}

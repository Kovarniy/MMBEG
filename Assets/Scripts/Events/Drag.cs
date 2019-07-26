using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.EventSystems;

public class Drag : MonoBehaviour//, IDragHandler, IEndDragHandler
{
   /* 
    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,
                        Input.mousePosition.y, 1));
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }*/

    private bool selected; 

    void Update()
    {
        if(selected == true){
            Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector2(cursorPos.x, cursorPos.y);
        }

        if (Input.GetMouseButtonUp(0)){
            selected = false;
        }

    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            selected = true; 
        }
    }
}

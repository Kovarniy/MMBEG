using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.EventSystems;

public class Drag : MonoBehaviour//, IDragHandler, IEndDragHandler
{

    public string objectName;
    private int speedAnimated = 10;
    private bool selected;
    private Vector3 to;

    private void Start()
    {
        float startX = transform.position.x;
        float startY = transform.position.y;
        to = new Vector3(startX, startY, 0);
    }

    void Update()
    {
        if (selected == true)
        {
            Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector2(cursorPos.x, cursorPos.y);
        }
        if (selected == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, to, Time.deltaTime * speedAnimated);
        }

    }


    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            selected = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            selected = false;
        }
    }

}

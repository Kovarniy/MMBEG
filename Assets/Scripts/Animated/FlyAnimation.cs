using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyAnimation : MonoBehaviour
{
    public float speed;
    [Header("Координаты перемещения. В 2d проектах не рекомендуется менять значения параметра Z")]
    public Vector3 from;
    public Vector3 to;
    private Vector3 target;
   // private Vector3 target = new Vector3 (-34.8f, 50f, 0);

    public void Start()
    {
         //Vector3 target;
    }


    void Update()
    {

        if (target != from && target != to)
        {
         //   print("HIII");
            target = to;
        }

        // Задает изменение позиции из изначальной в Целевую со скоростью Время * скорость
        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
        print(transform.position);

        if (transform.position == target && target != from)
        {
            target = from;
        }      
        else if (transform.position == target && target == from) { 
            target = to;
        }
    }
}

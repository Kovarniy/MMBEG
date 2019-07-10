using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationForHeart : MonoBehaviour
{
    public float speed;
    public Vector3 target;
    // private Vector3 target = new Vector3 (-34.8f, 50f, 0);
    void Update()
    {

        // Задает изменение позиции из изначальной в Целевую со скоростью Время * скорость
        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);

        if (transform.position == target && target.y != 26.9f)
            target.y = 26.9f;
        else if (transform.position == target && target.y == 26.9f)
            target.y = 50f;
    }
}

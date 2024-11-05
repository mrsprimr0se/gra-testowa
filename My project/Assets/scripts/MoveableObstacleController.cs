using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveableObstacleController : MonoBehaviour
{
    public Transform startPoint;
    public Transform endPoint;

    public int speed;

    public bool isMovingRight = true;


    // Update is called once per frame
    void Update()
    {
        if (isMovingRight)
        {
            transform.Translate(1 * Time.deltaTime * speed, 0, 0);

            if (transform.position.x > endPoint.position.x)
            {
                isMovingRight = false;
            }
        }
        else
        {
            transform.Translate(- 1 * Time.deltaTime * speed, 0, 0);

            if (transform.position.x < startPoint.position.x)
            {
                isMovingRight = true;
            }
        }

    }
}

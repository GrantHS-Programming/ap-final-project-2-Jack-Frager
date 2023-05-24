using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotor : MonoBehaviour
{
    public Transform lookAt;
    public float boundx = 0.15f;
    public float boundy = 0.05f;

    private void Start()
    {
        lookAt = GameObject.Find("Player").transform;
    }

    private void LateUpdate()
    {
        Vector3 delta = Vector3.zero;



        // x axis bounds check
        float deltaX = lookAt.position.x - transform.position.x;
        if(deltaX > boundx || deltaX < -boundx)
        {
            if (transform.position.x < lookAt.position.x) 
            {
                delta.x = deltaX - boundx;
            }
            else
            {
                delta.x = deltaX + boundx;
            }
        
        }

        // y axis bounds check
        float deltaY = lookAt.position.y - transform.position.y;
        if (deltaY > boundy || deltaY < -boundy)
        {
            if (transform.position.y < lookAt.position.y)
            {
                delta.y = deltaY - boundy;
            }
            else
            {
                delta.y = deltaY + boundy;
            }

        }

        transform.position += new Vector3(delta.x, delta.y, 0);
    
    }


}

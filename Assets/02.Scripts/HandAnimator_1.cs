using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandAnimator_1 : MonoBehaviour
{
    public Vector3 currentPos;
    public float distanceMax = 1f;
    public float moveSpeed = 2f;
    public Vector3 direction;

    public bool isPress;

    // Start is called before the first frame update
    void Start()
    {
        currentPos = transform.localPosition;
    }

    public void PressButton()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            isPress = true;
        }
        else
        {
            isPress = false;
        }
    }

    public void Obj_Move()
    {
        //if (Input.GetKey(KeyCode.Space))
        {
            direction = currentPos;

            direction.z += distanceMax * Mathf.Sin(Time.time * moveSpeed);

            transform.localPosition = direction;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TargetType{
    Head,
    Left,
    Right,
}

public class Tracking : MonoBehaviour
{
    public TargetType type;

    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(type.ToString());
        target = GameObject.FindGameObjectWithTag(type.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.transform.position;
        transform.rotation = target.transform.rotation;
    }
}

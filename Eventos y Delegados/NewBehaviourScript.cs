using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Vector3 original;
    public float minimun_height;
    // Start is called before the first frame update
    void Start()
    {
        original = GetComponent<Transform>().position;
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<Transform>().position[1] < minimun_height)
        {
            GetComponent<Transform>().position = original;
        }
        
    }
}

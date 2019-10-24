using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider_detector : MonoBehaviour
{
    Renderer rnd;
    public float time;
    public float changing_direction_time;
    // Start is called before the first frame update
    void Start()
    {
        rnd = GetComponent<Renderer>();
        changing_direction_time = 0.25f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        time = Time.time;
        if (collision.gameObject.CompareTag("Player"))
        {
            rnd.material.color = Color.red;
        }
        else if (collision.gameObject.CompareTag("esfera"))
        {
            rnd.material.color = Color.green;
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if(Time.time - time >= changing_direction_time)
            if (collision.gameObject.CompareTag("Player"))
            {
                rnd.material.color = new Color(1, 0.25f, 0.25f, 1);
                }
            else if (collision.gameObject.CompareTag("esfera"))
            {
                rnd.material.color = new Color(0.25f, 1, 0.25f, 1);
            }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            rnd.material.color = new Color(1, 0.5f, 0.5f, 1); 
        }
        else if (collision.gameObject.CompareTag("esfera"))
        {
            rnd.material.color = new Color(0.5f,1,0.5f,1);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class random_move : MonoBehaviour
{
    Rigidbody rb_;
    public float time;
    public float changing_direction_time;
    public int direction;

    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        direction = 4;
        rb_ = GetComponent<Rigidbody>();
        time = Time.time-1;
    }

    // FixedUpdate is called every time the ohysicas are calculated
    void FixedUpdate()
    {
        if (Time.time - time >= changing_direction_time) {
            do
            {
                direction = (int)Random.Range(0.0f, 4.0f);
            } while (direction == 4);

            time = Time.time;
        }

        if (direction == 0)
        {
            rb_.AddForce(Vector3.forward * speed);
        }
        else if (direction == 1)
        {
            rb_.AddForce(Vector3.left * speed);
        }
        else if (direction == 2)
        {
            rb_.AddForce(Vector3.right * speed);
        }
        else if (direction == 3)
        {
            rb_.AddForce(Vector3.back * speed);
        }
        
        
    }
}

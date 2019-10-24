using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movment_with_physics : MonoBehaviour
{
    Rigidbody rb_;
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        rb_ = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal_");
        float moveVertical = Input.GetAxis("Vertical_");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        // Vector3 rotation = new Vector3(0.0f, moveHorizontal  * Time.deltaTime, 0.0f);

        rb_.AddForce(movement*speed);
    }
}

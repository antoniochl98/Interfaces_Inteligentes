using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed_;
    public float angular_speed_;

    Transform tf_;
    Input input_;

    // Start is called before the first frame update
    void Start()
    {
        tf_ = GetComponent<Transform>();
        speed_ = 5.0f;
        angular_speed_ = 70.0f;

    }

    // Update is called once per frame
    void Update()
    {

        /* if (Input.GetKey(KeyCode.W))
         {
             tf_.Translate(Vector3.forward * velocity_ * Time.deltaTime);
         }
         if (Input.GetKey(KeyCode.S))
         {
             tf_.Translate(Vector3.back * velocity_ * Time.deltaTime);
         }
         if (Input.GetKey(KeyCode.A))
         {
             tf_.Translate(Vector3.left * velocity_ * Time.deltaTime);
         }
         if (Input.GetKey(KeyCode.D))
         {
             tf_.Translate(Vector3.right * velocity_ * Time.deltaTime);
         }*/

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(0.0f, 0.0f, moveVertical * speed_ * Time.deltaTime);
        Vector3 rotation = new Vector3(0.0f, moveHorizontal * angular_speed_ * Time.deltaTime, 0.0f);

        tf_.Translate(movement);
        tf_.Rotate(rotation);
    }
}

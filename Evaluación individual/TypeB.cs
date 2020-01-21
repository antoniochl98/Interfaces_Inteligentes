using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeB : MonoBehaviour
{
    // Start is called before the first frame update

    public int poder;

    private void Awake()
    {
        GameController.CollB += MueveC;
    }
    void Start()
    {
       

        GameController.CollisionerB += Cambio;
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Cambio()
    {
        transform.localScale += new Vector3(0, 0.5F, 0);
    }

    private void MueveC(Collision collision)
    {
       
        foreach (GameObject i in GameObject.FindGameObjectsWithTag("TypeC"))
        {
            Debug.Log(collision.impulse.ToString());
            i.GetComponent<Rigidbody>().AddForce(collision.impulse * poder * 30);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        //GameController.CollisionB();
        if (other.gameObject.CompareTag("Player")) 
        {
          
            GameController.CollisionC(other);
        }
            


    }
    private void OnCollisionStay(Collision other)
    {
        //GameController.CollisionB();
        if (other.gameObject.CompareTag("Player"))
        {
            GameController.CollisionC(other);
        }
            

    }

}

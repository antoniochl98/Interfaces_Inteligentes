using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int poder;
    public int energia;
    public int dinero;
    // Start is called before the first frame update
    void Start()
    {
        GameController.CollisionerA += AumentarPoder;
        GameController.CollisionerB += ReducirPoder;
        GameController.ShA += DisparoA;
        GameController.ShB += DisparoB;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void AumentarPoder()
    {
        poder++;
        Debug.Log("poder=" + poder);
    }

    private void ReducirPoder()
    {
        poder--;
        Debug.Log("poder=" + poder);
    }

    private void DisparoA(Collision collision)
    {
        if (collision.gameObject.CompareTag("TypeA"))
        {
            collision.gameObject.GetComponent<TypeA>().poder -= energia;
            collision.gameObject.GetComponent<Transform>().localScale -= new Vector3(0, ((float)energia / 100), 0); 
        }
    }

    private void DisparoB(Collision collision)
    {
        if (collision.gameObject.CompareTag("TypeB"))
        {
            dinero += 50;
            collision.gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            GameController.DisparoA(collision);
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            GameController.DisparoB(collision);
        }

    }

    private void OnCollisionStay(Collision collision)
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            GameController.DisparoA(collision);
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            GameController.DisparoB(collision);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int poder;
    // Start is called before the first frame update
    void Start()
    {
        GameController.CollisionerA += AumentarPoder;
        GameController.CollisionerB += ReducirPoder;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("collision");
        GameController.CollisionA();
    }

    private void AumentarPoder()
    {
        poder++;
        Debug.Log("poder="+poder);
    }

    private void ReducirPoder()
    {
        poder--;
        Debug.Log("poder="+poder);
    }
}

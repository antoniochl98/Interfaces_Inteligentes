using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeB : MonoBehaviour
{
    // Start is called before the first frame update
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

    private void OnCollisionEnter(Collision other)
    {
        GameController.CollisionB();
    }
}

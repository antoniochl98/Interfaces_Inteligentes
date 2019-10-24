using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contador : MonoBehaviour
{
    public int n_golpes;
    // Start is called before the first frame update
    void Start()
    {
        n_golpes = 0; 
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("esfera"))
        {
            n_golpes++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

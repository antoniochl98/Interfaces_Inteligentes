using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{

    
    Light myLight;
    // Start is called before the first frame update
    void Start()
    {
        myLight = GetComponent<Light>();
        GameController.Switch += TurnONOFF;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void TurnONOFF()
    {
        myLight.enabled = !myLight.enabled;
    }
}

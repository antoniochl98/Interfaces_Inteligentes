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
    }

    // Update is called once per frame
    void Update()
    {
        GameController.Switch += TurnONOFF;
    }

    private void TurnONOFF()
    {
        myLight.enabled = !myLight.enabled;
    }
}

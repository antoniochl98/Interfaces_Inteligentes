using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shopping : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BuyEnergy()
    {
        if (GameObject.FindGameObjectsWithTag("Player")[0].GetComponent<Player>().dinero >= 50)
        {
            GameObject.FindGameObjectsWithTag("Player")[0].GetComponent<Player>().energia += 10;
            GameObject.FindGameObjectsWithTag("Player")[0].GetComponent<Player>().dinero -= 50;
        }
    }

    void TaskOnClick()
    {
        //Output this to console when the Button is clicked
        Debug.Log("You have clicked the button!");
    }

}

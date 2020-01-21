using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
   
    public static GameController controlador;
    public delegate void CollisionEvents();
    public static event CollisionEvents CollisionerA;
    public static event CollisionEvents CollisionerB;
    public static event CollisionEvents Switch;
    public delegate void Shooting(Collision collision);
    public static event Shooting ShA;
    public static event Shooting ShB;
    public static event Shooting CollB;
    private void Awake()
    {
        if (controlador == null)
        {
            controlador = this;
            DontDestroyOnLoad(this);
        }else if (controlador != this)
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("F was pressed");
            Switch();
        }
    }

        public static void CollisionA()
    {
        if (CollisionerA != null)
        {
            CollisionerA();
        }
    }

    public static void CollisionB()
    {
        if (CollisionerB != null)
        {
            CollisionerB();
        }
    }

    public static void DisparoA(Collision collision)
    {
        ShA(collision);
    }

    public static void DisparoB(Collision collision)
    {
        
        ShB(collision);
    }
    public static void CollisionC(Collision collision)
    {
        
        if (CollB != null)
        {
            CollB(collision);
        }
        else
        {
            Debug.Log("NULL");
        }
    }


}

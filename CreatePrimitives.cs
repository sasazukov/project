using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePrimitives : MonoBehaviour
{
    // Start is called before the first frame update

    //game object primitve
    void Start()
    {
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(3, 0, 0);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(2, 0, 0);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(1, 0, 0);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(1.5f , 1, 0);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(2.5f , 1, 0);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(2, 2, 0);


    }

    // Update is called once per frame
    void Update()
    {         
    }
}

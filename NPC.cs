using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour  
{
    public int health = 5;
    public int level = 11;
    public int speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        health += level;
        print("Çהמנמגüו NPC"+ health);
        

        
    }

    // Update is called once per frame
    void Update()
    {
     Vector3 newPosition = transform.position;
     newPosition.z += speed * Time.deltaTime;
     transform.position = newPosition;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, 10);
        rb.angularVelocity = 200; //rotation(2d)
        
    }
    private void Update()
    {
        if(transform.position.y < -6)
        {
            print("fruit destroy");
            Destroy(gameObject);
        }
    }
}

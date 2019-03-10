using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canica1Force : MonoBehaviour
{
    Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {

        rb2d = GetComponent<Rigidbody2D>();
        rb2d.AddForce(Vector2.left * 1000, ForceMode2D.Force);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

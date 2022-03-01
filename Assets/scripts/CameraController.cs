using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float xVelocity = 8;
    public int yVelocity = 0;
    private new Rigidbody2D rigidbody;
    void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody2D>();
    }
    void Update()
    {
            rigidbody.velocity = new Vector2(xVelocity, rigidbody.velocity.y);
    }       
}
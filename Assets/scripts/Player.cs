using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int xVelocity = 5;
    public int yVelocity = 5;
    public int gameScore;
    public static bool restart = false;
    private new Rigidbody2D rigidbody;
    void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody2D>();
    }
    void Update()
    {
       
        rigidbody.velocity = new Vector2(xVelocity, rigidbody.velocity.y);
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetButtonDown("Fire1"))
        {
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, yVelocity);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Yes")
        {
            gameScore++;
            print(gameScore);
        }
        if(collision.tag == "No")
        {
            gameScore--;
            print(gameScore);
        }
        if(collision.tag == "Respawn")
        {
            SceneManager.LoadScene(0);
        }
        if(collision.tag == "Finish")
        {
            SceneManager.LoadScene(2);
        }
    }
}
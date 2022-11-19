using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody2D rb2d;
    public float speed = 10;
    public float jumpPower = 50;
    private SpriteRenderer sprite;
    public bool FreezeControlls = false;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (FreezeControlls == false) { 
            if (Input.GetKeyDown("space")&&Mathf.Abs(rb2d.velocity.y)<=0.05)
            {
                rb2d.AddForce(Vector2.up * jumpPower,ForceMode2D.Impulse);
            }
            if (Input.GetKey("d"))
            {
                rb2d.velocity = new Vector2(speed,rb2d.velocity.y);
                sprite.flipX = true;
            }
                else if (Input.GetKey("a"))
                {
                rb2d.velocity = new Vector2(-speed, rb2d.velocity.y);
                sprite.flipX = false;
            }
            else
            {
                rb2d.velocity = new Vector2(0, rb2d.velocity.y);
            }
        }
    }
}

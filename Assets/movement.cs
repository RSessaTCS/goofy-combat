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
    private Animator animator;
    private bool RightPunch = false;
    public weapon Weapon;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
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
                transform.localScale=new Vector3(-1f,1f,1f);
            }
                else if (Input.GetKey("a"))
                {
                rb2d.velocity = new Vector2(-speed, rb2d.velocity.y);
                transform.localScale = new Vector3(1f, 1f, 1f);
            }
            
            else
            {
                rb2d.velocity = new Vector2(0, rb2d.velocity.y);
            }
            if (Input.GetMouseButtonDown(0))
            {
                if (Weapon)
                {
                    animator.SetTrigger("LeftPunch");
                }

                else
                {


                    if (RightPunch)
                    {
                        animator.SetTrigger("RightPunch");
                    }
                    else
                    {
                        animator.SetTrigger("LeftPunch");
                    }
                    RightPunch = !RightPunch; 
                }
            }   
        }
    }
}
/* 
  if (Input.GetMouseButtonDown(0))
            {
                
                
                
                if (RightPunch)
                {
                    animator.SetTrigger("RightPunch");
                }
                else
                {
                    animator.SetTrigger("LeftPunch");
                }
                RightPunch = !RightPunch;
            }
*/
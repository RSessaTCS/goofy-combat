using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class weapon : MonoBehaviour
{
    internal bool Inuse=false;
    internal movement User;
    internal bool fadeIn=true;
    public SpriteRenderer WeaponSprite;
    public float fadeSpeed;
    public float damage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (fadeIn)
        {
            float fadeAlpha = WeaponSprite.color.a + (fadeSpeed * Time.deltaTime);
            WeaponSprite.color = new Color(WeaponSprite.color.r, WeaponSprite.color.g, WeaponSprite.color.b, fadeAlpha);
            Debug.Log(fadeAlpha);
            if (fadeAlpha >= 1)
            {
                fadeIn = false;
            }

        }
    }
        
    void OnTriggerEnter2D(Collider2D other) 
    {

        movement move = other.GetComponent<movement>();
        Health health = other.GetComponent<Health>();
        if (Inuse && (!move || (move && move!=User)) && health)
        {
            health.health -= damage;
            Debug.Log("im hit");
        }
    }
    
}

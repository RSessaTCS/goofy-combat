using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupWeapon : MonoBehaviour
{
    public GameObject WeaponTransform;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter2D(Collider2D other) {
    // if i hit a weapon
    if (other.GetComponent<weapon>()&&GetComponent<movement>()&&other.GetComponent<weapon>().Inuse==false)
        {
        //  attach weapon to the player
        other.transform.position=WeaponTransform.transform.position;
            other.transform.rotation=WeaponTransform.transform.rotation;
            other.transform.parent=WeaponTransform.transform;
            //  store the weapon as a varieable (so we can access it later)
            GetComponent<movement>().Weapon = other.GetComponent<weapon>();
            other.GetComponent<weapon>().Inuse = true;
        }
    
    
    }
}

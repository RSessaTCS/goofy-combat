using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class freezeOnTouch : MonoBehaviour
{
    public bool thawControlls = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D Other)
    {
        movement mScript = Other.gameObject.GetComponent<movement>();
        if(mScript != null)
        {
            mScript.FreezeControlls = !thawControlls;
        }
    }
}

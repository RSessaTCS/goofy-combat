using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    public Vector3 resetPos;
    public bool teleportX = true;
    public bool teleportY = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        float x = other.transform.position.x;
        float y = other.transform.position.y;
        if (teleportX)
        {
            x = resetPos.x;
        }
        if (teleportY)
        {
            y = resetPos.y;
        }
        other.transform.position = new Vector3(x,y,0);
    }
}

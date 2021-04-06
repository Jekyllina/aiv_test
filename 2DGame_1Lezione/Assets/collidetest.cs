using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collidetest : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
    	Debug.Log("Colliding with " + collision.gameObject.tag);
    }
}

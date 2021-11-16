using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile_Behavior : MonoBehaviour
{

    void OnBecameInvisible() 
    {
        Destroy(gameObject);
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag.Equals("Wall"))
        {
            Destroy(this.gameObject);
        }
        if(col.gameObject.tag.Equals("Enemy"))
        {
            Destroy(this.gameObject);
        }
    }
}

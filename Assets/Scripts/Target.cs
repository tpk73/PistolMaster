using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public int targetHealth = 2;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            targetHealth--;

            if(targetHealth == 0)
            {
                Destroy(gameObject);
            }
        }
    }
}

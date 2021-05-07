using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewClip : MonoBehaviour
{

    public GameObject Magazine;
    public Transform magLoc;

    private void OnTriggerExit(Collider other)
    {
        Instantiate(Magazine);
        transform.position = magLoc.position;
    }
}

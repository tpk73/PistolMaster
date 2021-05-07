using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndBarrier : MonoBehaviour
{
    public GameObject endWall;
    private void OnCollisionEnter(Collision collision)
    {

        this.gameObject.SetActive(false);
        //endWall.SetActive(false);
    }

    private void OnCollisionExit(Collision collision)
    {
        this.gameObject.SetActive(true);
        //endWall.SetActive(true);
    }
}
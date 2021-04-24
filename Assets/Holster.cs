using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Holster : MonoBehaviour
{
    public GameObject centerEyeAnchor;
    private float rotSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(centerEyeAnchor.transform.position.x, centerEyeAnchor.transform.position.y/2, centerEyeAnchor.transform.position.z);

        var rotDifference = Mathf.Abs(centerEyeAnchor.transform.eulerAngles.y - transform.eulerAngles.y);
        var finalRotSpeed = rotSpeed;

        if(rotDifference > 60)
        {
            finalRotSpeed = rotSpeed * 2;
        }
        else if ( rotDifference > 40 && rotDifference < 60)
        {
            finalRotSpeed = rotSpeed;
        }
        else if (rotDifference < 40 && rotDifference > 20)
        {
            finalRotSpeed = rotSpeed / 2;
        }
        else if(rotDifference < 20 && rotDifference > 0)
        {
            finalRotSpeed = rotSpeed / 4;
        }

        var step = finalRotSpeed * Time.deltaTime;

        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, centerEyeAnchor.transform.eulerAngles.y, 0), step);
    }
}

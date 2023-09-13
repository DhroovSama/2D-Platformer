using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{

    public float speed = 200;


    void Update()
    {
        this.transform.localEulerAngles = new Vector3(
            this.transform.position.x,
            this.transform.position.y,
            this.transform.position.z + speed * Time.deltaTime
        );
    }
}

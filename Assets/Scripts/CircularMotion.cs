using UnityEngine;
using System.Collections;
using System;

public class CircularMotion : MonoBehaviour {
    float angle = 0;
    float speed = (2 * Mathf.PI) / 5; //2*PI in degress is 360, so you get 5 seconds to complete a circle
    float radius = 5;
    float x, y;

    void Update()
    {
        angle += speed * Time.deltaTime; 
        x = Mathf.Cos(angle)*radius;
        y = Mathf.Sin(angle)*radius;

        transform.position = new Vector3(x, 0.75f, y);

    }
}
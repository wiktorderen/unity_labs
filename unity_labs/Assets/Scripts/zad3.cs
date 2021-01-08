using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zad3 : MonoBehaviour
{
    public float speed;
    public Vector3[] points;
    private int nextPointIndex = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if ((Vector3)transform.position == points[nextPointIndex])
        {
            nextPointIndex = (nextPointIndex + 1) % points.Length;
            transform.Rotate(0, 90, 0);
        }

        transform.position = Vector3.MoveTowards(transform.position, points[nextPointIndex], speed * Time.deltaTime);
    }
}

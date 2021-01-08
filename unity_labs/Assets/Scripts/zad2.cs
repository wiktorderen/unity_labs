using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zad2 : MonoBehaviour
{
    public float speed;
    int direction = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 10)
            direction = -1;
        else if (transform.position.x < 0)
            direction = 1;

        transform.Translate(Vector3.right * direction * speed * Time.deltaTime);
    }
}

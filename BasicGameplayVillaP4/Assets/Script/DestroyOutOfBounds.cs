using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private float topBound = 30f;
    private float lowerBound = -10;

    void Update() { 
    {
        if (transform.position.z > 50)
        {
            Destroy(gameObject);
        } else if (transform.position.z < lowerBound)
            Destroy(gameObject);
    } } 
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovement : MonoBehaviour
{

    public float AsteroidSpeed = 5f;
    public float AsteroidFlip = 90f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * AsteroidSpeed * Time.deltaTime);
        
    }

    void OnCollisionEnter2D (Collision2D wallCollision)
    {
        transform.Rotate(Vector3.back * AsteroidFlip);
        Debug.Log("Hello");
    }

}

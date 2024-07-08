using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{

    public float speed = 2f;

    void Start()
    {

    }


    void Update()
    {

    }

    void FixedUpdate()
    {
        transform.Translate(Vector2.left * speed * Time.fixedDeltaTime);

        if (transform.position.x < -10)
        {
            Destroy(gameObject);
        }
    }
}

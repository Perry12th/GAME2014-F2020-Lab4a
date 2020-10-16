using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] float horizontalSpeed;
    [SerializeField] float horizontalBoundary;

    float direction;
    // Start is called before the first frame update
    void Start()
    {
        direction = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _CheckBounds()
    {
        /// check if on the right boundry
        if (transform.position.x >= horizontalBoundary)
        {
            direction = -1.0f;
        }

        /// check if on the right boundry
        else if (transform.position.x <= -horizontalBoundary)
        {
            direction = 1.0f;
        }
    }

    private void _Move()
    {
        transform.position += new Vector3(horizontalSpeed * direction * Time.deltaTime, 0.0f, 0.0f);
    }

    
}

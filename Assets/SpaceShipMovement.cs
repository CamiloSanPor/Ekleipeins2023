using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipMovement : MonoBehaviour
{
    public float movementSpeed = 0.5f;
    public float downwardSpeed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * Time.deltaTime * movementSpeed;
        transform.position += Vector3.down * Time.deltaTime * downwardSpeed;

    }
}

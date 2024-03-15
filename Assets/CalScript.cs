using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public CapsuleCollider2D capsuleCollider;
    public float upVelocity;
    public float groundSpeed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            myRigidBody.velocity = Vector2.up * upVelocity;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += (Vector3.right*groundSpeed) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += (Vector3.left*groundSpeed) * Time.deltaTime;
        }
    }
}

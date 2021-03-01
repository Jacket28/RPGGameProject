using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMotor : MonoBehaviour
{

    Animation animations;

    public float walkSpeed;
    public float runSpeed;
    public float turnSpeed;

    public string inputFront;
    public string inputBack;
    public string inputLeft;
    public string inputRight;

    public Vector3 jumpSpeed;
    CapsuleCollider playerCollider;

    // Start is called before the first frame update
    test
    void Start()
    {
        animations = gameObject.GetComponent<Animation>();
        playerCollider = gameObject.GetComponent<CapsuleCollider>();


    }

    bool IsGrounded()
    {
        Vector3 dwn = transform.TransformDirection(Vector3.down);

        return (Physics.Raycast(transform.position, dwn, 1));
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(inputFront)&& !Input.GetKey(KeyCode.LeftShift))
        {
            transform.Translate(0,0, walkSpeed * Time.deltaTime);
            animations.Play("walk");
        }

        if (Input.GetKey(inputBack))
        {
            transform.Translate(0, 0, -(walkSpeed/2) * Time.deltaTime);
            animations.Play("walk");
        }

        if (Input.GetKey(inputLeft))
        {
            transform.Rotate(0, -turnSpeed * Time.deltaTime, 0);
        }

        if (Input.GetKey(inputRight))
        {
            transform.Rotate(0, turnSpeed * Time.deltaTime, 0);
        }

        if (Input.GetKey(inputFront)&& Input.GetKey(KeyCode.LeftShift))
        {
            transform.Translate(0, 0, runSpeed * Time.deltaTime);
            animations.Play("run");
        }

        if (!Input.GetKey(inputBack) && !Input.GetKey(inputFront))
        {
            animations.Play("idle");
        }

        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            Vector3 v = gameObject.GetComponent<Rigidbody>().velocity;
            v.y = jumpSpeed.y;

            gameObject.GetComponent<Rigidbody>().velocity = jumpSpeed;
        }


    }
}

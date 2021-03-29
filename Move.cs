using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    private float moveX;
    private float moveY;
    CharacterController characterController;
    private Vector3 moveDirection = Vector3.zero;
    public static int speed =7;
    public static int baseSpeed = 7;

    // Start is called before the first frame update
    void Start()
    {
        speed = baseSpeed;
        characterController = GetComponent<CharacterController>();
        GetComponent<Animator>().SetInteger("Direction", 0);
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");
        if (!Input.GetKey("up") && !Input.GetKey("down") && !Input.GetKey("left") && !Input.GetKey("right"))
        {
            if (Input.GetKey("w"))
            {
                if (Input.GetKey("d"))
                {
                    GetComponent<Animator>().SetInteger("Direction", 2);
                }
                else if (Input.GetKey("a"))
                {
                    GetComponent<Animator>().SetInteger("Direction", 8);
                }
                else
                {
                    GetComponent<Animator>().SetInteger("Direction", 1);
                }
            }
            else if (Input.GetKey("s"))
            {
                if (Input.GetKey("d"))
                {
                    GetComponent<Animator>().SetInteger("Direction", 4);
                }
                else if (Input.GetKey("a"))
                {
                    GetComponent<Animator>().SetInteger("Direction", 6);
                }
                else
                {
                    GetComponent<Animator>().SetInteger("Direction", 5);
                }
            }
            else if (Input.GetKey("a"))
            {
                GetComponent<Animator>().SetInteger("Direction", 7);
            }
            else if (Input.GetKey("d"))
            {
                GetComponent<Animator>().SetInteger("Direction", 3);
            }
        }
        moveDirection = new Vector3(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed, 0.0f);
        characterController.Move(moveDirection * Time.deltaTime);
    }
}

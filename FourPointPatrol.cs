using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FourPointPatrol : MonoBehaviour {
    public Transform pointA;
    public Transform pointB;
    public Transform pointC;
    public Transform pointD;
    int Direction;
    public float speed = 0.3f;
    private Vector2 pointAPosition;
    private Vector2 pointBPosition;
    private Vector2 pointCPosition;
    private Vector2 pointDPosition;
    // Use this for initialization
    void Start()
    {
        pointAPosition = new Vector2(pointA.position.x, pointA.position.y);
        pointBPosition = new Vector2(pointB.position.x, pointB.position.y);
        pointCPosition = new Vector2(pointC.position.x, pointC.position.y);
        pointDPosition = new Vector2(pointD.position.x, pointD.position.y);
        Direction = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 thisPosition = new Vector3(transform.position.x, 0, 0);
        if (Direction == 1)
        {
            GetComponent<Animator>().SetInteger("Direction", 1);
            Boss2.direction = 1;
            Boss2F.direction = 1;
            transform.position = Vector2.MoveTowards(transform.position, pointBPosition, speed);
            if (transform.position.Equals(pointBPosition))
            {
                //Debug.Log ("Position b");
                Direction = 2;
                //GetComponent<SpriteRenderer>().flipX = true;
            }
        }
        else if (Direction == 2)
        {
            GetComponent<Animator>().SetInteger("Direction", 2);
            Boss2.direction = 2;
            Boss2F.direction = 2;
            transform.position = Vector2.MoveTowards(transform.position, pointCPosition, speed);
            if (transform.position.Equals(pointCPosition))
            {
                //Debug.Log ("Position b");
                Direction = 3;
                //GetComponent<SpriteRenderer>().flipX = true;
            }
        }else if (Direction == 3)
        {
            GetComponent<Animator>().SetInteger("Direction", 3);
            Boss2.direction = 3;
            Boss2F.direction = 3;
            transform.position = Vector2.MoveTowards(transform.position, pointDPosition, speed);
            if (transform.position.Equals(pointDPosition))
            {
                //Debug.Log ("Position b");
                Direction = 4;
                //GetComponent<SpriteRenderer>().flipX = true;
            }
        }else if (Direction == 4)
        {
            GetComponent<SpriteRenderer>().flipX = true;
            GetComponent<Animator>().SetInteger("Direction", 2);
            Boss2.direction = 4;
            Boss2F.direction = 4;
            transform.position = Vector2.MoveTowards(transform.position, pointAPosition, speed);
            if (transform.position.Equals(pointAPosition))
            {
                //Debug.Log ("Position b");
                Direction = 1;
                GetComponent<SpriteRenderer>().flipX = false;
            }
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemonMovement : MonoBehaviour
{
    [Header("Component / Objects to catch")]
    [SerializeField]
    public GameObject circle;
    [SerializeField]
    public Rigidbody2D rb;
    [Header("Local variables")]
    /*public int angle_min;
    public int angle_max;
    public int extra_space;
    private Vector2 circle_bounds;
    private Vector3 Circular;
    private float angle;*/
    private Vector3 input_movement;
    public static float movement_speed;
    //COMMENTED STUFF WAS FOR CIRCLE MOVING PURPOSES 
    void Start()
    {
        movement_speed = DemonSettings.movement_speed;
/*
        angle = 1.5f;
        circle_bounds = circle.GetComponent<CircleCollider2D>().bounds.extents;
*/
    }

    private void FixedUpdate()
    {
        input_movement = new Vector2(Input.GetAxisRaw("HorizontalArrows"), 0);

        if (input_movement.x != 0)
        {
            //MoveAround(input_movement);
            Move(input_movement.x);
        }
    }
    void Update()
    {
        

    }

    private void Move(float input_move)
    {
        Vector3 new_pos = new Vector3(input_move *Time.deltaTime* movement_speed, 0f);
        rb.MovePosition(transform.position + Time.deltaTime * input_movement * movement_speed);
    }
    /*
    private void MoveAround(float input_move)
    {
        // chaing vector3 values
        Circular.Set(
              Mathf.Cos(angle) * (circle_bounds.x + extra_space) ,  // x axis
              Mathf.Sin(angle) * (circle_bounds.y + extra_space) ,  // y axis
              0                                           // z axis about which we dont care at this point
        );
        transform.position = circle.transform.position + Circular;
        angle += (Time.deltaTime * input_move) *-1;
        //Vector3 rotation = Vector3.RotateTowards(transform.position, player.transform.position, 1f, 1f);
        //transform.rotation = Quaternion.LookRotation(rotation);
    }*/
}

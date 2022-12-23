using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    private Vector3 input;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        input = new Vector3(Input.GetAxis("HorizontalAD"), Input.GetAxis("VerticalWS"),0);
        rb.MovePosition(transform.position + input * Time.deltaTime * HumanSettings.movement_speed);

       
    }
    private void Update()
    {
    }
}

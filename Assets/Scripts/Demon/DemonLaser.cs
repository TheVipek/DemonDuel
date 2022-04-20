using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemonLaser : MonoBehaviour
{
    private float use_time = 0f;
    private float frequency_damage = 0f;
    private float reduced_movement;
    void Start()
    {
        reduced_movement = DemonSettings.movement_speed / 3;
        Debug.Log(reduced_movement);
        DemonMovement.movement_speed = reduced_movement;
        frequency_damage = DemonSettings.laser_frequency;
    }

    // Update is called once per frame
    void Update()
    {
        frequency_damage += Time.deltaTime;
        use_time += Time.deltaTime;

        if(use_time >= DemonSettings.laser_duration)
        {
            DemonMovement.movement_speed = DemonSettings.movement_speed;
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Human")
        {
            if (frequency_damage >= DemonSettings.laser_frequency)
            {
                HumanHealthController.actual_health -= DemonSettings.laser_dmg;
                frequency_damage = 0f;
            }
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Human")
        {
            if(frequency_damage >= DemonSettings.laser_frequency)
            {
                HumanHealthController.actual_health -= DemonSettings.laser_dmg;
                frequency_damage = 0f;
            }
        }
    }
}

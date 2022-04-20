using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemonHealthController : MonoBehaviour
{
    
    public static int actual_health;
    void Start()
    {
        actual_health = DemonSettings.health;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "HumanBullet")
        {
            Debug.Log(actual_health);
            actual_health -= HumanSettings.bullet_damage;
            if (actual_health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}

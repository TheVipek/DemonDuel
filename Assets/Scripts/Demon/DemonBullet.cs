using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemonBullet : MonoBehaviour
{
    public Rigidbody2D rb;
    private Vector2 start_position;
    void Start()
    {
        start_position = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Human")
        {
            HumanHealthController.actual_health -= DemonSettings.basic_attack_dmg;
            Destroy(gameObject);
        }
        Physics2D.IgnoreCollision(GetComponent<Collider2D>(), collision.gameObject.GetComponent<Collider2D>());
    }


}

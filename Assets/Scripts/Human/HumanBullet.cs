using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanBullet : MonoBehaviour
{
    public Rigidbody2D rb;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Demon")
        {
            Destroy(gameObject);

        }
    }
    
}

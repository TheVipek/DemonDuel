using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanShooting : MonoBehaviour
{
    [SerializeField]
    public GameObject bullet;
    private float cd_bullet = HumanSettings.shooting_cd;
    
    void Start()
    {
        
    }
    void Update()
    {
        cd_bullet += Time.deltaTime;
        // shoot if player is pressing mouse button && cd is over 
        if (Input.GetKey(KeyCode.Space) && cd_bullet >=HumanSettings.shooting_cd)
        {
            GameObject bullet_instance = Instantiate(bullet, transform.position, Quaternion.identity);
            bullet_instance.GetComponent<Rigidbody2D>().velocity = transform.right * HumanSettings.shoot_speed;
            cd_bullet = 0;
        }
    }

}

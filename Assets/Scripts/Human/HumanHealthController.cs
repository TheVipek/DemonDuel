using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanHealthController : MonoBehaviour
{
    public static int actual_health;
    public GameObject PlayerHP;
    private bool coroutine_running=false;
    void Start()
    {
        actual_health = HumanSettings.health;
        //Show_Health();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DemonBullet")
        {
            Show_Health();
            if (actual_health <= 0)
            { 
                //GO TO UPGRADE SCREEN
            }
        }
    }
    
    IEnumerator Health_Coroutine()
    {
        coroutine_running = true;
        PlayerHP.SetActive(true);
        yield return new WaitForSeconds(2f);
        PlayerHP.SetActive(false);
        coroutine_running = false;
        yield return null;
    }

    public void Show_Health()
    {
        if (!coroutine_running)
        {
            StartCoroutine(Health_Coroutine());
        }
        else
        {
            StopCoroutine(Health_Coroutine());
            StartCoroutine(Health_Coroutine());
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "DemonBullet")
        {
            Show_Health();
            if (actual_health <= 0)
            {
                //GO TO UPGRADE SCREEN
            }
        }
    }
    */
}

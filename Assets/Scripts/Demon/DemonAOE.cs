using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemonAOE : MonoBehaviour
{
    public bool anim_completed = false;
    void Start()
    {
        
        StartCoroutine(SpawnActions());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    IEnumerator SpawnActions() {
        yield return new WaitForSeconds(1);
        anim_completed = true;
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
        yield return null;
    
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Human")
        {
            
            if (anim_completed)
            {
                HumanHealthController.actual_health -= DemonSettings.aoe_dmg;
                //anim_completed = false;
                Debug.Log("Human touched");
                anim_completed = false;
            }
        }
    }

}

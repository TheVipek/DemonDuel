using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemonAttack : MonoBehaviour
{
    //SPELL 1 - basic attack
    [Header ("Spell 1 ")]
    public GameObject bullet;
    private float bullets_min_spread = -0.6f;
    private float actual_bullets_spread;
    public KeyCode basic_attack_bind;
    private float basic_attack_cd;

    //SPELL 2 - laser
    [Header("Spell 2 ")]
    public GameObject laser;
    public KeyCode laser_bind;
    private float laser_cd;

    //SPELL 3 - AOE 
    [Header("Spell 3 ")]
    public GameObject AOE_gameobject;
    public KeyCode aoe_bind;
    private float aoe_cd;

    //SPELL 4 - Spawn Mobs
    [Header("Spell 4 ")]
    public GameObject monster;
    public List<Transform> monsters_spawning_positions;
    public KeyCode mob_bind;
    private float mob_cd;
    private int random;
    private int prev_random;

    //SPELL 5 - Spawn turrets
    [Header("Spell 5 ")]
    public GameObject turret;
    public KeyCode turret_bind;
    private float turret_cd;

    void Start()
    {
        basic_attack_cd = DemonSettings.basic_attack_cd;
        laser_cd = DemonSettings.laser_cd;
        aoe_cd = DemonSettings.aoe_cd;
    }

    // Update is called once per frame
    void Update()
    {
        cd_refresh();
        if (Input.GetKeyDown(basic_attack_bind) && basic_attack_cd >= DemonSettings.basic_attack_cd)
        {
            Shoot();
            basic_attack_cd = 0;
        }
        else if (Input.GetKeyDown(laser_bind) && laser_cd >= DemonSettings.laser_cd)
        {
            //SpawningMonsters();
            CastLaser();
            laser_cd = 0;
        }
        else if (Input.GetKeyDown(aoe_bind) && aoe_cd >= DemonSettings.aoe_cd)
        {
            CastAOE();
            aoe_cd = 0;
        }
    }

    
    private void cd_refresh()
    {
        basic_attack_cd += Time.deltaTime;
        laser_cd += Time.deltaTime;
        aoe_cd += Time.deltaTime;

    }

    /// <summary>
    /// spawning two monsters at one of array positions ,also cant be at the same 
    /// </summary>
    private void SpawningMonsters()
    {
        for(int i = 0; i < 2; i++)
        {
            random = Random.Range(0, monsters_spawning_positions.Count);
            while (true)
            {
                if(prev_random == random)
                {
                    random = Random.Range(0, monsters_spawning_positions.Count);
                }
                else
                {
                    break;
                }
            }
            Transform pos = monsters_spawning_positions[random];
            Instantiate(monster, pos.position, Quaternion.Euler(pos.rotation.eulerAngles));
            prev_random = random;
        }
    }
    private void Shoot()
    {
        actual_bullets_spread = bullets_min_spread;
        
        
        for (int i = 5; i > 0; i--)
        {
            Vector3 dir = transform.right + new Vector3(actual_bullets_spread, 0, actual_bullets_spread);
            GameObject bullet_instance = Instantiate(bullet, position: gameObject.transform.position, transform.rotation);
            //bullet_instance.transform.rotation = Quaternion.Euler(dir);
            bullet_instance.GetComponent<Rigidbody2D>().velocity = dir *25f;
            actual_bullets_spread += 0.3f;
        }
        
        /*Vector3 dir = transform.right;
        GameObject bullet_instance = Instantiate(bullet, position: gameObject.transform.position, transform.rotation);
        bullet_instance.GetComponent<Rigidbody2D>().velocity = dir * DemonSettings.bullets_speed;*/
    }
  /*  private void DrawLines()
    {
        Debug.DrawLine(transform.position, transform.position + (transform.forward *new Vector3(-4f, 0, 0)),Color.red);
        Debug.DrawLine(transform.position, transform.forward*5, Color.red);
        Debug.DrawLine(transform.position, transform.rotation * new Vector3(0, 0, 0.0f), Color.red);
        Debug.DrawLine(transform.position, transform.rotation * new Vector3(2f, 0, 0), Color.red);
        Debug.DrawLine(transform.position, transform.rotation * new Vector3(4f, 0, 0), Color.red);
        
    }
  */






    private void CastLaser()
    {
        GameObject laser_clone =Instantiate(laser, parent:gameObject.transform.parent,true);
        laser_clone.transform.position = new Vector3(transform.position.x,laser_clone.transform.position.y,laser_clone.transform.position.z);
    }
  private void CastAOE()
    {
        Instantiate(AOE_gameobject, position: MouseCursor.mouse_position,Quaternion.identity);
    }
}

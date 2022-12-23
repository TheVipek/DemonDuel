using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemonSettings
{
    //BASE
    public static int health = 300;
    public static float movement_speed = 25f;
    //SPELL1
    public static float bullet_speed = 22f;
    public static float basic_attack_cd = 1f;
    public static int basic_attack_dmg = 15;
    //SPELL2
    public static float laser_cd = 10f;
    public static int laser_dmg = 3;
    public static float laser_duration = 5f;
    public static float laser_frequency = 0.1f;
    public static float speed_during_laser = movement_speed / 2;
    //SPELL3
    public static float aoe_cd = 8f;
    public static int aoe_dmg = 35;
    //SPELL4
    public static float mobs_cd = 15f;
    public static int mobs_dmg = 20;
    //SPELL5
    public static float towers_cd = 20f;
    public static int towers_dmg = 25;
}

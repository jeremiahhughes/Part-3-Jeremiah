using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


public class Thief : Villager
{
    Animator animator;
    public ChestType whoCanOpen;
    public GameObject knifePrefab;
    public Transform spawnPoint;
    public Transform spawnPoint2;
    private bool attack = false;

    public override ChestType CanOpen()
    {
        return ChestType.Thief;
    }
    protected override void Attack()
    {
        dash();
        destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        base.Attack();
        Instantiate(knifePrefab, spawnPoint.position, spawnPoint.rotation);
        Instantiate(knifePrefab, spawnPoint2.position, spawnPoint2.rotation);
        if(Input.GetMouseButtonDown(0))
        {
            speed = 3;
            attack = false;
        }
         void dash()
        {
            if(attack == true) 
            {
                speed = 20;
            }
            if(attack == false)
            {
                speed = 3;
            }
        }
    }
}

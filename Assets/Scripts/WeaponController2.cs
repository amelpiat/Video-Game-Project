using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController2 : MonoBehaviour
{
    public GameObject Sword, Postel;
    public bool CanAttack = true;
    public float AttackCooldown = 1.0f;
    public bool isAttacking = false;

    public AudioSource swordSound;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            swordSound.Play();
            
        }
    }

    public void SwordAttack()
    {
        
        Animator anim = Sword.GetComponent<Animator>();      

    }

 

   
}

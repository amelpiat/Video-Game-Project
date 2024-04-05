using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    public WeaponController wc;
    public GameObject HitParticle;
    public AudioSource enemyDeathSound;

    int count = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy" && wc.isAttacking)
        {
            count++;
            enemyDeathSound.Play();
            Debug.Log(other.name);
            other.GetComponent<Animator>().SetTrigger("Hit");


            if (count >= 3)
            {
                Destroy(other.gameObject);
            }
            //Instantiate(HitParticle, new Vector3(other.transform.position.x, transform.position.y, other.transform.position.z), other.transform.rotation);
            //Destroy(other.gameObject);
        }
    }
}

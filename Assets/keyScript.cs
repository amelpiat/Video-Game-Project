using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyScript : MonoBehaviour
{
    public GameObject doorCollider;
    // Start is called before the first frame update
    void Start()
    {
        doorCollider.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "princess")
        {
            doorCollider.SetActive(true);
            Destroy(gameObject);
        }
    }
}

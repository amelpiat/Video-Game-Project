using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pinkPotionScript : MonoBehaviour
{
    public GameObject Princess;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Princess")
        {
            //Add 1 to points.
            Destroy(gameObject); //This Destroys
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pinkPotionScript : MonoBehaviour
{
<<<<<<< HEAD
    public GameObject Princess;
    public Image healthBar; 

=======
    public GameObject PrincessVarient;
>>>>>>> 3b72bb0e6cc993f58eaadc5e07e3707aa63a3381
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

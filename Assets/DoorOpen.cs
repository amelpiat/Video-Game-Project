using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    
    public GameObject Instruction;
    public GameObject AnimeObject;
    public bool Action = false;
    // Start is called before the first frame update
    void Start()
    {
        Instruction.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "princess")
        {
            Instruction.SetActive(true);
            Action = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        Instruction.SetActive(false);
        Action = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Action == true)
            {
                Instruction.SetActive(false);
                AnimeObject.GetComponent<Animator>().Play("OpenDoor3");
                Action = false;
            }
        }
    }


}

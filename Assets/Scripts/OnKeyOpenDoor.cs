using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnKeyOpenDoor : MonoBehaviour
{
    public GameObject Instruction;
    public GameObject AnimeObject;
    public bool Action = false;
    bool gotKey;
    // Start is called before the first frame update
    void Start()
    {
        Instruction.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "princess")
        {
            Instruction.SetActive(false);

            AnimeObject.GetComponent<Animator>().Play("DoorOpen");
            Action = false;

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
        




        //if (Input.GetKeyDown(KeyCode.E))
        //{
        //    if (Action == true)
        //    {
        //        Instruction.SetActive(false);
         //       AnimeObject.GetComponent<Animator>().Play("DoorOpen");
        //        Action = false;
         //   }
       // }
    }

}

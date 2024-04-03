using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressKeyDown : MonoBehaviour
{
    public GameObject Instructions;
    public GameObject AnimeObject;
    public bool Action = false;
    // Start is called before the first frame update
    void Start()
    {
        Instructions.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "princess")
        {
            Instructions.SetActive(true);
            Action = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        Instructions?.SetActive(false);
        Action = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if(Action == true)
            {
                Instructions.SetActive(false);
                AnimeObject.GetComponent<Animator>().Play("DoorOpen");
                Action = false;
            }
        }
    }
}

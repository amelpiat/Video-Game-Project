using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine.UI;
using UnityEngine;

public class HealthBarBehaviour : MonoBehaviour
{
    //use a controller to determine when the main character collides with weapons or health items 
    CharacterController controller;

    public Image healthBar;
    public float healthAmount = 100f;

    //values defined by the user 
    int damage;
    int heal;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //if the user has health less than 0, they restart the level and the scene reloads 
        if (healthAmount <= 0)
        {
            Application.LoadLevel(Application.loadedLevel);
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            DecreaseHealth(damage);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            IncreaseHealth(heal);
        }
    }

    public void DecreaseHealth(int damage)
    {
        healthAmount -= damage;
        healthBar.fillAmount = healthAmount / 100f;
    }

    public void IncreaseHealth(int heal)
    {
        healthAmount += heal;
        healthAmount = Mathf.Clamp(healthAmount, 0, 100);

        healthBar.fillAmount = healthAmount / 100f;
    }
}
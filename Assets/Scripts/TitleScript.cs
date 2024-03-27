using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TitleScript : MonoBehaviour
{
    TMP_Text title;
    string level;

    // Start is called before the first frame update
    void Start()
    {
        title.SetText(level);

        StartCoroutine(clearTitle());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator clearTitle()
    {
        yield return new WaitForSeconds(5);

        title.SetText("");
    }
}

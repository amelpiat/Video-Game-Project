using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace key
{
    public class getKey : MonoBehaviour
    {
        public static bool gotKey = false;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        static void OnTriggerEnter(Collider other)
        {
            Debug.Log(gotKey);
            gotKey = true;
        }
    }
}

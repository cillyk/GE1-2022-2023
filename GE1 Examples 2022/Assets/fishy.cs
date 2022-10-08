using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class fishy : MonoBehaviour
{
    public int frequency = 1;
    public GameObject head;
    public GameObject tail;
    // Start is called before the first frame update
    void Start()
    {
        GameObject head = GameObject.FindGameObjectWithTag("head");
        GameObject tail = GameObject.FindGameObjectWithTag("tail");
  
    }

    // Update is called once per frame
    void Update()
    {
        head.transform.Rotate(1,0,0, Space.Self);
        tail.transform.Rotate(1,0,0, Space.Self);
    }
}

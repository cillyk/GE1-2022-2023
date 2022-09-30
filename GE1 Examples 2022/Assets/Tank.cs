using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxis("Vertical");
        Debug.Log("vertical: " + v);
        transform.Translate(0, 0, v * speed * Time.deltaTime);
        float h = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * h *  speed * Time.deltaTime * 10);
        Debug.Log("horizontal: " + h);

    }
}

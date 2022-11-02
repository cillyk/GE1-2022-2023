using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour
{
<<<<<<< Updated upstream
    private TankControls tc;

    void Awake()
    {
        tc = new TankControls();
    }

    void OnEnable()
    {
        tc.Enable();
    }

    void OnDisable()
    {
        tc.Disable();
    }

    public float speed = 5;
    public float rotSpeed = 180;

    void Update()
    {
        float f = tc.Ground.Move.ReadValue<float>();

        Debug.Log("f: " + f);

        transform.Translate(0, 0, speed * f * Time.deltaTime);

        /*
        Vector3 p = transform.position;
        p += transform.forward * speed * Time.deltaTime;

        transform.position = p;
        */

        float r = tc.Ground.Rotate.ReadValue<float>();

        transform.Rotate(0, rotSpeed * r * Time.deltaTime, 0);


    }

    void Start()
    {
        Vector3 a = new Vector3(5,6, 0);
        Vector3 b = new Vector3(11, 8, 0);

        Vector3 c = b - a;

        Debug.Log(c);
        Debug.Log(c.magnitude);

        Debug.Log(Vector3.Normalize(c));

        float theta = 90 + Mathf.Atan(c.y / c.x) * Mathf.Rad2Deg;

        Debug.Log(theta);


    }


    public void Move(InputAction.CallbackContext context)
    {
        float f = context.ReadValue<float>();
        Debug.Log(f);
    }

    /*
    private TankControls tc;
=======
    public float speed = 5;
    public float rotSpeed = 100;
    
>>>>>>> Stashed changes
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float c = Input.GetAxis("Vertical");
        transform.Translate(0, 0, c * speed * Time.deltaTime);

        float r = Input.GetAxis("Horizontal");
        transform.Rotate(0, r * rotSpeed * Time.deltaTime, 0);
    }
}

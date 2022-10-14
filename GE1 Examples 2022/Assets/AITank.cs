using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AITank : MonoBehaviour {

    public float radius = 10;
    public int numWaypoints = 10;
    public int current = 0;
    List<Vector3> waypoints = new List<Vector3>();
    public float speed = 10;
    public Transform player;    
    public Text myText;
 
    int test = 0;

    public void OnDrawGizmos()
    {
        if (!Application.isPlaying)
        {
            // Create the ring of the waypoints
            float theta = (Mathf.PI * 2.0f) / numWaypoints;
            for(int i = 0 ; i < numWaypoints ; i ++)
            {
                float angle = theta * i;
                Vector3 pos = new Vector3(Mathf.Sin(angle) * radius, 0, Mathf.Cos(angle) * radius);
                pos = transform.TransformPoint(pos);
                Gizmos.color = Color.red;
                Gizmos.DrawWireSphere(pos, 1); 
            }
        }
    }

    // Use this for initialization
    void Awake () {
        //Create the list contianing the wayypoints
        float theta = (Mathf.PI * 2.0f) / numWaypoints;
        for(int i = 0 ; i < numWaypoints ; i ++)
        {
            float angle = theta * i;
            Vector3 pos = new Vector3(Mathf.Sin(angle) * radius, 0, Mathf.Cos(angle) * radius);
            pos = transform.TransformPoint(pos);
            waypoints.Add(pos); 
        }
    }

    // Update is called once per frame
    void Update () {
        Vector3 pos = transform.position;
        Vector3 toNext = waypoints[current] - pos;
        float dist = toNext.magnitude;
        if (dist < 1)
        {
            current = (current + 1) % waypoints.Count;
        }
        Vector3 direction = toNext / dist;
        transform.position = Vector3.Lerp(transform.position, waypoints[current], Time.deltaTime);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(toNext, Vector3.up), 180 * Time.deltaTime);


        Vector3 toPlayer = player.position - transform.position;
        float dot = Vector3.Dot(transform.forward, toPlayer.normalized);
        float angle = Mathf.Acos(dot) * Mathf.Rad2Deg;
        if (dot > 0)
        {
             myText.text = "Tank1 infront tank 2";    
        }
        if (angle < 45)
        {
             myText.text = "Tank1 inside fov of tank 2";
        }

        
        else
        {
            myText.text = "Tank1 behind tank 2";
        }

        float angle1 = Vector3.Angle(toPlayer, transform.forward);

    

     
    }
}
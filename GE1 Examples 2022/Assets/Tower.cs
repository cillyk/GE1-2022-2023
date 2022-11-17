using Newtonsoft.Json.Bson;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Tower : MonoBehaviour
{

    public Transform Player;
    public float fireRate = 5;
    public GameObject bulletPrefab;
    
    void Update()
    {
       Vector3 dir = Player.position - transform.position;
            Quaternion look = Quaternion.LookRotation(dir);
            look.x = 0; look.z = 0;
            transform.rotation = Quaternion.Slerp(transform.rotation, look, Mathf.Clamp01(3.0f * Time.maximumDeltaTime));
            GameObject bullet = GameObject.Instantiate<GameObject>(bulletPrefab);
            bullet.transform.rotation = transform.rotation;
            bullet.transform.forward = -bullet.transform.forward;
            bullet.transform.position = transform.position;
        
    }

   
    
}
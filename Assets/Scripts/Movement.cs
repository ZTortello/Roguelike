using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody Rigidbody;
    public float Speed;
    public GameObject bulletPrefab;
    public float bulletSpeed;
    public float lastFire;
    public float fireDelay;

    void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
    
    }

        void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        float shootHor = Input.GetAxis("ShootHorizontal");
        float shootVert = Input.GetAxis("ShootVertical");
        if((shootHor !=0 || shootVert !=0) && Time.time > lastFire + fireDelay) 
        {
            Shoot(shootHor, shootVert);
            lastFire = Time.time;
        }

        Vector3 movement = new Vector3(horizontal * Speed, Rigidbody.velocity.y, vertical * Speed);
        Rigidbody.AddForce(movement);
    }

    void Shoot(float x, float z) 
    {
        GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation) as GameObject;
        bullet.GetComponent<Rigidbody>().velocity = new Vector3((x < 0) ? Mathf.Floor(x) * bulletSpeed : Mathf.Ceil(x) * bulletSpeed, 0, (z < 0) ? Mathf.Floor(z) * bulletSpeed : Mathf.Ceil(z) * bulletSpeed);
    }

}

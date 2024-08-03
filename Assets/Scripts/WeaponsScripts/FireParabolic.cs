using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireParabolic : MonoBehaviour
{
    public GameObject bullet;
    public float bulletSpeed = 20;
    public Transform pof;

    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Fire();
        }
    }

    void Fire()
    {
        GameObject fireBullet = Instantiate(bullet, pof.position, Quaternion.identity);
        Rigidbody rb = fireBullet.AddComponent<Rigidbody>();
        rb.velocity = bulletSpeed * pof.forward;
    }
}

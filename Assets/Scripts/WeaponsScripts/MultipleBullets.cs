using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleBullets : MonoBehaviour
{
    public GameObject miniBullet; 
    public float lifeTime = 3f;
    public int bulletCuantity = 5;
    public float bulletForce = 5f;

    private float time = 0f;

    void Update()
    {
        time += Time.deltaTime;

        if (time >= lifeTime)
        {
            Explotar();
        }
    }

    void Explotar()
    {
        for (int i = 0; i < bulletCuantity; i++)
        {
            GameObject newBullets = Instantiate(miniBullet, transform.position, Quaternion.identity);
            newBullets.GetComponent<Rigidbody>().AddForce(Random.insideUnitSphere * bulletForce);
        }

        Destroy(gameObject);
    }
}

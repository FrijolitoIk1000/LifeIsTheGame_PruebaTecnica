using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Destroy : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground" || collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}

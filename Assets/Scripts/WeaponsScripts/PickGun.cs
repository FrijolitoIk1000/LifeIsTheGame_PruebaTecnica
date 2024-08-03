using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickGun : MonoBehaviour
{
    [SerializeField] private Transform cameraPosition;
    [SerializeField] private GameObject gun;
    GameObject myGun;
    private bool istriggered = false;
    [SerializeField] private GameObject pickGun;
    Vector3 spinDirection = Vector3.up;

    private void Update()
    {

        pickGun.transform.Rotate(spinDirection);
    }


    void OnTriggerEnter(Collider coll)
    {
        myGun = GameObject.FindGameObjectWithTag("Gun");
        if (coll.CompareTag("Player"))
        {
            if (istriggered == false)
            {
                if (myGun != null)
                {
                    Destroy(myGun);
                }
                
                myGun = Instantiate(gun);

                //Movimineto del modelo en el objeto
                myGun.transform.position = cameraPosition.transform.position;
                myGun.transform.rotation = cameraPosition.transform.rotation;
                myGun.transform.SetParent(cameraPosition);
            }

            istriggered = true;
        }
        
    }

    void OnTriggerExit(Collider coll)
    {
        istriggered = false;
    }
}

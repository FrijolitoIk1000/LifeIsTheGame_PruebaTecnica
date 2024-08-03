using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectilAtraction : MonoBehaviour
{
    public float atractionForce = 10f;
    public float angularVelocity = 2f;
    public float atractionRange = 15f;
    private SphereCollider colliderAtraccion;

    void Start()
    {
        colliderAtraccion = gameObject.AddComponent<SphereCollider>();
        colliderAtraccion.isTrigger = true; 
        colliderAtraccion.radius = atractionRange; 
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Rigidbody rb = other.GetComponent<Rigidbody>();
            if (rb != null)
            {
                // Calcular la direccion hacia la bala
                Vector3 direccion = transform.position - other.transform.position;

                // Aplicar la fuerza de atraccion
                rb.AddForce(direccion.normalized * atractionForce);

                // Agregar una fuerza tangencial para crear el movimiento orbital
                Vector3 direccionTangencial = Vector3.Cross(direccion, transform.up).normalized;
                rb.AddForce(direccionTangencial * angularVelocity * rb.mass);
            }
        }
    }
}

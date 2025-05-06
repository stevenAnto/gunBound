using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrikeProyectil : MonoBehaviour
{
    public float speed = 40.00f;
    public float impactForce = 5.0f;
     public GameObject explosionEffect;  // Efecto de la explosió
    // Start is called before the first frame update
    public controlTexto texto;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward*Time.deltaTime*speed);
        
    }
    /*void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Bala colisionó con: " + collision.gameObject.name);

        // Aplica fuerza si el objeto tiene Rigidbody
        if (collision.rigidbody != null)
        {
            Vector3 forceDirection = collision.transform.position - transform.position;
            collision.rigidbody.AddForce(forceDirection.normalized * impactForce, ForceMode.Impulse);
        }

        // Si colisiona con un objeto con tag "target1"
        if (collision.gameObject.CompareTag("target1"))
        {
            Debug.Log("¡Colisión con objetivo detectada 1 !");
            // También puedes destruir el objetivo si lo deseas
        }
        if (collision.gameObject.CompareTag("target2"))
        {
            Debug.Log("¡Colisión con objetivo detectada 2 !");
            // También puedes destruir el objetivo si lo deseas
        }
        if (collision.gameObject.CompareTag("target3"))
        {
            Debug.Log("¡Colisión con objetivo detectada 3!");
            // También puedes destruir el objetivo si lo deseas
        }

        // Crear efecto de explosión

        // Destruir el proyectil
        Destroy(gameObject);
    }*/
}

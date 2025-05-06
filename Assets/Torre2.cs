using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torre2 : MonoBehaviour
{
    public VariablesGlobales variablesGlobales;
    private bool yaColisiono = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Colisión detectada con: " + collision.gameObject.name);
        if (!yaColisiono && collision.gameObject.CompareTag("bomb"))
        {
             Debug.Log("Colisión t2 válida con Bomb. Contador incrementado.");
            variablesGlobales.targetsEliminados++;
            yaColisiono = true;

            // Desactivamos solo su funcionalidad (como scripts, movimiento, disparos, etc.)
            // Pero NO la destruimos ni la ocultamos
            this.enabled = false; // Inactiva este script

            // También puedes hacer otras cosas como:
            // gameObject.GetComponent<Renderer>().material.color = Color.gray;
            // o desactivar otros componentes si quieres simular "torre destruida"
        }
    }
}

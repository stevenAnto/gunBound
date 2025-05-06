using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targetObjects;  // Lista de los 3 objetos a destruir
    public float timer = 30.0f;  // Tiempo límite
    public GameObject explosionObjectPrefab;  // Prefab de Empty Object para simular la explosión

    private int destroyedTargets = 0;  // Contador de objetos destruidos

    // Start is called before the first frame update
    void Start()
    {
        targetObjects.Clear();  // Asegúrate de limpiar la lista antes de llenarla
        GameObject[] targets = GameObject.FindGameObjectsWithTag("Target");

        // Agrega los 3 primeros objetos con el tag "Target"
        foreach (GameObject target in targets)
        {
            if (targetObjects.Count < 3)
            {
                targetObjects.Add(target);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        // Resta tiempo del temporizador
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            // Si el tiempo se agotó, explota la bomba
            TriggerExplosion();
        }

        // Verifica si todos los objetos han sido destruidos
        if (destroyedTargets >= targetObjects.Count)
        {
            Debug.Log("¡Has ganado!");
            // Aquí puedes poner cualquier lógica para terminar el juego, como cargar una nueva escena o mostrar un mensaje.
        }

    }
    // Método para detectar cuando un objeto ha sido destruido por la bala
    public void DestroyTarget(GameObject target)
    {
        // Asegúrate de que el objeto no se cuente varias veces
        if (!targetObjects.Contains(target))
        {
            targetObjects.Add(target);
        }

        // Incrementa el contador de objetivos destruidos
        destroyedTargets++;
        Debug.Log("Objetos destruidos: " + destroyedTargets);
    }
    void TriggerExplosion()
    {
        Debug.Log("¡Explosión!");

    }
}

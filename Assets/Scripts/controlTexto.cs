using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class controlTexto : MonoBehaviour
{
    public GameObject player;
    public TMP_Text textoTimer;
    public VariablesGlobales variablesGlobables;
    public BombaAcabo bombaAcabo;
    public float tiempoRestante ; // Tiempo inicial (en segundos)
    
    private Vector3 offset = new Vector3(0.0f, 5.0f, -10.23f);

    // Referencias a los targets
    public GameObject target1;
    public GameObject target2;
    public GameObject target3;

    // Contador de objetivos eliminados
    private int targetsEliminados ;
    private bool juegoTerminado ;

    void Start()
    {
        if (textoTimer == null)
        {
            Debug.LogError("Falta asignar el textoTimer en el Inspector.");
        }
        tiempoRestante = variablesGlobables.tiempoRestante;
        targetsEliminados =variablesGlobables.targetsEliminados;
        juegoTerminado = variablesGlobables.juegoTerminado;
    }

    void Update()
    {
        targetsEliminados =variablesGlobables.targetsEliminados;
        // Mover el texto con el jugador
        if (player != null)
        {
            transform.position = player.transform.position + offset;
        }

        if (juegoTerminado) return;

        // Revisar si los targets han sido eliminados

        if (tiempoRestante > 0)
        {
            tiempoRestante -= Time.deltaTime;

            // Mostrar tiempo con 2 decimales (segundos.milisegundos)
            textoTimer.text = "Tiempo: " + tiempoRestante.ToString("F2") + "s" + 
                              "\nObjetivos eliminados: " + targetsEliminados + " / 3";
        }
        else
        {
            textoTimer.text = "¡Tiempo agotado ---> Perdiste!";
            bombaAcabo.gameObject.SetActive(true);
            juegoTerminado = true;
        }

        // Verificar si se han eliminado todos los objetivos
        if (targetsEliminados >= 3)
        {
            textoTimer.text = "¡Ganaste!\nObjetivos eliminados: " + targetsEliminados + " / 3";
            juegoTerminado = true;
        }
    }

}



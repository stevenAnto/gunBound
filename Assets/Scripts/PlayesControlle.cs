using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayesControlle : MonoBehaviour
{
    public float controlFrame = 5.0f;
    public float turnSpeed = 5.0f;
    public float rotateSpeen = 100.0f;
    public float horizontaInput;
    public float forwardInput;
    public GameObject basicProjectil;
    public Transform bullet;
    public VariablesGlobales variablesGlobables;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.forward*Time.deltaTime*controlFrame);
        horizontaInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right*Time.deltaTime * turnSpeed*horizontaInput);
        transform.Translate(Vector3.forward*Time.deltaTime*controlFrame*forwardInput);

        if(Input.GetKeyDown(KeyCode.Space)){
            Debug.Log("bomba");
            Instantiate(basicProjectil, bullet.position, transform.rotation);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.up * -rotateSpeen * Time.deltaTime); // Rota a la izquierda
        }

        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.up * rotateSpeen * Time.deltaTime); // Rota a la derecha
        }


    }
}

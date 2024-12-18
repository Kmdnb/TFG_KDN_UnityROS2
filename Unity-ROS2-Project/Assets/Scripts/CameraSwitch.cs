using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public GameObject Camera1; //Para asignar la cámara princial (global)
    public GameObject Camera2; //Para asignar la cámara frontal del argo j8
    public GameObject Camera3; //Para asignar la cámara trasera del argo j8

    private int count = 0; //Para contar cuantas veces se presiona la tecla c. 
    void Start()
    {
        Camera1.SetActive(true);
        Camera2.SetActive(false);
        Camera3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //Detecta cuando se presiona la letra C.
        if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("C key was pressed.");
            count++;
            switch (count)
            {
                case 1:
                    Camera1.SetActive(false);
                    Camera2.SetActive(true);
                    Camera3.SetActive(false);
                    break;

                case 2:
                    Camera1.SetActive(false);
                    Camera2.SetActive(false);
                    Camera3.SetActive(true);
                    break;


                case 3:
                    count = 0;
                    Camera1.SetActive(true);
                    Camera2.SetActive(false);
                    Camera3.SetActive(false);
                    break;

            }
            Debug.Log("Count = " + count);
        }
    }
}

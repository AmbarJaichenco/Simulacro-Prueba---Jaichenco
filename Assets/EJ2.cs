using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ2 : MonoBehaviour
{
    // Crear las variables necesarias para ingresar por Inspector el precio de 3 productos y un monto de dinero disponible. 
    //Comunicar si la suma de los mismos supera o no el monto de dinero disponible. Luego indicar cuánto dinero sobra o falta.

    public float pr1;
    public float pr2;
    public float pr3;
    public float dindisp;

    // Start is called before the first frame update
    void Start()
    {
        float sumapr = pr1 + pr2 + pr3;
        if (sumapr > dindisp)
        {
            Debug.Log("No hay suficiente dinero disponible");
            Debug.Log("--------------------");
            float falta = sumapr - dindisp;
            Debug.Log("Faltan $" + falta);
        }
        else
        {
            Debug.Log("Hay suficiente dinero disponible");
            Debug.Log("--------------------");
            float sobra = dindisp - sumapr;
            Debug.Log("Sobran $" + sobra);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

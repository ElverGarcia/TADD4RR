using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Services.Analytics;

public class AnalyticsSelecPersonaje : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public void Seleccionar(string nombre)
    {
        string protagonista=nombre;
        CustomEvent seleccion = new CustomEvent("SeleccionarPersonaje")
        {
            {
                "Personaje", protagonista
            },
        }; print(protagonista);
        AnalyticsService.Instance.RecordEvent(seleccion);
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}

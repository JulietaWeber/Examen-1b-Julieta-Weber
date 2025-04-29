using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehiculos : MonoBehaviour
{
    public string patente;
    public int modelo;
    public float kilomtrosRecorridos;
    public int vencimientoVTVActual;
    public float HCppm;

    int añoActual = 2025;
  
    // Start is called before the first frame update
    void Start()
    {
        if (patente == "")
        {
            Debug.Log("Este campo no puede estar vacío");
            Debug.Log("VTV no aprobada");
            return;
        }
        else if (modelo < 1900 || modelo > 2025)
        {
            Debug.Log("El año de fabricación no puede ser menor a 1900 ni mayor al año actual");
            Debug.Log("VTV no aprobada");
            return;
        }
        else if (kilomtrosRecorridos < 0)
        {
            Debug.Log("Los kilómetros recorridos no pueden ser negativos");
            return;
        }
        else if (vencimientoVTVActual > 2025 || vencimientoVTVActual < modelo)
        {
            Debug.Log("El año de vencimiento de la VTV debe menor que año actual y mayor que el año de fabricación");
            Debug.Log("VTV no aprobada");
            return;
        }
        else if (HCppm < 5)
        {
            Debug.Log("El HC ppm no puede ser menor a 5");
            Debug.Log("VTV no aprobada");
            return;
        }
        else if (HCppm > 100)
        {
            Debug.Log("VTV no aprobada, el HC ppm no puede ser mayor a 100");
            return;
        }
        
        else if (kilomtrosRecorridos / (añoActual - modelo) < 1000){
            Debug.Log("VTV otorgada por 2 años");
        }
        else if (kilomtrosRecorridos / (añoActual - modelo) > 1000)
        {
            Debug.Log("VTV otorgada por 1 año");
        }


 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

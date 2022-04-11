using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tema1 : MonoBehaviour
{
    /*Estas son las cotizaciones que investigué:
    Dólar (D): $112 pesos argentinos.
    Real (R): $24 pesos argentinos.
    Euro (E): $122 pesos argentinos. */

    public string monedaExtranjera;
    public double montoParaConvertir;

    // Start is called before the first frame update
    void Start()
    {
        double operacionConvertToDollar = montoParaConvertir / 112;
        double operacionConvertToReal = montoParaConvertir / 24;
        double operacionConvertToEuro = montoParaConvertir / 122;

        if (monedaExtranjera != "D" && monedaExtranjera != "R" && monedaExtranjera != "E")
        {
            Debug.Log("Opción de moneda extranjera no válida.");
        }

        else if (montoParaConvertir < 1000)
        {
            Debug.Log("El monto mínimo es de $1000.");
        }

        else if (monedaExtranjera == "D" || monedaExtranjera == "R" || monedaExtranjera == "E")
        {
            if (monedaExtranjera == "D")
            {
                Debug.Log($"${montoParaConvertir} pesos argentinos equivalen a {operacionConvertToDollar} dólares.");
            }

            else if (monedaExtranjera == "R")
            {
                Debug.Log($"${montoParaConvertir} pesos argentinos equivalen a {operacionConvertToReal} reales.");
            }

            else 
            {
                Debug.Log($"${montoParaConvertir} pesos argentinos equivalen a {operacionConvertToEuro} euros.");
            }
        }

        else
        {
            Debug.Log("Ha ocurrido un error inesperado.");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayProductos : MonoBehaviour
{
    private void Start()
    {
        Tienda producto1 = new() { t_nombre = "Espada de hierro", t_precio = 1.5f };
        Tienda producto2 = new() { t_nombre = "Escudo de madera", t_precio = 0.5f };
        Tienda producto3 = new() { t_nombre = "Pistola:Pew-Pew", t_precio = 9999f };

        Debug.Log($"{producto1.t_nombre}: {producto1.t_precio:C2}");
        Debug.Log($"{producto2.t_nombre}: {producto2.t_precio:C2}");
        Debug.Log($"{producto3.t_nombre}: {producto3.t_precio:C2}");
    }
}

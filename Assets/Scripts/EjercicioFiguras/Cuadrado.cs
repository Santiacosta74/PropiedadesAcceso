using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cuadrado : MonoBehaviour
{
    public float velocidad;
    private string nombre = "Cuadradito";

    public string _nombre
    {
        get => nombre;

        set
        {
            if (value != null)
                nombre = value;
            else
                Debug.Log("Nombre ingresado no válido.");
        }
    }

    private void FixedUpdate()
    {
        Movimiento();
    }

    private void Movimiento()
    {
        float velocidad_x = Input.GetAxisRaw("Horizontal");

        Vector2 direccionMovimiento = new Vector2(velocidad_x, 0f);

        transform.Translate(direccionMovimiento * velocidad * Time.deltaTime);
    }
}

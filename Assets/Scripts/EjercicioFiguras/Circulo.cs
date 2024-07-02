using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Circulo : MonoBehaviour
{
    public CanvasManager canvasManager;
    [SerializeField] private TextMeshProUGUI saludo;
    private Animator anim;
    private const string POP_UP = "Pop_up";
    private const string POP_OUT = "Pop_out";

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.gameObject.TryGetComponent(out Cuadrado cuadrado)) return;

        if (cuadrado._nombre == "Cuadradito")
        {
            cuadrado._nombre = "Circulo";
            saludo.text = $"No me gusta tu nombre, asi que voy a decirte {cuadrado._nombre}";
        }
        else
        {
            saludo.text = "Ahora si me gusta tu nombre";
        }

        canvasManager.AnimacionMensaje(POP_UP);
        anim.SetTrigger("Saludo");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("Cuadrado")) return;

        canvasManager.AnimacionMensaje(POP_OUT);
        anim.SetTrigger("Stop");
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Rectangulo : MonoBehaviour
{
    public CanvasManager canvasManager;
    private Animator anim;

    [SerializeField] private TextMeshProUGUI saludo;
    private const string POP_UP = "Pop_up";
    private const string POP_OUT = "Pop_out";

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Cuadrado cuadrado))
        {
            saludo.text = $"Hola {cuadrado._nombre}!";
            anim.SetTrigger("Saludo");
            canvasManager.AnimacionMensaje(POP_UP);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("Cuadrado")) return;

        canvasManager.AnimacionMensaje(POP_OUT);
        anim.SetTrigger("Stop");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    [SerializeField] private Animator anim;

    public void AnimacionMensaje(string trigger) => anim.SetTrigger(trigger);
}

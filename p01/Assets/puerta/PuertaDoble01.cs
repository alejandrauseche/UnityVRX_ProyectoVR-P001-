using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaDoble01 : MonoBehaviour
{

    //Llamar animator de la puerta
    public Animator PuertaAnimator;

    // abrir puerta
    [ContextMenu("<< Abrir puerta >>")]

    public void AbrirPuerta () {
        print("puerta abierta");
        PuertaAnimator.SetBool("Abierta", true);
    }

    // cerarr puerta
    [ContextMenu("<< Cerrar puerta >>")]

    public void CerrarPuerta () {
        print("puerta cerrada");
        PuertaAnimator.SetBool("Abierta", false);
    }

    // puerta bloqueada
    [ContextMenu("<< Puerta bloqueada >>")]

    public void PuertaBloqueada() {
        print("puerta bloqueada");
        PuertaAnimator.SetTrigger ("Bloqueada");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidosControl_Controlador : MonoBehaviour
{
    public AudioSource Sonido1; //s1
    public AudioSource Sonido2; //s2
    public AudioSource Sonido3; //s3

    private void Awake()
    {
        ReproducirSonido("s2");
    }

    public void ReproducirSonido(string que_sonido)
    {
        if (que_sonido == "s1")
        {
            Sonido1.Play();
        }else if (que_sonido == "s2")
        {
            Sonido2.Play();
        }else if (que_sonido == "s3")
        {
            Sonido3.Play();
        }
            
    }

    private void OnEnable()
    {
        SujetoObservable_Controlador.ReproducirSonido_Accion += ReproducirSonido;    
    }

    private void OnDisable()
    {
        SujetoObservable_Controlador.ReproducirSonido_Accion -= ReproducirSonido;
    }
}

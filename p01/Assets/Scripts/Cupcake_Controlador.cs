using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Cupcake_Controlador : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Jugador"))
        {
            SujetoObservable_Controlador.IncrementarContadorRecolectable?.Invoke();
            Destroy(gameObject);
        }
    }

 
}

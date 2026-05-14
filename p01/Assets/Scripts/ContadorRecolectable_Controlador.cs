using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ContadorRecolectable_Controlador : MonoBehaviour
{
    public TextMeshProUGUI TextoContadorRecolectable;
    public int TotalCupcake = 0;

    [ContextMenu("Aumentar Contador")]

    public void AumentarContador()
    {
        TotalCupcake++;
        TextoContadorRecolectable.text = TotalCupcake.ToString();
        SujetoObservable_Controlador.ReproducirSonido_Accion?.Invoke("s1");
    }

    private void OnEnable()
    {
        SujetoObservable_Controlador.IncrementarContadorRecolectable += AumentarContador;
    }

    private void OnDisable()
    {
        SujetoObservable_Controlador.IncrementarContadorRecolectable -= AumentarContador;
    }
}

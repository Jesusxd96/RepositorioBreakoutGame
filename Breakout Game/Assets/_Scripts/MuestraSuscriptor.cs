using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuestraSuscriptor : MonoBehaviour
{
    MuestraEventos suscriptor;
    // Start is called before the first frame update
    void Start()
    {
        suscriptor = GetComponent<MuestraEventos>();
        suscriptor.OnSpacePressed += MensajeEscuchadoPorElSuscriptor;//La otra clase tambien esta escuchando a este evento
    }

    // Update is called once per frame
    private void MensajeEscuchadoPorElSuscriptor(object sender, EventArgs e)
    {
        Debug.Log("El evento ha sido escuchado desde otra clase.");
        suscriptor.OnSpacePressed -= MensajeEscuchadoPorElSuscriptor;//Aqui se desuscribe
    }
}

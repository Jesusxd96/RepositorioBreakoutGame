using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MuestraEventos : MonoBehaviour
{
    // Start is called before the first frame update
    public UnityEvent MiEventoUnity;//Sale en el inspector
    public event EventHandler OnSpacePressed;
    void Start()
    {
        OnSpacePressed += EventListened;//Suscripcion
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnSpacePressed?.Invoke(this, EventArgs.Empty);
            MiEventoUnity.Invoke();//Asi de sencillo se invoca
        }
    }

    public void EventListened(object sender, EventArgs e)
    {
        Debug.Log("El evento se escucho correctamente");
    }

    public void EventoUnityDisparado()
    {
        Debug.Log("El evento Unity se disparo correctamente");
    }
}

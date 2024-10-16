using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuPrincipal : MonoBehaviour
{
    public GameObject menuOpciones;
    public GameObject menuInicial;

    public void IniciarJuego()
    {
        SceneManager.LoadScene(1);
    }
    public void FinalizarJuego() 
    {
        Application.Quit();
    }
    public void MostrarOpciones()
    {
        menuInicial.SetActive(false);
        menuOpciones.SetActive(true);
    }
    public void MostrarMenuInicial()
    {
        menuOpciones.SetActive(false);
        menuInicial.SetActive(true);
    }
}

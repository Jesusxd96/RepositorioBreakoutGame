using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public Transform highScore_Transform;
    public Transform score_Transform;
    public TMP_Text highScore_Text;
    public TMP_Text score_Text;
    public PuntajeAlto puntajeAltoSO;

    // Start is called before the first frame update
    void Start()
    {
        score_Transform = GameObject.Find("Score").transform;
        highScore_Transform = GameObject.Find("HighScore").transform;
        score_Text = score_Transform.GetComponent<TMP_Text>();
        highScore_Text = highScore_Transform.GetComponent<TMP_Text>();
        //if (PlayerPrefs.HasKey("highScore"))
        //{
        //highScore = PlayerPrefs.GetInt("highScore");
        puntajeAltoSO.Cargar();
        highScore_Text.text = $"Record: {puntajeAltoSO.puntajeAlto}";//Aqui se muestra el record apenas empezando la partida
        puntajeAltoSO.puntaje = 0;
        //}
    }

    private void FixedUpdate()
    {
        puntajeAltoSO.puntaje += 50;
    }

    // Update is called once per frame
    void Update()
    {
        score_Text.text = $"PuntajeActual: {puntajeAltoSO.puntaje}";//Aqui se modificara el puntaje actual
        if (puntajeAltoSO.puntaje > puntajeAltoSO.puntajeAlto)
        {
            puntajeAltoSO.puntajeAlto = puntajeAltoSO.puntaje;
            highScore_Text.text = $"Record: {puntajeAltoSO.puntajeAlto}";
            puntajeAltoSO.Guardar();
            //PlayerPrefs.SetInt("highScore", score);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    [SerializeField] private int limiteX = 23;
    [SerializeField] private float VelocidadPaddle = 15f;
    Vector3 mousePos2D;
    Vector3 mousePos3D;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PaddleMoving();
    }

    void PaddleMoving()
    {
        /*
        mousePos2D = Input.mousePosition;
        mousePos2D.z = -Camera.main.transform.position.z;
        mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);
        */
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.down * VelocidadPaddle * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.up * VelocidadPaddle * Time.deltaTime);
        }

        Vector3 pos = transform.position;
        //pos.x = mousePos3D.x;
        if(pos.x < -limiteX)
        {
            pos.x = -limiteX;
        }else if(pos.x > limiteX)
        {
            pos.x = limiteX;
        }
        transform.position = pos;
    }
}

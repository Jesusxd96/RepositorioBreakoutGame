using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    [SerializeField] private int limiteX = 23;
    [SerializeField] private float paddleSpeed = 15f;

    Transform transform;
    Vector3 mousePos2D;
    Vector3 mousePos3D;
    // Start is called before the first frame update
    void Start()
    {
        transform = this.gameObject.transform;
    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Ball")
        {
            Vector3 direccion = col.contacts[0].point - transform.position;
            direccion = direccion.normalized;
            col.rigidbody.velocity = col.gameObject.GetComponent<Bola>().ballSpeed * direccion;
        }
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
        /*
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.down * paddleSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.up * paddleSpeed * Time.deltaTime);
        }*/

        transform.Translate(Input.GetAxis("Horizontal") * Vector3.down * paddleSpeed * Time.deltaTime);

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

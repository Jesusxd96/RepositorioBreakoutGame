using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Bloque : MonoBehaviour
{
    public int resistencia = 1;
    public UnityEvent AumentarPuntaje;

    public Opciones opciones;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            RebotarBola(collision);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        //opciones = FindObjectOfType<Opciones>();
        NuevaResistencia((int)opciones.nivelDificultad);//Se toma el numero de la dificultad y se manda
    }

    // Update is called once per frame
    void Update()
    {
        if (resistencia == 0)
        {
            AumentarPuntaje.Invoke();
            Destroy(this.gameObject);
        }
    }
    /*Polimorfismo incoming*/
    public virtual void RebotarBola(Collision col)
    {
        Vector3 direccion = col.contacts[0].point - transform.position;
        direccion = direccion.normalized;
        col.rigidbody.velocity = col.gameObject.GetComponent<Bola>().ballSpeed * direccion;
        resistencia--;
    }
    //La palabra Virtual nos ayuda para hacer la sobrecarga de metodos
    public virtual void RebotarBola()
    {

    }
    public void NuevaResistencia(int i)//Se mandara de inicio la posicion del enum
    {
        switch (i){
            case 1:resistencia += 1;//Normal, solo se le agrega 1 resistencia a los bloques
                break;
            case 2: resistencia *= 2;//Se duplica el valor, es dificil
                break;
            default: resistencia *= 1;//Default es 0, osea facil deberia ser, no cambian
                break;
        }
    }
}

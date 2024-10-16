using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Bloque : MonoBehaviour
{
    public int resistencia = 1;
    public UnityEvent AumentarPuntaje;

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
    
}

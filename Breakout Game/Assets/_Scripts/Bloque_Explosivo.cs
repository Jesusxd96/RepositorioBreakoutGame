using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque_Explosivo : Bloque
{
    public float explotionRadius;//Que tantos bloques afectaria la explosion.
    // Start is called before the first frame update
    void Start()
    {
        resistencia = 2;//Se le debera de pegar 2 veces para que explote.
    }
    public override void RebotarBola()
    {
        //Luego de la bola rebotar este bloque explotara sin dañar la bola
        base.RebotarBola();
    }

}

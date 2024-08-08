using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque_Acero : Bloque
{
    // Start is called before the first frame update
    void Start()
    {
        resistencia = 8;
    }
    public override void RebotarBola()
    {
        //Al ser un bloque de acero, el angulo de rebote podria cambiar?
        base.RebotarBola();
    }
}

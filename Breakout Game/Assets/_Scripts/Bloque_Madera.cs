using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque_Madera : Bloque
{
    //Al estar heredando de la clase bloque, solito se desvivira
    // Start is called before the first frame update
    void Start()
    {
        resistencia = 3;
    }
    public override void RebotarBola(Collision col)
    {
        base.RebotarBola(col);
    }
}

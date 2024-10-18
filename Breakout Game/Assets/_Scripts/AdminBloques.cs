using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdminBloques : MonoBehaviour
{
    public GameObject menuFinDeNivel;

    // Update is called once per frame
    void Update()
    {
        if (transform.childCount == 0)
        {
            menuFinDeNivel.SetActive(true);
        }
    }
}

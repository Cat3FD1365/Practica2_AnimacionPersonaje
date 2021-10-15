using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransicionAnimacion : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            anim.SetBool("SeMueve", true);
        }
        if (!Input.GetKey("w"))
        {
            anim.SetBool("SeMueve", false);
        }
        if (Input.GetKey("d"))
        {
            anim.SetBool("Baila", true);
        }
        if (!Input.GetKey("d"))
        {
            anim.SetBool("Baila", false);
        }
        if (Input.GetKey("space"))
        {
            anim.SetBool("Corre", true);
        }
        if (!Input.GetKey("space"))
        {
            anim.SetBool("Corre", false);
        }
    }
}

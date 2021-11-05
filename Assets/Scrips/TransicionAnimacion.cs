using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransicionAnimacion : MonoBehaviour
{
    public float velocidad = 0.0f;
    public float aceleracion = 0.1f;
    public float desaceleracion = 0.01f;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool moverseoprimido = Input.GetKey("p");
        bool danceoprimido = Input.GetKey("space");

        if (moverseoprimido && velocidad < 1.0f)
        {
            velocidad += Time.deltaTime * aceleracion;
        }
        if (!moverseoprimido && velocidad >0.0f)
        {
            velocidad -= Time.deltaTime * desaceleracion;
        }
        if (!moverseoprimido && velocidad < 0.0f)
        {
            velocidad = 0.0f;
        }
        if (danceoprimido)
        {
            anim.SetBool("Baila", true);
        }
        if (!danceoprimido)
        {
            anim.SetBool("Baila", false);
        }

        anim.SetFloat("Velocidad", velocidad);
    }
}

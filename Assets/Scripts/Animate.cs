using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animate: MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.D))
            anim.Play("Size");
        if (Input.GetKeyDown(KeyCode.S))
            anim.Play("Spin");
        if (Input.GetKeyDown(KeyCode.W))
            anim.Play("Hover");
        if (Input.GetKeyDown(KeyCode.A))
            anim.Play("ChangeColor");


    }
}

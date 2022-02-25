using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jplayer : MonoBehaviour
{

    private Animator animator;

    
    // Start is called before the first frame update
    void Start()
    
       {
            animator = GetComponent<Animator>();
        }

    // Update is called once per frame
    void Update()
    { 
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        if (horizontal != 0 || vertical != 0)
        {
            animator.SetFloat("horizontal", horizontal);
            animator.SetFloat("vertical", vertical);

            animator.SetFloat("movimiento", 1);
        }else
        {
            animator.SetFloat("movimiento", 0);

        }
        }
    }





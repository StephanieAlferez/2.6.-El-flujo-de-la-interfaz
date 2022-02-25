using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlador : MonoBehaviour
{
    new Rigidbody2D rigidbody;
    Animator animator;

    public float speed = 64;

    // Start is called before the first frame update
    void Start()

    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float hor = Input.GetAxisRaw("Horizontal");
        float ver = Input.GetAxisRaw("Vertical");

        if (hor != 0 || ver != 0)
        {
            Vector2 velocity = new Vector2(hor, ver).normalized * speed;

            rigidbody.velocity = velocity;

            animator.SetFloat("horizontal", hor);
            animator.SetFloat("vertical", ver);

        }
        else {
            rigidbody.velocity = Vector2.zero;
        }
    }
}



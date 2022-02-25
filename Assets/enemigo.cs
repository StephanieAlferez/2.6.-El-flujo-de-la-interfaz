using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo : MonoBehaviour
{
private void OnTriggerEnter2D(Collider2D other)
    {
        print("Colision detectada");

        if(other.GetComponent<jplayer>() !=null)
        {
            Destroy(this.gameObject);
            
        }
    }
}

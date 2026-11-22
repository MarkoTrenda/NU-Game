using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)

    {
        if (other.gameObject.CompareTag("Player"))
        {

            Debug.Log("Give Player coins");
            Destroy(gameObject);

        }


    }



    }

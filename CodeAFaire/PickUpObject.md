using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PickUpObject : MonoBehaviour
{
    public Transform PickUpDest;
    public GameObject Obj;

    // Update is called once per frame
    void Update()
    {
        if (Obj != null)
        {
            Obj.transform.position = PickUpDest.position; // si vous avez un obj vous le déplacer dans votre main
        }
    }

    private void OnTriggerStay(Collider other) // cette fonction regarde a l'interieur de votre trigger si vous voyez un object et vous donne la posibilité d'interargir
    {
        if (other.CompareTag("Obj"))
        {
            Debug.Log("Appuyer sur E pour ramasser");
            if (Input.GetKey(KeyCode.E))
            {
                Obj = other.gameObject;
            }
        }
    }

    private void OnTriggerExit(Collider other) // permet la verification de que votre personnage ne voit plus l'object
    {
        if (other.CompareTag("Obj"))
        {
            Debug.LogWarning("Tes Sorti");
        }
    }
}

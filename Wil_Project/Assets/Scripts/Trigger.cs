using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Trigger : MonoBehaviour
{
    [Header("GameObject")]
    
    public GameObject textFloat;
    GameObject floatingText;

    private void OnTriggerEnter(Collider other)
    {
      
        
            floatingText = Instantiate(textFloat, transform.position, Quaternion.identity, transform);
            floatingText.GetComponent<TextMeshPro>().text = "Press Q \n to change views";
           
        

    }

    private void OnTriggerExit(Collider other)
    {
        Destroy(floatingText);
    }

}
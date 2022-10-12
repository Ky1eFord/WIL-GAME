using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FloatingText : MonoBehaviour
{
    [Header("Offset")]

    public Vector3 offSet = new Vector3(0,2,0);
    // Start is called before the first frame update
    void Start()
    {
        transform.localPosition += offSet;

       
    }

 
}

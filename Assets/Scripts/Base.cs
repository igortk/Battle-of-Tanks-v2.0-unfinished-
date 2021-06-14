using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour
{
    void Awake()
    {
        gameObject.GetComponentInChildren<SpriteRenderer>().sprite = 
                        Resources.Load<Sprite>("Sprites/Player Base");
    }

    void Update()
    {
        
    }
}

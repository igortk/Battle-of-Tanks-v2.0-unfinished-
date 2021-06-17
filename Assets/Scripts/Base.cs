using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour
{
    [SerializeField] private TankBase _tankBase;

    void Start()
    {
        if (_tankBase.GetIsEnemyBase())
        {
            gameObject.GetComponentInChildren<SpriteRenderer>().sprite =
                            Resources.Load<Sprite>("Sprites/Enemy Base");
        }
        else
        {
            gameObject.GetComponentInChildren<SpriteRenderer>().sprite =
                           Resources.Load<Sprite>("Sprites/Player Base");
        }
    }

    public void SetTankBase(TankBase tankBase)
    {
        _tankBase = tankBase;
    }

    private void GenerateTankOnMap()
    {

    }
}

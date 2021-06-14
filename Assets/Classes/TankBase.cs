using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankBase
{
    private bool _isEnemyBase;

    public bool GetIsEnemyBase()
    {
        return _isEnemyBase;
    }

    public TankBase(bool isEnemyBase)
    {
        _isEnemyBase = isEnemyBase;
    }
}

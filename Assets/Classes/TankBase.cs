using Assets.Classes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankBase
{
    private bool _isEnemyBase;

    private List<Tank> tanksNowOnMap;

    private int _tankInReserve;

    public bool GetIsEnemyBase()
    {
        return _isEnemyBase;
    }

    public TankBase(bool isEnemyBase, int countTankInReserve)
    {
        _isEnemyBase = isEnemyBase;
        tanksNowOnMap = new List<Tank>();
        _tankInReserve = countTankInReserve;
    }

}

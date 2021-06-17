using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class SpawnMap : MonoBehaviour
{
    [SerializeField] private Tile[] _tiles;
    [SerializeField] private Tilemap _tilemap;
    private int _weight = 40;
    private int _hight = 40;

    private void Awake()
    {
        GenerateMap();
        SpawnBase();
    }

    private void GenerateMap()
    {
        for (int x = 0; x < _weight; x++)
        {
            for (int y = 0; y < _hight; y++)
            {
                if (_tilemap.tag == "TileMapStone")
                {
                    if (y == 0 || y == _hight - 1)
                    {
                        _tilemap.SetTile(new Vector3Int(x, y, 0), _tiles[0]);
                        continue;
                    }
                    if (x == 0 || x == _weight - 1)
                    {
                        _tilemap.SetTile(new Vector3Int(x, y, 0), _tiles[1]);
                        continue;
                    }
                    continue;
                }
                _tilemap.SetTile(new Vector3Int(x,y,0), _tiles[0]);
            }
        }
    }

    private void SpawnBase()
    {
        if (_tilemap.tag == "TileMapStone")
        {
            //Enemy Base
            GameObject _base = (GameObject)Resources.Load("Prefabs/Base");
            Instantiate(_base, new Vector3Int(20, 38, 0), Quaternion.identity).
                GetComponent<Base>().SetTankBase(new TankBase(true,30));

            //Player Base
            _base = (GameObject)Resources.Load("Prefabs/Base");
            Instantiate(_base, new Vector3Int(20, 2, 0), Quaternion.identity).
                GetComponent<Base>().SetTankBase(new TankBase(false,30));
        }
    }
}

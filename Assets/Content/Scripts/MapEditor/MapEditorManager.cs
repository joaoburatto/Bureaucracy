using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

public class MapEditorManager : NetworkBehaviour
{ 
    [SyncVar] private GameObject[][][] tiles;
    
    
    public void AddTile()
    {
        
    }

    
    public GameObject GetTile(int x, int y = 0, int z = 0)
    {
        return tiles[x][y][z];
    }
}

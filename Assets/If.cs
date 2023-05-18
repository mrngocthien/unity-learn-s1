using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class If : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int playerLocation = 20;
        int spawnLocation = 20;

        if (playerLocation == spawnLocation) this.spawn();
        else this.notSpawn();
    }

    void spawn()
    {
        Debug.Log("spawn");
    }

    void notSpawn()
    {
        Debug.Log("not yet spawn");
    }
}

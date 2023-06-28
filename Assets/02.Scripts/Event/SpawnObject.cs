using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fusion;

public class SpawnObject : NetworkBehaviour
{
    public NetworkObject networkObject;
    public GameObject spawnObject;
    public Transform spawnPos;

    public override void Spawned()
    {
        if (networkObject.HasStateAuthority)
        {
            Runner.Spawn(spawnObject, spawnPos.position, Quaternion.identity);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (networkObject.HasStateAuthority && Input.GetKeyDown(KeyCode.Space))
        //{
        //    Runner.Spawn(spawnObject, spawnPos.position, Quaternion.identity);
        //}
    }
}

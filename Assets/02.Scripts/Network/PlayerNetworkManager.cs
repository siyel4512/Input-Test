using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fusion;

public class PlayerNetworkManager : NetworkBehaviour
{
    public static PlayerNetworkManager Local { get; set; }
    public PlayerInputManager playerInputManager;
    public CharacterController cc;
    //public Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void Spawned()
    {
        if (Object.HasInputAuthority)
        {
            Local = this;

            Debug.Log("Spawned local player");
        }
        else
        {
            Debug.Log("Spawned remote player");
        }
    }

    public override void FixedUpdateNetwork()
    {
        if (GetInput(out NetworkInputData data))
        {
            if (cc != null)
            {
                cc.Move(data.direction.normalized * Runner.DeltaTime * 2f);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fusion;

public class HandAnimatorHandler : NetworkBehaviour
{
    public NetworkObject networkObject;
    public HandAnimator_1 handAnimator;

    public override void Spawned()
    {
        base.Spawned();
    }

    public override void Render()
    {
        //base.Render();

        if (networkObject.HasInputAuthority)
        {
            //RPC_TEST();
        }
        //Debug.LogError($"{networkObject.Id} : {transform.name} 이런.....");
    }

    public override void FixedUpdateNetwork()
    {
        //base.FixedUpdateNetwork();
        //if (networkObject.HasInputAuthority)
        //{
        //    RPC_TEST();
        //}
    }

    private void Update()
    {
        if (networkObject.HasInputAuthority)
        {
            RPC_TEST();
        }
    }

    [Rpc(RpcSources.InputAuthority, RpcTargets.All)]
    public void RPC_TEST()
    {
        //if (networkObject.HasInputAuthority)
        {
            Debug.LogError($"{networkObject.Id} : {transform.name} 이런.....");

            handAnimator.Obj_Move();
        }
    }
}

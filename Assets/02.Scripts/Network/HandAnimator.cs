using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fusion;

public class HandAnimator : NetworkBehaviour
{
    public NetworkObject networkObject;

    // Start is called before the first frame update
    void Start()
    {
        RPC_test();
    }

    // Update is called once per frame
    void Update()
    {
        //RPC_test();
    }

    [Rpc(RpcSources.InputAuthority, RpcTargets.InputAuthority)]
    //[Rpc(RpcSources.All, RpcTargets.InputAuthority)]
    private void RPC_test()
    {
        //if (networkObject.HasInputAuthority)
        {
            Debug.LogError("RCP_test()");
        }
    }
}

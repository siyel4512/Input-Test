using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fusion;
using TMPro;

public class BrokenEvnet : NetworkBehaviour
{
    public NetworkObject networkObject;
    public float life = 10f;
    public float damage = 1f;
    public TMP_Text lifeText;

    public override void Spawned()
    {
        lifeText.text = life.ToString();
    }

    public override void FixedUpdateNetwork()
    {
        if (/*networkObject.HasStateAuthority && */Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.LogError("데미지 입음");
            RPC_SetLife(damage);
        }

        if (life <= 0)
        {
            lifeText.text = "Broken Object";
        }
    }

    [Rpc(RpcSources.All, RpcTargets.All)]
    public void RPC_SetLife(float _damage)
    {
        life -= _damage;
        lifeText.text = life.ToString();
    }
}

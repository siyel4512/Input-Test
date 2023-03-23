using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputManager : MonoBehaviour
{
    //public CharacterController cc;
    public PlayerNetworkManager playerNetworkManager;
    public Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        //cc = GetComponent<CharacterController>();
        PlayerNetworkManager.Local.playerInputManager = this;
    }

    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");

        //playerNetworkManager.direction = direction;
        //cc.Move(direction * Time.deltaTime);
    }
}

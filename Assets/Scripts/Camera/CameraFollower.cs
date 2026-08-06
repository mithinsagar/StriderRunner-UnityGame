// -----------------------------------------------------------------------------
// Strider Runner
// File   : CameraFollower.cs
// Module : Camera Follower
// Author : Mithin Sagar S
// GitHub : https://github.com/mithinsagar
// License: MIT (see LICENSE at project root)
// -----------------------------------------------------------------------------

using Cinemachine;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera vCam;
    [SerializeField] private Transform player;

    void Awake()
    {
        if (player == null)
            player = GetComponent<PlayerMovement>().transform;

        vCam.Follow = player;
    }
}

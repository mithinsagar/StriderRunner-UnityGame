// -----------------------------------------------------------------------------
// Strider Runner
// File   : CameraShaker.cs
// Module : Camera Shaker
// Author : Mithin Sagar S
// GitHub : https://github.com/mithinsagar
// License: MIT (see LICENSE at project root)
// -----------------------------------------------------------------------------

using Cinemachine;
using UnityEngine;

public class CameraShaker : MonoBehaviourSingleton<CameraShaker>
{
    [SerializeField] private CinemachineVirtualCamera vCam;
    private CinemachineBasicMultiChannelPerlin basicMultiChannelPerlin;
    private float shakeTime;
    
    protected override void Awake()
    {
        base.Awake();
            
        if (vCam == null)
            vCam = GetComponent<CinemachineVirtualCamera>();
        
        basicMultiChannelPerlin = vCam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
    }

    void Update()
    {
        if (shakeTime > 0)
        {
            shakeTime -= Time.deltaTime;

            if (shakeTime <= 0)
            {
                basicMultiChannelPerlin.m_AmplitudeGain = 0f;
            }
        }
    }

    public void ShakeCamera(float intensity, float time)
    {
        basicMultiChannelPerlin.m_AmplitudeGain = intensity;

        shakeTime = time;
    }
}

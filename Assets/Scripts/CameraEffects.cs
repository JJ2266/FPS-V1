using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;


public class CameraEffects : MonoBehaviour
{
    [SerializeField]CinemachineVirtualCamera vcam;
    [SerializeField]
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startShake()
    {
        vcam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = 1;
        StartCoroutine(Reset());
    }

    public void EndShake()
    {
        vcam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = 0;
       
    }
    IEnumerator Reset()
    {

        yield return new WaitForSeconds(0.3f);
        EndShake();
    }

}

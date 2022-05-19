using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TankAudio : MonoBehaviour
{
    public AudioSource m_ShootingAudio;
    public AudioClip m_ChargingClip;
    public AudioClip m_FireClip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayTankChargingAudio()
    {
        m_ShootingAudio.clip = m_ChargingClip;
        m_ShootingAudio.Play ();
    }

    public void PlayTankFiringAudio()
    {
        m_ShootingAudio.clip = m_FireClip;
        m_ShootingAudio.Play ();
    }
}

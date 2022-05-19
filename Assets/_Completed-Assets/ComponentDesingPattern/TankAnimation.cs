using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankAnimation : MonoBehaviour
{
    public GameObject m_ExplosionPrefab;

    private AudioSource m_ExplosionAudio;
    private ParticleSystem m_ExplosionParticles;

    // Start is called before the first frame update
    private void Awake()
    {
        m_ExplosionParticles = Instantiate (m_ExplosionPrefab).GetComponent<ParticleSystem> ();
        
        m_ExplosionAudio = m_ExplosionParticles.GetComponent<AudioSource> ();
        
        m_ExplosionParticles.gameObject.SetActive (false);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Explode()
    {
        m_ExplosionParticles.transform.position = transform.position;
        m_ExplosionParticles.gameObject.SetActive (true);
            
        m_ExplosionParticles.Play ();
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TankHealthUI : MonoBehaviour
{
    public float m_StartingHealth = 100f;
    public Slider m_Slider;
    public Image m_FillImage;
    
    private float m_CurrentHealth;
    
    public Color m_FullHealthColor = Color.green;
    public Color m_ZeroHealthColor = Color.red;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnEnable()
    {
        m_CurrentHealth = m_StartingHealth;
        
        SetHealthUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetHealth(float damage)
    {
        m_CurrentHealth -= damage;
        
        this.SetHealthUI();
    }
    
    private void SetHealthUI ()
    {
        m_Slider.value = m_CurrentHealth;

        m_FillImage.color = Color.Lerp (m_ZeroHealthColor, m_FullHealthColor, m_CurrentHealth / m_StartingHealth);
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PowerUp : MonoBehaviour
{
    private static PowerUp uniqueInstance;

    private PowerUp()
    {
    }

    public static PowerUp getInstance()
    {
        return uniqueInstance == null ? new PowerUp() : uniqueInstance;
    }

    public float multiplier = 1.4f;
    public float duration = 2f;

    private float m_RangeX;
    private float m_RangeZ;

    public GameObject pickUpEffect;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Untagged"))
        {
            StartCoroutine(PickUp(other));
        }
    }

    IEnumerator PickUp(Collider player)
    {
        Instantiate(pickUpEffect, transform.position, transform.rotation);

        player.transform.localScale /= multiplier;

        transform.position = new Vector3(-6.77f, -10f, 19f);

        yield return new WaitForSeconds(duration);

        player.transform.localScale *= multiplier;

        m_RangeX = Random.Range(-10f, 10f);
        m_RangeZ = Random.Range(-10f, 10f);

        transform.position = new Vector3(m_RangeX, 0.5f, m_RangeZ);
    }

    private void Update()
    {
        transform.Rotate(new Vector3(1f, 0f, 1f));
    }
}
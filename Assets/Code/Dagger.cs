using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dagger : MonoBehaviour
{

    Collider m_Collider;

    void Start()
    {
        m_Collider = GetComponent<Collider>();
    }

    void OnTriggerEnter(Collider collider)
    {
        GameObject[] Dagger;
        Dagger = GameObject.FindGameObjectsWithTag("Dagger");


        if (collider.gameObject.tag == "Enemy")
        {

        }

    }











}

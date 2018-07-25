using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Enemy : MonoBehaviour {
    [SerializeField]
    Slider HealthBar;
    [SerializeField]
    Text HealthText;


    float MaxHealth = 100;
    float curHealth;
    



	// Use this for initialization
	void Start ()
    {
        HealthBar.value = MaxHealth;
        curHealth = HealthBar.value;

    }

    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Dagger")
        {
            HealthBar.value -= 5f;
            curHealth = HealthBar.value;
        }

        if (curHealth == 0f)
        {
            Destroy(gameObject);
        }

    }

    void Update()
    {
        HealthText.text = curHealth.ToString() + " %";
    }
}

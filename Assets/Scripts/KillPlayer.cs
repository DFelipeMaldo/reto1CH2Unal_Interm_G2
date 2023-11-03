using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class KillPlayer : MonoBehaviour
{

    public ParticleSystem particleDeath;
    public GameObject  panelGameover;

    // Start is called before the first frame update
    void ActivatePanel()
    {
        panelGameover.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.SetActive(false);
            particleDeath.transform.position = other.gameObject.transform.position;
            particleDeath.Play();
            //gameoverText.text = "GameOver";
            Invoke("ActivatePanel", 2.0f);
        }
    }
    
        
    
}

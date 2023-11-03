using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    private int Puntaje = 0;
    public TMP_Text scoreT;
    public AudioSource audioDot;
    private int cherryPuntaje = 10;
    private int puntajeCherryMax = 10;

    public GameObject cherryObj;
    public Vector3[] puntosSpawncherry;
    private Vector3 cherryPos;

    public GameObject winBox;

    private void Update()
    {
        if(Puntaje >= puntajeCherryMax)
        {
            SpawnCherry();            
        }
        
        if (Puntaje >= 250)
        { 
            winBox.gameObject.SetActive(true);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Puntos"))
        {
            Destroy(other.gameObject);
            Puntaje++;
            scoreT.text = "Score: " + Puntaje;
            audioDot.Play();
        }
        else 
        {
            if (other.gameObject.CompareTag("Cherry"))
            { 
                Destroy (other.gameObject);
                Puntaje = Puntaje + cherryPuntaje;
                scoreT.text = "Score: " + Puntaje;
                audioDot.Play();
            }
        }
    }

    private void SpawnCherry()
    {
        cherryPos = puntosSpawncherry[Random.Range(0, puntosSpawncherry.Length)];
        Instantiate(cherryObj, cherryObj.transform.position = cherryPos, transform.rotation);
        puntajeCherryMax = puntajeCherryMax * 2 + Puntaje;
    }


}

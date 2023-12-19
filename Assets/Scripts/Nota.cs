using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nota : MonoBehaviour
{
    public GameObject notaInGame;
    private bool active;
    public GameObject panelE;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && active == true)
        {
            notaInGame.SetActive(true);
            panelE.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Escape) && active == true)
        {
            notaInGame.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            active = true;
            panelE.SetActive(true);
        }
        else
        {
            panelE.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            active = false;
            notaInGame.SetActive(false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public GameManager manager;

    [Header("Stats Player")]
    public int health = 100;


    [Header("Sliders")]
    public Slider sliderHealth;
    public GameObject loseUI;
    public GameObject winUI;


    void Start()
    {
        health = 100;
        loseUI.SetActive(false);
        winUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        sliderHealth.GetComponent<Slider>().value = health;
        
        Lose();
    }

    void Lose()
    {
        if (health <= 0)
        {
            loseUI.SetActive(true);
            Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.None;
        }

    }
    void Win()
    {
        winUI.SetActive(true);
        Time.timeScale = 0f;
    }
    public void MainMenu()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Win")
        {
            Win();
        }
    }
}

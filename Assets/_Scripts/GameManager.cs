using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{   
    [SerializeField] Slider slider;
    float timer;

    [SerializeField] GameObject loseScreen;
    [SerializeField] GameObject winScreen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        slider.value = timer;
        if(timer > 60) {
            gameWin();
        }
    }

    public void GameOver() {
        loseScreen.SetActive(true);
        Time.timeScale = 0; 
    }

    public void gameWin() {
        winScreen.SetActive(true);
        Time.timeScale = 0;
    }

    public void PlayGame() {
        SceneManager.LoadSceneAsync("MainMenu", LoadSceneMode.Single);
    }
}

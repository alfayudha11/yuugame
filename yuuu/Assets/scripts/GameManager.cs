using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject GOpanel;

    
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
       
    }

    // Update is called once per frame
   public void GameOver()
    {
        Time.timeScale = 0;
        GOpanel.SetActive(true);
    }
    public void Restart()
    {
        SceneManager.LoadScene("Game");
        
    }
    public void Menu()
    {
        SceneManager.LoadScene("menu");
    }
    
    
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class chara2 : MonoBehaviour
{
    public GameObject stand;
    public GameObject crounch;
    public GameManager gameManager;
    public koinscore Koin;

    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("s"))
        {
            stand.SetActive(true);
            crounch.SetActive(false);
        }
    }

    
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "obstacle")
        {
            gameManager.GameOver();

        }

    }



}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class chara : MonoBehaviour
{
    public GameObject stand;
    public GameObject crounch;
    Rigidbody2D rb;
    bool Isjumping;
    public GameManager gameManager;
    public koinscore Koin;
    
    // Start is called before the first frame update

    // references

    void Start()
    {
       
      
        rb = GetComponent<Rigidbody2D>();
        Isjumping= false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w")&&Isjumping==false)
        {
            rb.velocity = new Vector3(0, 20, 0);
            Isjumping = true;
        }
        if (Input.GetKey("s") && Isjumping == false)
        {
            crounch.SetActive(true);
            stand.SetActive(false);
        }
        
    }
   
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        
        Isjumping = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        
        if (collision.tag=="obstacle")
        {
            gameManager.GameOver();
            
        }
        
       
        
    }
    

    


}

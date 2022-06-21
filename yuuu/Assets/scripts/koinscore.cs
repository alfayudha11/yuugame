using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class koinscore : MonoBehaviour
{
    public Text MycoinText;
    public int CoinNum;
   
    


    // Start is called before the first frame update
    void Start()
    {
        CoinNum =0;
        MycoinText.text = "UANG:" + CoinNum;
      
        
    }
    private void OnTriggerEnter2D(Collider2D Mycoin)
    {
        if (Mycoin.tag == "coin")
        {
            CoinNum++;
            Destroy(Mycoin.gameObject);
            MycoinText.text = "UANG :" + CoinNum;
        }
    }
    
   
    // Update is called once per frame
   
}

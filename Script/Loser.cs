using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loser : MonoBehaviour
{
    public GameObject loser;
    public Text coin;
    // Start is called before the first frame update
    void Start()
    { 
    }
    private void OnEnable()
    {
        
        coin.text="" + PlayerPrefs.GetInt("CoinColletion");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void tryagain()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetInt("CoinColletion", 0);
        var allEnemyCars = GameObject.FindGameObjectsWithTag("Enemy");
        var Coin = GameObject.FindGameObjectsWithTag("Coin");
        
        foreach (var Car in allEnemyCars)
        { 
            Destroy(Car.gameObject);
        }
        foreach (var Coinn in Coin)
        { 
            Destroy(Coinn.gameObject);
        }

        PlayerPrefs.SetInt("Status",0);
        loser.SetActive(false);
        Time.timeScale = 1.0f;




        /*Time.time*/
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameObject Coinn;
    float[] GenretePositon = { -1.71f, -0.61f, 0.57f, 1.75f };
    // Start is called before the first frame update
    void Start()
    {
        Invoke("CoinGenrete",2f);
    }
    void CoinGenrete()
    {

        
        var CoinPos = GenretePositon[Random.Range(0, GenretePositon.Length)];


        Vector3 CoinPosition = new Vector3(CoinPos, transform.position.y, 0);
        Instantiate(Coinn, CoinPosition, Quaternion.identity);

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            Invoke("CoinGenrete", 0.6f);

        }
        else
        {
            Invoke("CoinGenrete", 2f);


        }



    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

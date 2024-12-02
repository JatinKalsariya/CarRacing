using UnityEngine;
using UnityEngine.UI;

public class pPayer : MonoBehaviour
{
    public GameObject Win;
    public Text Count;
    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Count.text = "" + 0;
        if (collision.gameObject.tag == "Enemy")
        {
            Time.timeScale = 0f;
            Win.SetActive(true);
        }
        if (collision.gameObject.tag == "Coin")
        {
            var colletion=PlayerPrefs.GetInt("CoinColletion");
            PlayerPrefs.SetInt("CoinColletion",colletion+5);

            Count.text = "" + PlayerPrefs.GetInt("CoinColletion");
            
            Destroy(collision.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {

           

            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
            {
                var newPosition = transform.position;
                if (newPosition.x > (-1.91f))
                {
                    newPosition.x -= 5 * Time.deltaTime;
                    transform.position = newPosition;
                }

            }
            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            {
                var newPosition = transform.position;
                if (newPosition.x < (1.91f))
                {
                    newPosition.x += 5 * Time.deltaTime;
                    transform.position = newPosition;
                }

            }
        

    }
}

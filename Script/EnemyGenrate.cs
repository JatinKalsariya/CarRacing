using UnityEngine;

public class EnemyGenrete : MonoBehaviour
{
    public GameObject[] Enemyprefab;
    float[] GenretePositon = { -1.71f, -0.61f, 0.57f, 1.75f };
    // Start is called before the first frame update
    void Start()
    {

        Invoke("CarGenrete", 1f);


    }

    void CarGenrete()
    {
        
            var CarGenrete = Enemyprefab[Random.Range(0, Enemyprefab.Length)];
            var CarPos = GenretePositon[Random.Range(0, GenretePositon.Length)];


            Vector3 CarPosition = new Vector3(CarPos, transform.position.y, 0);
            Instantiate(CarGenrete, CarPosition, Quaternion.identity);

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            Invoke("CarGenrete",0.6f);

        }
        else 
        {
            Invoke("CarGenrete",1.9f);


        }



    }

    void Update()
    {



    }
}

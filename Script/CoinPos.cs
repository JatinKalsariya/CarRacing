using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var newPosition = transform.position;

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            newPosition.y -= 5 * Time.deltaTime;
        }

        newPosition.y -= 2 * Time.deltaTime;
        transform.position = newPosition;

        if (transform.position.y <= -6.14f)
        {
            Destroy(transform.gameObject);
        }

    }
}

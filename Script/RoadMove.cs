using UnityEngine;

public class RoadMove : MonoBehaviour
{
    Material material;
    public float speed;
    Vector2 lastPosition;
    // Start is called before the first frame update
    void Start()
    {

        material = GetComponent<Renderer>().material;
        lastPosition = material.mainTextureOffset;
    }

    // Update is called once per frame
    void Update()
    {
       

            lastPosition.y += 0.9f * Time.deltaTime;
            material.mainTextureOffset = lastPosition;
            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
            {

                lastPosition.y += 0.9f * Time.deltaTime;
                material.mainTextureOffset = lastPosition;
            }
            if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
            {
                lastPosition.y -= 0.2f * Time.deltaTime;
                material.mainTextureOffset = lastPosition;
            }
        

    }
}

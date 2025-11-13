using UnityEngine;

public class Cross : MonoBehaviour
{
    private int      movementSpeed = 4;
    private Vector3   verticalAxis = new Vector3(0, 1, 0);
    private Vector3 horizontalAxis = new Vector3(1, 0, 0);
    // LÍMITES
    private float         topLimit = 10.0f;
    private float      bottomLimit = 4.5f;
    private float        leftLimit = -9.0f;
    private float       rightLimit = 10.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.W))   //Alternativa
        if (Input.GetKey("w") && transform.position.y < topLimit)
        {
            transform.Translate(verticalAxis * movementSpeed * Time.deltaTime);
        }
        if (Input.GetKey("s") && transform.position.y > bottomLimit)
        {
            transform.Translate(verticalAxis * movementSpeed * Time.deltaTime * (-1));
        }
        if (Input.GetKey("a") && transform.position.x > leftLimit)
        {
            transform.Translate(horizontalAxis * movementSpeed * Time.deltaTime * (-1));
        }
        if (Input.GetKey("d") && transform.position.x < rightLimit)
        {
            transform.Translate(horizontalAxis * movementSpeed * Time.deltaTime);
        }
    }
}
using UnityEngine;

public class Cross : MonoBehaviour
{
    [SerializeField] private int movementSpeed = 4;
    private Vector3 verticalAxis = new Vector3(0, 1, 0);
    private Vector3 horizontalAxis = new Vector3(1, 0, 0); // Negativo por la posición de la cámara.
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.W))   //Alternativa
        if (Input.GetKey("w"))
        {
            transform.Translate(verticalAxis * movementSpeed * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            transform.Translate(verticalAxis * movementSpeed * Time.deltaTime * (-1));
        }
        if (Input.GetKey("a"))
        {
            transform.Translate(horizontalAxis * movementSpeed * Time.deltaTime * (-1));
        }
        if (Input.GetKey("d"))
        {
            transform.Translate(horizontalAxis * movementSpeed * Time.deltaTime);
        }
    }
}

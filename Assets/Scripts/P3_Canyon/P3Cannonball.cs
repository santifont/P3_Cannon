using UnityEngine;

public class P3Cannonball : MonoBehaviour
{
    private Rigidbody          rb;
    private GameObject startPoint;
    private GameObject gameManager;
    private int        collisionValue = 0;
    private int        shootingForce  = 600;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startPoint = GameObject.Find("StartPoint");
        rb.AddForce(0, shootingForce, shootingForce);

        gameManager = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        // Se destruye después de chocarse dos veces. 1 =  el cañón, 2 = el target.
        collisionValue++;
        if (collisionValue == 2)
        {
            Destroy(gameObject);
        }
    }
}
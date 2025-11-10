using UnityEngine;

public class Cannonball : MonoBehaviour
{
    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Vector3 direction = new Vector3(0, 500, 0);
        rb.AddForce(direction * 5);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

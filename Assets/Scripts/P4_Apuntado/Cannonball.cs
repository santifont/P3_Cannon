using UnityEngine;

public class Cannonball : MonoBehaviour
{
    private Rigidbody                  rb;
    private GameObject         startPoint;
    private GameObject        finishPoint;
    private int       shootingForce = 200;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startPoint = GameObject.Find("StartPoint");
        finishPoint = GameObject.Find("FinishPoint");

        Vector3 direccion = finishPoint.transform.position - startPoint.transform.position;
        rb.AddForce(direccion * shootingForce);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -1)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
            Destroy(gameObject);
    }
}
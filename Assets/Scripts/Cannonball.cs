using UnityEngine;

public class Cannonball : MonoBehaviour
{
    private Rigidbody rb;
    private GameObject startPoint;
    private GameObject finishPoint;
    private Vector3 distance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startPoint = GameObject.Find("StartPoint");
        finishPoint = GameObject.Find("FinishPoint");

        Vector3 direction = new Vector3(0, 500, 0);
        //rb.AddForce();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

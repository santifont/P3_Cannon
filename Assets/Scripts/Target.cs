using UnityEngine;
using UnityEngine.UIElements;

public class Target : MonoBehaviour
{
    private int state = 0;
    private Renderer renderer;
    private float rotationSpeed = 5f;
    private Vector3 rotationAngle = new Vector3(0, 45.0f, 0);
    private GameObject cannon;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        renderer = GetComponent<Renderer>();
        cannon = GameObject.Find("Cannon");
    }

    // Update is called once per frame
    void Update()
    {
        if (state == 2)
        {
            transform.Rotate(rotationAngle * rotationSpeed * Time.deltaTime, Space.World);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        state++;

        if (state == 1)
        {
            renderer.material.color = new Color(Random.value, Random.value, Random.value);
        }
        else if (state == 3)
        {
           cannon.GetComponent<TargetInstantiates>().SpawnTarget();
            Destroy(gameObject);
        }
    }
}

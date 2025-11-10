using UnityEngine;
using UnityEngine.UIElements;

public class Target : MonoBehaviour
{
    private int state = 0;
    Renderer renderer;
    float rotationSpeed = 5.0f;
    Vector3 rotationAngle = new Vector3(0, 45.0f, 0);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        renderer = GetComponent<Renderer>();

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
            Destroy(gameObject);
        }
    }
}

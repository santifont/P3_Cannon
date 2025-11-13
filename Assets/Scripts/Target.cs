using UnityEngine;
using UnityEngine.UIElements;

public class Target : MonoBehaviour
{
    private int state = 0;
    private Renderer renderer;
    private float rotationSpeed = 2.5f;
    private Vector3 rotationAngle = new Vector3(0, 45.0f, 0);
    private GameObject randomPosition; // Random Position
    public GameObject targetPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        renderer = GetComponent<Renderer>();

        // Random Position
        randomPosition = GameObject.Find("Pos" + Random.Range(1, 6));
        Debug.Log(randomPosition.name);

        transform.position = randomPosition.transform.position;
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
        transform.position = randomPosition.transform.position;

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

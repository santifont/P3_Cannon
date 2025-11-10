using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject balaPrefab;
    private GameObject puntoDisparo;
    private GameObject gameManager;
    private Renderer renderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        renderer = GetComponent<Renderer>();
        balaPrefab = GameObject.Find("Cannonball");
        puntoDisparo = GameObject.Find("StartPoint");

        gameManager = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shoot()
    {
        Debug.LogWarning("Button -> Shoot");
        Instantiate(balaPrefab, puntoDisparo.transform.position, Quaternion.identity);
        gameManager.GetComponent<GameManager>().IncNumBalas();
    }

    public void ShootRandom()
    {
        Instantiate(balaPrefab, puntoDisparo.transform.position, Quaternion.identity);
        gameManager.GetComponent<GameManager>().IncNumBalas();
    }

    private void OnCollisionEnter(Collision collision)
    {
        renderer.material.color = Color.red;
    }

    private void OnCollisionExit(Collision collision)
    {
        renderer.material.color = Color.white;
    }
}

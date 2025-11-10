using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject balaPrefab;
    private GameObject puntoDisparo;
    private GameObject gameManager;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        balaPrefab = GameObject.Find("Cannonball");
        puntoDisparo = GameObject.Find("ShootingStartingPoint");

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
}

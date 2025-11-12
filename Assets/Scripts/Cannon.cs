using UnityEngine;

public class Cannon : MonoBehaviour
{
    public  GameObject balaPrefab;
    private GameObject startPoint;
    private GameObject finishPoint;
    private Vector3    distance;
    private GameObject gameManager;
    private Renderer   renderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        renderer = GetComponent<Renderer>();
        startPoint = GameObject.Find("StartPoint");
        finishPoint = GameObject.Find("FinishPoint");


        gameManager = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Shoot()
    {
        Debug.LogWarning("Button -> Shoot");
        Instantiate(balaPrefab, startPoint.transform.position, Quaternion.identity);
        gameManager.GetComponent<GameManager>().IncNumBalas();
    }

    public void WhiteShoot()
    {
        Debug.Log("WhiteShoot");


        GameObject nuevaBala = Instantiate(balaPrefab, startPoint.transform.position, Quaternion.identity);

        // Color Aleatorio
        Color[] randomColor = { Color.white, Color.black, Color.red, Color.green, Color.blue };
        nuevaBala.GetComponent<Renderer>().material.color = randomColor[Random.Range(0, randomColor.Length)];

        // Tamaño aleatorio
        float randomScale = Random.Range(1.0f, 2.0f);
        nuevaBala.GetComponent<Transform>().localScale = nuevaBala.GetComponent<Transform>().localScale * randomScale;

        // Fuerza aleatoria
        float force = Vector3.Distance(startPoint.transform.position, finishPoint.transform.position);
        distance = new Vector3(0, force, force * (-1));
        nuevaBala.GetComponent<Rigidbody>().AddForce(distance * Random.Range(1,51));



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

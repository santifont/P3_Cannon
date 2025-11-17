using UnityEngine;

public class Cannon : MonoBehaviour
{
    public  GameObject balaPrefab;
    private GameObject startPoint;
    private GameObject finishPoint;
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
        Instantiate(balaPrefab, startPoint.transform.position, Quaternion.identity);
        gameManager.GetComponent<GameManager>().IncNumBalas();
    }

    public void WhiteShoot()
    {
        GameObject nuevaBala = Instantiate(balaPrefab, startPoint.transform.position, Quaternion.identity);

        // Color Aleatorio entre 5 valores concretos
       /* Color[] randomColor = { Color.white, Color.black, Color.red, Color.green, Color.blue };
        nuevaBala.GetComponent<Renderer>().material.color = randomColor[Random.Range(0, randomColor.Length)]; */

        // Color aleatorio entre valores completamente aleatorios sin límites
        nuevaBala.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);

        // Tamaño aleatorio
        float randomScale = Random.Range(0.3f, 1.0f);
        nuevaBala.GetComponent<Transform>().localScale = nuevaBala.GetComponent<Transform>().localScale * randomScale;

        // Fuerza aleatoria
        Vector3 direccion = finishPoint.transform.position - startPoint.transform.position;
        nuevaBala.GetComponent<Rigidbody>().AddForce(direccion * Random.Range(150,501));

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

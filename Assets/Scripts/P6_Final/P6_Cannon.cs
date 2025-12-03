using UnityEngine;

public class P6_Cannon : MonoBehaviour
{
    public  GameObject balaPrefab;
    private GameObject startPoint;
    // private GameObject finishPoint;
    private GameObject gameManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPoint = GameObject.Find("StartPoint");
        // finishPoint = GameObject.Find("FinishPoint");
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
}

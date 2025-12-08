using UnityEngine;

public class P6_Target : MonoBehaviour
{
    private int state = 0; // Estado de la diana.
    private float rotationSpeed = 5f;
    private GameObject gameManager;
    private Renderer renderer;
    private Vector3 rotationAngle = new Vector3(0, 45.0f, 0);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        renderer = GetComponent<Renderer>();
        gameManager = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        gameManager.GetComponent<P6_TargetInstantiate>().SpawnTarget();
        gameManager.GetComponent<P6_GameManager>().IncDianasAcertadas();
        Destroy(gameObject);
    }
}

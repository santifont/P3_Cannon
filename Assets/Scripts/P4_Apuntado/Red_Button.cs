using UnityEngine;

public class Red_Button : MonoBehaviour
{
    private GameObject[] cannonballs;
    private GameObject         reset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        reset = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        reset.GetComponent<GameManager>().ResetearBalas();
        cannonballs = GameObject.FindGameObjectsWithTag("cannonball");
        for (int i = 0; i < cannonballs.Length; i++)
        {
            Destroy(cannonballs[i]);
        }
    }
}

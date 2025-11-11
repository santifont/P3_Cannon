using UnityEngine;

public class Red_Button : MonoBehaviour
{
    GameObject[] cannonballs;
    GameObject reset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        reset = GameObject.Find("GameManager");
        cannonballs = GameObject.FindGameObjectsWithTag("cannonball");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        Debug.Log("RED");

        reset.GetComponent<GameManager>().ResetearBalas();

        for (int i = 1; i < cannonballs.Length; i++)
        {
            Destroy(cannonballs[i]);
        }
    }
}

using UnityEngine;

public class Red_Button : MonoBehaviour
{
    GameObject[] cannonballs;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cannonballs = GameObject.FindGameObjectsWithTag("cannonball");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        Debug.Log("Botón rojo");
        for (int i = 0; i < cannonballs.Length; i++)
        {
            Destroy(cannonballs[i]);
        }
    }
}

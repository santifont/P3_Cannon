using UnityEngine;

public class White_Button : MonoBehaviour
{
    GameObject cannon;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cannon = GameObject.Find("CannonMachine");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        Debug.Log("Botón blanco");

    }
}

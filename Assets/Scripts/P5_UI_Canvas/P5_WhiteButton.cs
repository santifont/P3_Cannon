using UnityEngine;

public class P5_WhiteButton : MonoBehaviour
{
    private GameObject cannon;
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
        cannon.GetComponent<P5_Cannon>().WhiteShoot();
    }
}

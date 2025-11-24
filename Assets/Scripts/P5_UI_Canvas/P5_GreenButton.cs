using Unity.VisualScripting;
using UnityEngine;
using TMPro;
public class P5_GreenButton : MonoBehaviour
{
    private GameObject cannon;
    private GameObject potenciaCanvas;
    private TextMeshProUGUI potenciaText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cannon = GameObject.Find("CannonMachine");
        potenciaCanvas = GameObject.Find("Potencia Canvas");
        potenciaText = potenciaCanvas.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        cannon.GetComponent<P5_Cannon>().Shoot();
    }
}

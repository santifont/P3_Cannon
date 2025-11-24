using Unity.VisualScripting;
using UnityEngine;
using TMPro;
public class P5_GreenButton : MonoBehaviour
{
    private float           tiempoInicio;
    private float            tiempoFinal;
    public  float      potenciaAcumulada = 0.0f;
    private Color           initialColor;
    private Renderer            renderer;
    private GameObject            cannon;
    private GameObject    potenciaCanvas;
    private TextMeshProUGUI potenciaText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        initialColor = GetComponent<Renderer>().material.color;
        renderer = GetComponent<Renderer>();
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
        renderer.material.color = Color.red;
        tiempoInicio = Time.time;
        Debug.Log(tiempoInicio);

    }

    private void OnMouseUp()
    {
        renderer.material.color = initialColor;
        tiempoFinal = Time.time;

        potenciaAcumulada = tiempoFinal - tiempoInicio + 1;
        potenciaText.text = "Potencia: " + potenciaAcumulada;
        cannon.GetComponent<P5_Cannon>().Shoot();
    }
}

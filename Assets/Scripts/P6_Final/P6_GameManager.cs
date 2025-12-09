using TMPro;
using UnityEngine;

public class P6_GameManager : MonoBehaviour
{
    private float numBalas = 0.0f;
    private float numDianas = 0.0f;
    private GameObject balasCanvas;
    private GameObject dianasCanvas;
    private GameObject potenciaDianas;
    private TextMeshProUGUI balasTexto;
    private TextMeshProUGUI dianasTexto;
    private TextMeshProUGUI potenciaTexto;
    private float precision;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        balasCanvas = GameObject.Find("Balas Canvas");
        dianasCanvas = GameObject.Find("Dianas Canvas");
        potenciaDianas = GameObject.Find("Potencia Canvas");
        balasTexto = balasCanvas.GetComponent<TextMeshProUGUI>();
        dianasTexto = dianasCanvas.GetComponent<TextMeshProUGUI>();
        potenciaTexto = dianasCanvas.GetComponent<TextMeshProUGUI>();
    }
    // Update is called once per frame
    void Update()
    {
        // PRUEBA DE PRECISIÓN
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(precision + "% de precisión.");
        }
    }
    public void ResetearBalas()
    {
        // Poner el número de balas a cero y cambiar el texto del canvas
        // Debug.LogWarning("Reseteando el número de balas");
        numBalas = 0.0f;
        balasTexto.text = "Balas: " + numBalas;
    }
    public void IncNumBalas()
    {
        // Incrementar el número de balas y cambiar el texto del canvas
        // Debug.LogWarning("Incrementando el número de balas");
        numBalas++;
        balasTexto.text = "Balas: " + numBalas;
    }
    public void DecNumBalas()
    {
        // Decrementar el número de balas y cambiar el texto del canvas

    }
    public void IncDianasAcertadas()
    {
        numDianas++;
        dianasTexto.text = "Dianas: " + numDianas;
        CalcularPrecision();
    }

    private void CalcularPrecision()
    {
        precision = numDianas / numBalas * 100;
        precision = Mathf.RoundToInt(precision);
    }
}

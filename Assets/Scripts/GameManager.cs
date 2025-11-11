using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    int numBalas = 0;
    GameObject balasCanvas;
    TextMeshProUGUI balasTexto;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        balasCanvas = GameObject.Find("Balas Canvas");
        balasTexto = balasCanvas.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetearBalas()
    {
        // Poner el número de balas a cero y cambiar el texto del canvas
        Debug.LogWarning("Reseteando el número de balas");
        numBalas = 0;
        balasTexto.text = "Balas: " + numBalas;
    }

    public void IncNumBalas()
    {
        // Incrementar el número de balas y cambiar el texto del canvas
        Debug.LogWarning("Incrementando el número de balas");

        numBalas++;
        balasTexto.text = "Balas: " + numBalas;
    }

    public void DecNumBalas()
    {
        // Decrementar el número de balas y cambiar el texto del canvas
    }
}

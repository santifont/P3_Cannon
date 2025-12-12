using TMPro;
using UnityEngine;

public class P6_GameManager : MonoBehaviour
{
    private float numBalas = 0.0f;
    private float numDianas = 0.0f;
    private float precision;
    private float gameTime;
    private GameObject   timer;
    private GameObject   balasCanvas;
    private GameObject   dianasCanvas;
    private GameObject   victoriaCanvas;
    private GameObject   derrotaCanvas;
    private GameObject   puntero;
    private GameObject   cannon;
    private GameObject   fireButton;
    private GameObject[] cannonball;
    private TextMeshProUGUI balasTexto;
    private TextMeshProUGUI dianasTexto;
    private TextMeshProUGUI victoriaText;
    private TextMeshProUGUI derrotaText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //GOs
        timer          = GameObject.Find("Timer");
        balasCanvas    = GameObject.Find("Balas Canvas");
        dianasCanvas   = GameObject.Find("Dianas Canvas");
        victoriaCanvas = GameObject.Find("VictoriaCanvas");
        victoriaText   = GameObject.Find("VictoriaText").GetComponent<TextMeshProUGUI>();
        derrotaCanvas  = GameObject.Find("DerrotaCanvas");
        derrotaText    = GameObject.Find("DerrotaText").GetComponent <TextMeshProUGUI>();
        puntero        = GameObject.Find("Cross");
        cannon         = GameObject.Find("Cannon");
        fireButton     = GameObject.Find("FireButton");
        // texto
        balasTexto     = balasCanvas.GetComponent<TextMeshProUGUI>();
        dianasTexto    = dianasCanvas.GetComponent<TextMeshProUGUI>();
        //otros
        gameTime       = GameObject.Find("Timer").GetComponent<Timer>().gameTime;
        victoriaCanvas.SetActive(false);
        derrotaCanvas.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        // PRUEBA DE PRECISIÓN
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CalcularPrecision();
            Debug.Log(precision + "% de precisión.");
        }

        //GameManager timer
        if (gameTime > 0)
        {
            gameTime = gameTime - Time.deltaTime;
        }

            if (numBalas == 20 || gameTime < 0)
        {
            CalcularPrecision();
            if (precision >= 50.0f)
            {
                CargarVictoria();
            }
            else
            {
                CargarDerrota();
            }
        }
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

    public void AddTime()
    {
        gameTime = gameTime + 3;
    }

    private void CalcularPrecision()
    {
        precision = numDianas / numBalas * 100;
        if (precision >= 0)
        {
            precision = Mathf.RoundToInt(precision);
        }
        else
        {
            precision = 0.0f;
        }
    }

    public void CargarVictoria()
    {
        CalcularPrecision();
        victoriaCanvas.SetActive(true);
        victoriaText.text = "¡VICTORIA!" + "\n\nPrecisión: " + precision + "%";
        puntero.SetActive(false);
        cannon.SetActive(false);
        fireButton.SetActive(false);
        cannonball = GameObject.FindGameObjectsWithTag("cannonball");
        for (int i = 0; i < cannonball.Length; i++)
        {
            Destroy(cannonball[i]);
        }
        gameTime = 0.0f;
        timer.GetComponent<Timer>().TimerToZero();
        gameObject.SetActive(false);
    }

    public void CargarDerrota()
    {
        CalcularPrecision();
        derrotaCanvas.SetActive(true);
        derrotaText.text = "DERROTA..." + "\n\nPrecisión: " + precision + "%";
        puntero.SetActive(false);
        cannon.SetActive(false);
        fireButton.SetActive(false);
        cannonball = GameObject.FindGameObjectsWithTag("cannonball");
        for (int i = 0; i < cannonball.Length; i++)
        {
            Destroy(cannonball[i]);
        }
        gameTime = 0.0f;
        timer.GetComponent<Timer>().TimerToZero();
        gameObject.SetActive(false);
    }
}

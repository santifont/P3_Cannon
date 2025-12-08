using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float gameTime;
    private TextMeshProUGUI timerText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameTime = 20.0f;
        timerText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameTime > 0)
        {
            gameTime = gameTime - Time.deltaTime;
            // timerText.text = gameTime + "/" + Time.deltaTime;

            // "Mathf.Round redonde al número entero más cercano"
            // "Mathf.Floor" trunca al número entero actual o anterior. "Mathf.FloorToInt" hace lo mismo pero convierte a int".
            // "Mathf.Ceil" y "Math.CeilToInt" hace lo contrario.
            float minutes = Mathf.FloorToInt(gameTime / 60);
            float seconds = Mathf.CeilToInt(gameTime % 60);

            // Formato de minutos con segundos
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
        else
        {
            timerText.text = "FIN DE LA PARTIDA";
        }
    }

    public void AddTime()
    {
        gameTime = gameTime + 3;
    }
}

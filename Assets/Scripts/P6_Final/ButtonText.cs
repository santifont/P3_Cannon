using TMPro;
using UnityEngine;

public class ButtonText : MonoBehaviour
{
    TextMeshProUGUI buttonText;
    Color initialColor;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        buttonText = GetComponent<TextMeshProUGUI>();
        initialColor = buttonText.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        buttonText.material.color = Color.white;
    }
}

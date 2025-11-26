using UnityEngine;

public class P6_TargetInstantiate : MonoBehaviour
{
    public  GameObject         target;
    // LÍMITES
    private float    topLimit =  10.0f;
    private float bottomLimit =   4.5f;
    private float leftLimit   = -10.0f;
    private float rightLimit  =  10.0f;
    Vector3 randomPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnTarget()
    {
        float randomX = Random.Range(leftLimit, rightLimit);
        float randomY = Random.Range(bottomLimit, topLimit);
        randomPosition = new Vector3 (randomX, randomY, 15.7f);
        GameObject newTarget = Instantiate(target, randomPosition, Quaternion.identity);
        newTarget.transform.Rotate(90, 0, 0);
    }
}
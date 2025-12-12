using UnityEngine;

public class P6_TargetInstantiate : MonoBehaviour
{
    public  GameObject target;
    // LÍMITES
    private float    topLimit =  15.0f;
    private float bottomLimit =   4.0f;
    private float leftLimit   = -15.0f;
    private float rightLimit  =  15.0f;
    private Vector3 randomPosition;
    private GameObject addTime;
    private GameObject addTime2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        addTime = GameObject.Find("Timer");
        addTime2 = GameObject.Find("GameManager");
    }
    // Update is called once per frame
    void Update()
    {

    }
    public void SpawnTarget()
    {
        addTime.GetComponent<Timer>().AddTime();
        addTime2.GetComponent<P6_GameManager>().AddTime();
        float randomX = Random.Range(leftLimit, rightLimit);
        float randomY = Random.Range(bottomLimit, topLimit);
        randomPosition = new Vector3 (randomX, randomY, 16.5f);
        GameObject newTarget = Instantiate(target, randomPosition, Quaternion.identity);
        newTarget.transform.Rotate(90, 0, 0);
    }
}
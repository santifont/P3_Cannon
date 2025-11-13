using UnityEngine;

public class TargetInstantiates : MonoBehaviour
{
    public  GameObject target;
    private GameObject randomPosition;
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
        randomPosition = GameObject.Find("Pos" + Random.Range(1, 6));
        GameObject newTarget = Instantiate(target, randomPosition.transform.position, Quaternion.identity);
        newTarget.transform.Rotate(90, 0, 0);
    }
}

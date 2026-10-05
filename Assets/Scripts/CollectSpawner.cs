using UnityEngine;

public class CollectSpawner : MonoBehaviour
{
    public float currenttime = 0f, endtime = 5f;
    public GameObject collectprefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currenttime += Time.deltaTime;
        if (currenttime >= endtime)
        {
            Vector2 newcollectpos = new Vector2(transform.position.x, transform.position.y + Random.Range(-3f, 3f));
            GameObject newcollect = Instantiate(collectprefab, newcollectpos, transform.rotation);
            currenttime = 0f;
        }
    }
}

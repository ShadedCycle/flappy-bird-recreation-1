using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    // requires timer
    public float currenttime = 0f, endtime = 3f;
    public GameObject pipeprefab;

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
            Vector2 newpipepos = new Vector2(transform.position.x, transform.position.y + Random.Range(-3f, 3f));
            GameObject newpipe = Instantiate(pipeprefab, newpipepos, transform.rotation);
            currenttime = 0f;
        }

     }
}

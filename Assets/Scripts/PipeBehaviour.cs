using Unity.Mathematics;
using UnityEngine;

public class PipeBehaviour : MonoBehaviour
{

    public float speed = -0.01f;
    public float currenttime = 0f, endtime = 8f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currenttime += Time.deltaTime;

        // Move the pipe from right to left
        transform.position = new Vector2(transform.position.x + speed, transform.position.y);

        if(currenttime >= endtime)
        {
            GameObject.Destroy(gameObject);
        }
    }
}

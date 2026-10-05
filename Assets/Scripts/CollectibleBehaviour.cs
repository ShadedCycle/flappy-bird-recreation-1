using UnityEngine;

public class CollectibleBehaviour : MonoBehaviour
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

        // Move the collectible from right to left
        transform.position = new Vector2(transform.position.x + speed, transform.position.y);

        if (currenttime >= endtime)
        {
            GameObject.Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameObject.Destroy(gameObject);
        }
        if (other.CompareTag("DeathObject"))
        {
            GameObject.Destroy(gameObject);
        }
    }
}

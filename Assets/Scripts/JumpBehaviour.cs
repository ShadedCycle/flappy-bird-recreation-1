using System.IO.Pipes;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JumpBehaviour : MonoBehaviour
{
    // Reference to the Rigidbody2D
    public Rigidbody2D rb;
    public float jumpforce = 20f;
    public int startingjumps = 10;
    public AudioSource jumpsfx, deathsfx, nojumpssfx;
    public GameManager gamemanager;
    [HideInInspector] public int jumps;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        jumps = startingjumps;
    }

    // Update is called once per frame
    void Update()
    {
        // if the player presses [SPACE], add force to the Rigidbody2D
        if (gamemanager.IsGamePaused == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (jumps > 0)
                {
                    rb.AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse);
                    jumpsfx.Play();
                    jumps -= 1;
                }
                else
                {
                    nojumpssfx.Play();
                }
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        deathsfx.PlayOneShot(deathsfx.clip);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

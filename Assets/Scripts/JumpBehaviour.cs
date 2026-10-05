using NUnit.Framework;
using System;
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
    public int additionaljumps = 8;
    public AudioSource jumpsfx, deathsfx, nojumpssfx;
    public GameManager gamemanager;
    [HideInInspector] public int jumps;
    public string deathtag = "DeathObject";
    public string collecttag = "CollectibleObject";
    private GameObject collectibletriggered;

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
        if (other.CompareTag(deathtag))
        {
            deathsfx.PlayOneShot(deathsfx.clip);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (other.CompareTag(collecttag))
        {
            jumps += additionaljumps;
            collectibletriggered = other.GetComponent<GameObject>();
            GameObject.Destroy(collectibletriggered);
        }
    }
}

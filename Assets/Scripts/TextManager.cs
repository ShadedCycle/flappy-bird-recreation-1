using UnityEngine;
using TMPro;

public class TextManager : MonoBehaviour
{
    public TextMeshProUGUI jumpstext;
    private int jumps;
    public JumpBehaviour jumpBehaviour;
    private float timer = 0.0f;
    private int seconds = 0;
    public TextMeshProUGUI scoretext;
    public GameManager gameManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // Timer solution from https://discussions.unity.com/t/how-to-make-a-timer-that-counts-up-in-seconds-as-an-int/147546/5
        // Accessed 5/10/2026
        if (gameManager.IsGamePaused == false)
        {
            timer += Time.deltaTime;
            seconds = (int)(timer % 60);
        }
        
        scoretext.text = seconds + " seconds survived";
        jumpstext.text = jumpBehaviour.jumps.ToString() + " jumps remaining";
    }
}

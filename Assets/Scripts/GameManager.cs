using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool IsGamePaused = true;
    public GameObject GameUI;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        Time.timeScale = 0;
    }

    public void PauseGame()
    {
        IsGamePaused = true;
        Time.timeScale = 0;
    }

    public void UnPauseGame()
    {
        IsGamePaused = false;
        Time.timeScale = 1;
    }
}

using UnityEngine;
using TMPro;

public class TextManager : MonoBehaviour
{
    public TextMeshProUGUI jumpstext;
    private int jumps;
    public JumpBehaviour jumpBehaviour;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        jumpstext.text = jumpBehaviour.jumps.ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonscript : MonoBehaviour
{
    public Button button;
    private GameManager gamemanager;
    public int difficulty;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        gamemanager = GameObject.Find("GameManager").GetComponent<GameManager>();
        button.onClick.AddListener(sedificulty);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void sedificulty()
    {
        gamemanager.GameStart(difficulty);
        Debug.Log(button.gameObject.name + "is clicked");
    }
}

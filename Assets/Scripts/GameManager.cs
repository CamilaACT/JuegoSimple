using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    public int score;
    public static GameManager inst;

    public Text scoreText;
    [SerializeField] PlayerMovement playerMovement;

    [SerializeField] AudioSource audioSource;

    public void IncrementScore()
    {
        audioSource.Play();
        score++;
        scoreText.text = "SCORE: " + score;

        //AUMENTAR LA VELOCIDAD

        playerMovement.speed += playerMovement.seedIncreasePerPoint;
    }
    private void Awake()
    {
        inst = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{
    public bool ballDrop;
    public bool ballRoll;
    public bool cannon;
    public bool newton;
    
    public GameObject levelBallDrop;
    public GameObject levelBallRoll;
    public GameObject levelCannon;
    public GameObject levelNewton;

    AudioSource Startmusic;
    AudioSource LevelMusic1;
    AudioSource LevelMusic2;
    AudioSource TransMusic;
    AudioSource WinMusic;
    AudioSource ProfIntro;
    AudioSource ProfTalk1;

    // Start is called before the first frame update
    void Start()
    {
        ballDrop = true;
        ballRoll = false;
        newton = false;
        cannon = false;
        Startmusic = GetComponent<AudioSource>();
        LevelMusic1 = GetComponent<AudioSource>();
        LevelMusic2 = GetComponent<AudioSource>();
        TransMusic = GetComponent<AudioSource>();
        WinMusic = GetComponent<AudioSource>();
        ProfIntro = GetComponent<AudioSource>();
        ProfTalk1 = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
       Transitions(); 
    }

    void Transitions()
    {
        if (ballDrop == true)
        {
            levelBallRoll.SetActive(false);
            levelCannon.SetActive(false);
            levelNewton.SetActive(false);
            levelBallDrop.SetActive(true);
        }
        if (ballRoll == true)
        {
            levelCannon.SetActive(false);
            levelNewton.SetActive(false);
            levelBallDrop.SetActive(false);
            levelBallRoll.SetActive(true);
        }
        if (newton == true)
        {
            levelBallRoll.SetActive(false);
            levelCannon.SetActive(false);
            levelBallDrop.SetActive(false);
            levelNewton.SetActive(true);
        }
        if (cannon == true)
        {
            levelBallRoll.SetActive(false);
            levelNewton.SetActive(false);
            levelBallDrop.SetActive(false);
            levelCannon.SetActive(true);
        }
    }
    void Music()
    {
        if (cannon == true)
        {

        }
        if (newton == true)
        {

        }
        if (ballRoll == true)
        {

        }
        if (ballDrop == true)
        {

        }
    }
}

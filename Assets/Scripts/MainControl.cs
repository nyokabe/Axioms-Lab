using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainControl : MonoBehaviour
{
    public bool ballDrop;
    public bool ballRoll;
    public bool cannon;
    public bool newton;
    public bool startGame;

    Material m_Ball01;
    Material m_Ball02;
    Material m_Ball03;
    Material m_Ball04;

    public GameObject levelBallDrop;
    public GameObject levelBallRoll;
    public GameObject levelCannon;
    public GameObject levelNewton;
    public GameObject startGameLevel;
    public GameObject ball01;
    public GameObject ball02;
    public GameObject ball03;
    public GameObject ball04;

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
        ballDrop = false;
        ballRoll = false;
        newton = false;
        cannon = false;
        startGame = true;

        Startmusic = GetComponent<AudioSource>();
        LevelMusic1 = GetComponent<AudioSource>();
        LevelMusic2 = GetComponent<AudioSource>();
        TransMusic = GetComponent<AudioSource>();
        WinMusic = GetComponent<AudioSource>();
        ProfIntro = GetComponent<AudioSource>();
        ProfTalk1 = GetComponent<AudioSource>();
        Transitions();
    }

    // Update is called once per frame
    void Update()
    {
        Transitions();
    }

    void Transitions()
    {
        if (startGame == false)
        {
            startGameLevel.SetActive(false);
        }
        if (ballDrop == false)
        {
            levelBallDrop.SetActive(false);
        }
        if (ballRoll == false)
        {
            levelBallRoll.SetActive(false);
        }
        if (newton == false)
        {
            levelNewton.SetActive(false);
        }
        if (cannon == false)
        {
            levelCannon.SetActive(false);
        }
        if (startGame == true)
        {
            startGameLevel.SetActive(true);
        }
        if (ballDrop == true)
        {
            levelBallDrop.SetActive(true);
        }
        if (ballRoll == true)
        {
            levelBallRoll.SetActive(true);
        }
        if (newton == true)
        {
            levelNewton.SetActive(true);
        }
        if (cannon == true)
        {
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
    public void SetLevelBallDropActive()
    {
        startGame = false;
        ballRoll = false;
        newton = false;
        cannon = false;
        ballDrop = true;
        Transitions();
    }
    public void SetLevelBallRollActive()
    {
        startGame = false;
        newton = false;
        cannon = false;
        ballDrop = false;
        ballRoll = true;
        Transitions();
    }
    public void SetLevelNewtonActive()
    {
        startGame = false;
        cannon = false;
        ballDrop = false;
        ballRoll = false;
        newton = true;
        Transitions();
    }
    public void SetLevelCannonActive()
    {
        startGame = false;
        newton = false;
        ballDrop = false;
        ballRoll = false;
        cannon = true;
        Transitions();
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MainControl : MonoBehaviour
{
    public CannonWinConditions cwc;

    public bool ballDrop;
    public bool ballRoll;
    public bool cannon;
    public bool newton;
    public bool startGame;
    public bool winDrop;
    public bool winRoll;
    public bool winCannon;
    public bool tM01;
    public bool tM02;
    public bool tM03;

    public int Tm;
    public int Mu;

    public Text winGameTxt;

    Material m_Ball01;
    Material m_Ball02;
    Material m_Ball03;
    Material m_Ball04;

    public GameObject levelBallDrop;
    public GameObject levelBallRoll;
    public GameObject levelCannon;
    public GameObject levelNewton;
    public GameObject startGameLevel;

    public AudioSource Jazzy;
    public AudioSource AxiomInt;
    public AudioSource CInt;
    public AudioSource Cong;
    public AudioSource BDInt;
    public AudioSource PachinkoInt;
    public AudioSource PachinkoWin;
    public AudioSource Joke01;
    public AudioSource Joke02;
    public AudioSource Joke03;
    public AudioSource Joke04;


    // Start is called before the first frame update
    void Start()
    {
        ballDrop = false;
        ballRoll = false;
        newton = false;
        cannon = false;
        startGame = true;
        winRoll = false;
        winDrop = false;
        winCannon = false;
        tM03 = false;
        tM02 = false;
        tM01 = false;

        winGameTxt.text = "";

        AxiomInt.Play();

        Tm = 0;

        Transitions();
        Music();
    }

    // Update is called once per frame
    void Update()
    {
        Tm = Tm + 1;
        Transitions();
        Music();
        WinGame();
    }

    void Transitions()
    {
        if (startGame == false)
        {
            startGameLevel.SetActive(false);
            AxiomInt.Play();
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
    void WinGame()
    {
        if ( winCannon == true && winDrop == true && winRoll == true )
        {
            winGameTxt.text = "Congratulations, You Win!";
            Music();
        }
    }
    void Music()
    {
        if (cannon == false)
        {
            CInt.Play();
        }
        if (ballRoll == false)
        {
            PachinkoInt.Play();
        }
        if (ballDrop == false)
        {
            BDInt.Play();
        }
        if (winCannon == false)
        {
            Cong.Play();
        }
        if (winDrop == false)
        {
            Joke01.Play();
        }
        if (winRoll == false)
        {
            PachinkoWin.Play();
        }
        if (Tm == 8000)
        {
            Mu = Random.Range(0,4);
            if(Mu == 1)
            {
                Joke01.Play();
                Tm = 0;
            }
            if(Mu == 2)
            {
                Joke02.Play();
                Tm = 0;
            }
            if(Mu == 3)
            {
                Joke03.Play();
                Tm = 0;
            }

        }
    }
    public void SetLevelBallDropActive()
    {
        startGame = false;
        ballRoll = false;
        newton = false;
        cannon = false;
        ballDrop = true;
        winDrop = false;
        Tm = 0;
        Transitions();
    }
    public void SetLevelBallRollActive()
    {
        startGame = false;
        newton = false;
        cannon = false;
        ballDrop = false;
        ballRoll = true;
        winRoll = false;
        Tm = 0;
        Transitions();
    }
    public void SetLevelNewtonActive()
    {
        startGame = false;
        cannon = false;
        ballDrop = false;
        ballRoll = false;
        newton = true;
        Tm = 0;
        Transitions();
    }
    public void SetLevelCannonActive()
    {
        startGame = false;
        newton = false;
        ballDrop = false;
        ballRoll = false;
        cannon = true;
        winCannon = false;
        Tm = 0;
        cwc.Points = 0;
        Transitions();
    }
    public void Win()
    {
        winRoll = true;
    }

}

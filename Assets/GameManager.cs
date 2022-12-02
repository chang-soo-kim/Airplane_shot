using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    
    public Slider hpbar;
    public Player player;
    public MechColl mechcoll;
    public GameObject GameOver;
    public GameObject MissionComplete;

    private float maxHP = 100;
    private float curHP = 100;

    private bool isGameover;

    // Start is called before the first frame update
    void Start()
    {

        isGameover = false;
    }

    // Update is called once per frame
    void Update()
    {
        

        if (mechcoll.counton == true)
        {
            hpbar.value = curHP / maxHP;
            
            --curHP;
            mechcoll.counton = false;
        }

        if(curHP==0)
        {
            MissionComplete.SetActive(true);

            if (Input.GetKeyDown(KeyCode.T))
            {
                SceneManager.LoadScene("SampleScene");
            }
        }
        
        if (isGameover)
        {
            
            if(Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("SampleScene");
            }
        }

    }
    public void EndGame()
    {
        isGameover=true;
        
        GameOver.SetActive(true);
    }

}

﻿using UnityEngine;
using System.Collections;

public class ChatClientScript : MonoBehaviour {

    private GameObject chatClient;
    private GameInformation gameInformation;
    private PeopleInformation peopleInformation;
    private GameObject optionOne;
    private GameObject optionTwo;
    private GameObject optionThree;
    private int selectedOption;

	void Start () 
    {
        chatClient = GameObject.FindGameObjectWithTag("ChatClient");
        gameInformation = GameObject.FindGameObjectWithTag("GameInformation").GetComponent<GameInformation>();
        peopleInformation = GameObject.FindGameObjectWithTag("PeopleInformation").GetComponent<PeopleInformation>();
        optionOne = GameObject.FindGameObjectWithTag("OptionOne");
        optionTwo = GameObject.FindGameObjectWithTag("OptionTwo");
        optionThree = GameObject.FindGameObjectWithTag("OptionThree");

        optionTwo.SetActive(false);
        optionThree.SetActive(false);
        selectedOption = 1;
	}

    public void NextButtonClicked()
    {
        if (selectedOption == 1)
        {
            optionOne.SetActive(false);
            optionTwo.SetActive(true);
            selectedOption = 2;
        }
        else if (selectedOption == 2)
        {
            optionTwo.SetActive(false);
            optionThree.SetActive(true);
            selectedOption = 3;
        }
        else
        {
            optionThree.SetActive(false);
            optionOne.SetActive(true);
            selectedOption = 1;
        }
    }

    public void PrevButtonClicked()
    {
        if (selectedOption == 1)
        {
            optionOne.SetActive(false);
            optionThree.SetActive(true);
            selectedOption = 3;
        }
        else if (selectedOption == 2)
        {
            optionTwo.SetActive(false);
            optionOne.SetActive(true);
            selectedOption = 1;
        }
        else
        {
            optionThree.SetActive(false);
            optionTwo.SetActive(true);
            selectedOption = 2;
        }
    }

    public void ExitButtonClicked()
    {
        chatClient.SetActive(false);
    }
}
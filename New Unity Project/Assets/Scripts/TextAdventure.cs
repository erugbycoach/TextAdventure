using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextAdventure : MonoBehaviour {

    [SerializeField] Text storyTextComponent;
    [SerializeField] State storyState;

    State state;

    private void Start()
    {
        state = storyState;
        storyTextComponent.text = state.GetStateStory();


    }

    private void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        var nextStates = state.GetNextStates();

        for (int index = 0; index < nextStates.Length; index++)
        {
            if(Input.GetKeyDown(KeyCode.Alpha1 + index))
            {
                state = nextStates[index];
            }
        }

        storyTextComponent.text = state.GetStateStory();

    }
} 

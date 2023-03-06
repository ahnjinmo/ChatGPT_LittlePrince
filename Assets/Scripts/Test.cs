using System;
using System.Collections;
using System.Collections.Generic;
using ChatGPTWrapper;
using UnityEngine;

public enum Emotion
{
    neutral = 0,
    happy = 1,
    curious = 2,
    sad = 3,
    anger = 4,
    fear = 5,
    surprised = 6,
    funny = 7,
    laughing = 8
}

public class Test : MonoBehaviour
{
    [SerializeField] 
    private ChatGPTConversation m_ChatGPTConversation;

    [SerializeField] 
    private Animator m_Animator;
    
    private string m_StringToEdit;

    private void Start()
    {
        m_ChatGPTConversation.chatGPTResponse.AddListener(DebugChatGPTResponse);
    }

    public void DebugChatGPTResponse(string res)
    {
        Debug.Log(res);
    }

    private void OnGUI()
    {
        m_StringToEdit = GUI.TextField(new Rect(10, 10, 200, 200), m_StringToEdit);
        
        if (GUI.Button(new Rect(10, 250, 100, 20), "Send To Little Prince"))
        {
            m_ChatGPTConversation.SendToChatGPT(m_StringToEdit);
        }
    }
}
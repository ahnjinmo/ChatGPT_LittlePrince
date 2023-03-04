using System;
using System.Collections;
using System.Collections.Generic;
using ChatGPTWrapper;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] 
    private ChatGPTConversation m_ChatGPTConversation;
    
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
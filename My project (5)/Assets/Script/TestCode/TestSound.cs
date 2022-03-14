using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSound : MonoBehaviour
{
    [SerializeField]
    private AudioClip[] audioclip;

    [SerializeField]
    private AudioClip[] audioData;

    private int stack1 = 0;
    private int stack2 = 0;
    private int stack3 = 0;
    private int stack4 = 0;
    private int stack5 = 0;
    private int stack6 = 0;
    private int stack7 = 0;
    private int stack8 = 0;

    private AudioSource audioSource;

    private int audioStack = 0;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void Click()
    {
        if (audioclip.Length <= audioStack)
        {
            audioStack = 0;
        }
      
        audioSource.clip = audioclip[audioStack];
        audioSource.Play();
        audioStack++;
    }

    public void OnClick1()
    {
        stack1 += 1;
        if (stack1 == 8)
        {
            stack1 = 0;
        }
        

        Debug.Log(stack1);
        audioclip[0] = audioData[stack1];
    }

    public void OnClick2()
    {
        ++stack2;
        if (stack2 == 8)
        {
            stack2 = 0;
        }
        

        audioclip[1] = audioData[stack2];
    }

    public void OnClick3()
    {
        ++stack3;
        if (stack3 == 8)
        {
            stack3 = 0;
        }
        

        audioclip[2] = audioData[stack3];
    }

    public void OnClick4()
    {
        ++stack4;
        if (stack4 == 8)
        {
            stack4 = 0;
        }
        

        audioclip[3] = audioData[stack4];
    }

    public void OnClick5()
    {
        ++stack5;
        if (stack5 == 8)
        {
            stack5 = 0;
        }
        

        audioclip[4] = audioData[stack5];
    }

    public void OnClick6()
    {
        ++stack6;
        if (stack6 == 8)
        {
            stack6 = 0;
        }
        

        audioclip[5] = audioData[stack6];
    }

    public void OnClick7()
    {
        ++stack7;
        if (stack7 == 8)
        {
            stack7 = 0;
        }
        

        audioclip[6] = audioData[stack7];
    }

    public void OnClick8()
    {
        ++stack8;
        if (stack8 == 8)
        {
            stack8 = 0;
        }
        

        audioclip[7] = audioData[stack8];
    }


}

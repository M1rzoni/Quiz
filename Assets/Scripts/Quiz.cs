using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Quiz : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI questionText;
    [SerializeField] QuestionsSO question;
    [SerializeField] GameObject[] answerButtons;
    int correctAnswerIndex;
    [SerializeField] Sprite defaultAnswerSprite;
    [SerializeField] Sprite correctAnswerSprite;

    void Start()
    {

        questionText.text = question.getQuestion();

        for (int i = 0; i < answerButtons.Length; i++)
        {
            TextMeshProUGUI buttonText = answerButtons[i].GetComponentInChildren<TextMeshProUGUI>();
            buttonText.text = question.getAnswer(i);
        }



    }

    public void onAnswerSlected(int index)
    {
        UnityEngine.UI.Image buttonImage;
        if (index == question.getCorrectAnswerIndex())
        {
            questionText.text = "Correct!";
            buttonImage = answerButtons[index].GetComponent<UnityEngine.UI.Image>();
            buttonImage.sprite = correctAnswerSprite;
        }
        else
        {
            correctAnswerIndex = question.getCorrectAnswerIndex();
            string correctAnswer = question.getAnswer(correctAnswerIndex);
            questionText.text = "Sorry, the correct answer was; \n" + correctAnswer;
            buttonImage = answerButtons[correctAnswerIndex].GetComponent<UnityEngine.UI.Image>();
            buttonImage.sprite = correctAnswerSprite;


        }

    }


}

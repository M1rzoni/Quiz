using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Question", menuName = "Create New Qestion", order = 0)]
public class QuestionsSO : ScriptableObject
{

    [TextArea(2, 6)]
    [SerializeField] String question = "Enter the question here";
    [SerializeField] String[] Answers = new string[4];
    [SerializeField] int answersQuestionIndex;

    public string getQuestion()
    {
        return question;
    }

    public int getCorrectAnswerIndex()
    {
        return answersQuestionIndex;
    }

    public string getAnswer(int index)
    {
        return Answers[index];
    }

}


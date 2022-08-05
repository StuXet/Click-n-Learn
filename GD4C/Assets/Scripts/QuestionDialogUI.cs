using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuestionDialogUI : MonoBehaviour
{
    [HideInInspector]public bool used;
    [SerializeField] HelpObject[] helpObjects;

    public void UseObj(int index)
    {
        HelpObject ho = helpObjects[index];
        if (ho.isHelpful)
        {
            ho.gameObject.SetActive(true);
            used = true;
            gameObject.SetActive(false);
        }
        else
        {
            ho.gameObject.SetActive(true);
            ho.SetFalseDelay();
            used = true;
            gameObject.SetActive(false);
        }
    }

   
}
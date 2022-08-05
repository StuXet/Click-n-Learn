using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuestionDialogUI : MonoBehaviour
{
    [HideInInspector]public bool used;
    [SerializeField] GameObject[] objects;

    public void UseObj(int index)
    {
        objects[index].SetActive(true);
        used = true;
        gameObject.SetActive(false);
    }

}
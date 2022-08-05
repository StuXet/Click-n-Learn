using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpObject : MonoBehaviour
{
    public bool isHelpful;
    public int destroyTime;
    [SerializeField] QuestionDialogUI dialogBox;

    public void SetFalseDelay()
    {
        StartCoroutine(SetFalseDelaySec()); 
    }

    IEnumerator SetFalseDelaySec()
    {
        yield return new WaitForSeconds(destroyTime);
        dialogBox.gameObject.SetActive(true);
        dialogBox.used = false;
        gameObject.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpObject : MonoBehaviour
{
    public bool isHelpful;
    public float destroyTime;
    [SerializeField] protected QuestionDialogUI dialogBox;

    public void SetFalseDelay()
    {
        StartCoroutine(SetFalseDelaySec()); 
    }

    virtual protected IEnumerator SetFalseDelaySec()
    {
        yield return new WaitForSeconds(destroyTime);
        dialogBox.used = false;
        gameObject.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bread : HelpObject
{
    Vector2 startPos;

    private void Start()
    {
        startPos = transform.position;
        
    }

    protected override IEnumerator SetFalseDelaySec()
    {
        yield return new WaitForSeconds(destroyTime);
        dialogBox.used = false;
        transform.position = startPos;
        gameObject.SetActive(false);
    }
}

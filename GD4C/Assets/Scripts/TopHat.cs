using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopHat : HelpObject
{
    [SerializeField] Transform playerHatPos;

    // Update is called once per frame
    void Update()
    {
        transform.position = playerHatPos.position;
    }
}

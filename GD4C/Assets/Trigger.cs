using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    private bool _inZone = false;
    public GameObject gm;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("coll");
            _inZone = true;
        }
            gm.SetActive(true);
    }
}

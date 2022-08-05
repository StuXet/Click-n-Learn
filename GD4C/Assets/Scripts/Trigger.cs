using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    private bool _inZone = false;
    public GameObject gm;
    [SerializeField] QuestionDialogUI dialaogBox;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("coll");
            _inZone = true;
            if (!dialaogBox.used)
            {
                dialaogBox.gameObject.SetActive(true);
            }
        }
            //gm.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (dialaogBox.gameObject.activeSelf)
            {
                dialaogBox.gameObject.SetActive(false);
            }
        }
    }
}

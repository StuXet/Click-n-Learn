using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : HelpObject
{
    Vector2 startPos;
    Rigidbody2D rb;
    bool created;

    private void Start()
    {
        startPos = transform.position;
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(300, 300));
        rb.AddTorque(-200);
        created = true;
    }

    private void OnEnable()
    {
        if (created)
        {
            rb.AddForce(new Vector2(300, 300));
            rb.AddTorque(-200);

        }
    }

    protected override IEnumerator SetFalseDelaySec()
    {
        yield return new WaitForSeconds(destroyTime);
        dialogBox.used = false;
        transform.position = startPos;
        gameObject.SetActive(false);
    }
}

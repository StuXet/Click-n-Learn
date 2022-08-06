using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    [SerializeField] Animator scareCrow;
    [SerializeField] Collider2D scareCrowCollider;

    public void HitSc()
    {
        scareCrowCollider.enabled = false;
        scareCrow.SetBool("hit", true);
    }
}

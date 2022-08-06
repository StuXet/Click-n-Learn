using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPoint : MonoBehaviour
{
    [SerializeField] Transform _player;
    [SerializeField] Transform _SpikesSpawnPoint;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("YES!");
        if (collider.gameObject.tag == "Player")
        {
            _player.transform.position = _SpikesSpawnPoint.transform.position;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_FollowPlayer : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Vector3 offset;

    private void Update()
    {
        transform.position = player.position + offset;
    }
}

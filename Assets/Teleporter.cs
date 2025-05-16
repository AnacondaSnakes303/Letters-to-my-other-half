using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class Teleporters : MonoBehaviour
{
    [SerializeField] private Transform destination;

    public Transform GetDestination()
    {
        return destination;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TravelSave : MonoBehaviour 
{

    public GameObject _target;

    private void SaveMovement()
    {
        _positions.Add(index, _target.transform.position);
        _rotations.Add(index, _target.transform.rotation);
        index += 1;
    }

    private void Update()
    {
        SaveMovement();
    }

    private Dictionary<int, Vector3> _positions;
    private Dictionary<int, Quaternion> _rotations;
    private int index = 0;
}

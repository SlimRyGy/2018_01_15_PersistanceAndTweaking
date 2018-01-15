using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPosition : MonoBehaviour 
{
    public GameObject _object;

    public void ResetPos(GameObject obj)
    {
        obj.transform.SetPositionAndRotation(_pos, _rota);
    }

    public void StartPos(GameObject obj)
    {
        _pos    = obj.transform.position;
        _rota   = obj.transform.rotation;
    }

    private void Start()
    {
        StartPos(_object);
    }

    private Vector3 _pos;
    private Quaternion _rota;
}

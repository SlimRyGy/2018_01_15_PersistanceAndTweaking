using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class TravelSave : MonoBehaviour 
{
    public GameObject _target;
    
    private void SaveMovement()
    {
        RecordKey key = new RecordKey();
        key._position = _target.transform.position;
        key._rotation = _target.transform.rotation;
        key._time = Time.deltaTime;
        key._index += 1;
    }

    private void Update()
    {
        SaveMovement();


        //JsonUtility.ToJson();
        //Application.dataPath
        //File.WriteAllText(,);
    }

    private List<RecordKey> _recordList;
}

public class Records {

    private List<RecordKey> _recordList;

    //public RecordKey GetPosition(float when)
    //{

    //    float time = 0;
    //    for (int i = 0; i < _recordList.Count; i++)
    //    {
    //        time += _recordList[i]._time;
    //        if (time >= when)
    //            return _recordList[i];

    //    }
    //    return null;

    //}
}

public class RecordKey {
    public float _time;
    public int _index = 0;
    public Vector3 _position;
    public Quaternion _rotation;
}

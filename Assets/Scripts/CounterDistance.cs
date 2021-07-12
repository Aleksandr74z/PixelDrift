using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterDistance : MonoBehaviour
{
    private Vector3 _oldPosition, _distance;
    private Quaternion _oldAngle;
    private float _totalDistance;
    private float _distanceOnOneFrame;

    public event Action<int> OnDistanceChanged;
    public event Action<int> OnSpeedChanged;
    public event Action<int> OnAngleChanged;

    void Start()
    {
        _oldPosition = transform.position;        
    }

    void FixedUpdate()
    {
        DistanceCovered();
        DefinitionTotalPosition();
        DefinitionDistanceOnOneFrame();

        AngleCar();

    }

    private void DistanceCovered()
    {
        // ������� ������ � ����������� ������ � ����� ������� � ����
        Vector3 distance = transform.position - _oldPosition;
        _oldPosition = transform.position;
        _distance = distance;
    }

    private void DefinitionTotalPosition()
    {
        // ����������� ���������� ��������� �� ����, ��������� � � �������� �� ����� ��������
        _totalDistance += (_distance).magnitude;
        OnDistanceChanged?.Invoke((int)_totalDistance);
    }

    private void DefinitionDistanceOnOneFrame()
    {
        // ����������� �������� � ������� �� ����� ��������
        _distanceOnOneFrame = (_distance).magnitude;
        OnSpeedChanged?.Invoke((int)(_distanceOnOneFrame * 100));
    }

    private void AngleCar()
    {
        // Debug.Log(Math.Abs(Vector3.Angle(_distance, new Vector3(0, 1, 0))));

        // ����������� ���� ����� �������� ����������� ������� � ��������� ������
        float angle = Math.Abs(Vector3.Angle(_distance, new Vector3(0, 1, 0))) - 180 + Math.Abs(180 - transform.eulerAngles.z);
        OnAngleChanged?.Invoke(Math.Abs((int)angle));
        


    }
   
}

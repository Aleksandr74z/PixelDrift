using System;
using UnityEngine;

public class CounterDistance : MonoBehaviour
{
    private Vector3 _oldPosition, _distance;
    private Quaternion _oldAngle;
    private float _totalDistance;
    private float _distanceOnOneFrame;

    public int CompletedDistance { get; private set; }
    public int CarSpeed { get; private set; }
    public int DriftAngle { get; private set; }

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
        CompletedDistance = (int)_totalDistance;
    }

    private void DefinitionDistanceOnOneFrame()
    {
        // ����������� �������� � ������� �� ����� ��������
        _distanceOnOneFrame = (_distance).magnitude;
        CarSpeed = (int)(_distanceOnOneFrame * 100);
    }

    private void AngleCar()
    {
        // Debug.Log(Math.Abs(Vector3.Angle(_distance, new Vector3(0, 1, 0))));

        // ����������� ���� ����� �������� ����������� ������� � ��������� ������
        float angle = Math.Abs(Vector3.Angle(_distance, new Vector3(0, 1, 0))) - 180 + Math.Abs(180 - transform.eulerAngles.z);
        DriftAngle = Math.Abs((int)angle);
        


    }
   
}

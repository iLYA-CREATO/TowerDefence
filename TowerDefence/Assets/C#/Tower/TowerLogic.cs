using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerLogic : MonoBehaviour
{

    [Header("ColliderTrigger"), Tooltip("��������� ������� ������ � ������ ��������������")]public Collider[] TrigCollider;
    [Header("Vector3"), Tooltip("������ ������")] public Vector3 PlayerPosition;
    [Header("Player"), Tooltip("��� ������ �� ����� ����� � ����� ����� ����������� ����� �������")] public GameObject CenterPlayerPosition;
    [Header("Radius"), Tooltip("������ �������� �������� ����")] public float RadiusColliderTower;

    [SerializeField]private bool IsActiveOverlap = false;

    public void Start()
    {
        PlayerPosition = CenterPlayerPosition.transform.position;
    }
    void Update()
    {
        TriggerTower();
    }

    public void TriggerTower()
    {
        TrigCollider = Physics.OverlapSphere(PlayerPosition, RadiusColliderTower);
    }

    // ��������� ���������� ��� ����� � �����
    public void OnDrawGizmos()
    {
        if(IsActiveOverlap == true)
        {
            foreach (Collider collider in TrigCollider)
            {
                // ��������� ���������� ������ ������ ������� � ������� ������������ ��������� Gizmos
                if (collider != null)
                    Gizmos.DrawSphere(PlayerPosition, RadiusColliderTower);
            }
        }
       
    }
}

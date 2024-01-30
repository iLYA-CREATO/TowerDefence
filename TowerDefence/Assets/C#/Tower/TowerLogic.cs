using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerLogic : MonoBehaviour
{

    [Header("ColliderTrigger"), Tooltip("Колайдеры которые попали в радиус взаимодействия")]public Collider[] TrigCollider;
    [Header("Vector3"), Tooltip("Центор игрока")] public Vector3 PlayerPosition;
    [Header("Player"), Tooltip("Сам обьект на сцене откда и будеи барть центральную точку объекта")] public GameObject CenterPlayerPosition;
    [Header("Radius"), Tooltip("Радиус триггера игрового поля")] public float RadiusColliderTower;

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

    // Отрисовка коллайдера для трига у башни
    public void OnDrawGizmos()
    {
        if(IsActiveOverlap == true)
        {
            foreach (Collider collider in TrigCollider)
            {
                // Отрисуйте коллайдеры вокруг вашего объекта с помощью графического примитива Gizmos
                if (collider != null)
                    Gizmos.DrawSphere(PlayerPosition, RadiusColliderTower);
            }
        }
       
    }
}

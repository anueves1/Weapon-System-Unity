using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ShootType { Single, Auto }

public class Gun : MonoBehaviour
{
    [SerializeField]
    private Transform m_Pivot;

    [SerializeField]
    private ShootingSettings m_ShootingSettings;

    [Header("Aiming")]
    [Space(5f)]

    [SerializeField]
    private bool m_VisualizeAim;

    [SerializeField]
    private Vector3 m_AimPosition;

    [SerializeField]
    private Vector3 m_AimRotation;

    [SerializeField]
    private float m_AimSpeed = 2;

    private bool m_IsAiming;
    private bool m_Shoot;

    private Vector3 m_NormalPosition;
    private Vector3 m_NormalRotation;

    private void Awake()
    {
        //Save the start position.
        m_NormalPosition = m_Pivot.localPosition;

        //Save the start rotation.
        m_NormalRotation = m_Pivot.localEulerAngles;
    }

    private void HandleInput()
    {
        //Aim input.
        m_IsAiming = Input.GetKey(KeyCode.Mouse1) || m_VisualizeAim;

        //Shoot input.
        m_Shoot = Input.GetKey(KeyCode.Mouse0);
    }

    private void HandleAiming()
    {
        //Speed.
        var speed = Time.deltaTime * m_AimSpeed;

        //Get the end position.
        var endPosition = m_IsAiming ? m_AimPosition : m_NormalPosition;

        //Get the end rotation.
        var endRotation = m_IsAiming ? m_AimRotation : m_NormalRotation;

        //Lerp to the position.
        m_Pivot.localPosition = Vector3.Lerp(m_Pivot.localPosition, endPosition, speed);

        //Lerp to the rotation.
        m_Pivot.localEulerAngles = Vector3.Slerp(m_Pivot.localEulerAngles, endRotation, speed);
    }

    private void Update()
    {
        HandleInput();

        HandleAiming();

        //If we need to shoot.
        if (m_Shoot)
            Hitscan();
    }

    private void Hitscan()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));

        //Shoot a ray.
        if (Physics.Raycast(ray, out hit, m_ShootingSettings.Distance, m_ShootingSettings.Mask))
        {
            //Debug the name of the object we hit.
            Debug.Log(hit.transform.name);
        }
    }
}

[System.Serializable]
public struct ShootingSettings
{
    public float Distance;

    public LayerMask Mask;
}
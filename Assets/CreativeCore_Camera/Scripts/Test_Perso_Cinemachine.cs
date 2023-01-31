using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Perso_Cinemachine : MonoBehaviour
{
    [SerializeField] private Animator testCinemachineAnimator;

    void Update()
    {
        if (Input.GetKey(KeyCode.R)) testCinemachineAnimator.SetTrigger("Camera1");

        else if (Input.GetKey(KeyCode.T)) testCinemachineAnimator.SetTrigger("Camera2");

        else testCinemachineAnimator.SetTrigger("Default");
    }
}
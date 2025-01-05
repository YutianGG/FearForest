using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Curson : MonoBehaviour
{
    CharacterController characterController;
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}

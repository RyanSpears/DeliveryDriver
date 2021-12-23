using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drive : MonoBehaviour
{
    private string _horizontalAxisString = "Horizontal";
    private string _verticalAxisString = "Vertical";

    [SerializeField]
    float steerSpeed = 1f;

    [SerializeField]
    float moveSpeed = 0.01f;

    void Start()
    {

    }

    void Update()
    {
        float steerAmount = Input.GetAxis(_horizontalAxisString) * steerSpeed;
        float moveAmount = Input.GetAxis(_verticalAxisString) * moveSpeed;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }
}
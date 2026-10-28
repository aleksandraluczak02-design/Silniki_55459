using UnityEngine;
using UnityEngine.InputSystem;


public class InputDebug : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void ONJump()
    {
        Debug.Log("Jump");
    }

    void OnMove(InputValue value)
    {
        Debut.Log(value.Get<Vector2>());
    }
}

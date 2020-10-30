using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static bool[] MouseInputs { get; private set; }
    public static float MouseWheelDelta { get; private set; }
    public static Vector3 MousePosition { get; private set; }

    private int _inputsCount = 2;
    [Header("Debug options") ,SerializeField]
    private bool _displayDebugMessages = false;

    private void Start()
    {
        MouseInputs = new bool[_inputsCount];
    }

    private void Update()
    {
        for(int i = 0; i < _inputsCount; i++)
        {
            MouseInputs[i] = Input.GetMouseButtonDown(i);
            if(_displayDebugMessages)
                Debug.Log("Input #" + i + ": " + MouseInputs[i]);
        }
        MouseWheelDelta = Input.GetAxisRaw("Mouse ScrollWheel");
        MousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (_displayDebugMessages)
            Debug.Log("Mouse wheel direction: " + MouseWheelDelta);
    }
}

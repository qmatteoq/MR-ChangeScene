using HoloToolkit.Unity.InputModule;
using HoloToolkit.Unity.Receivers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonReceiver : InteractionReceiver
{
    protected override void InputDown(GameObject obj, InputEventData eventData)
    {
        if (obj.name == "CircleButton")
        {
            SceneManager.LoadScene("Second");
        }
    }
}

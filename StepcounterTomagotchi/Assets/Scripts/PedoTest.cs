using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Android;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.Android;

public class PedoTest : MonoBehaviour
{
    StepCounter stepCounter;
    [SerializeField] TMP_Text stepCountUI;

    // Start is called before the first frame update


    void Start()

    {
        if (!Permission.HasUserAuthorizedPermission("android.permission.ACTIVITY_RECOGNITION"))
        {
            Permission.RequestUserPermission("android.permission.ACTIVITY_RECOGNITION");
        }

        InputSystem.EnableDevice(AndroidStepCounter.current);

        AndroidStepCounter.current.MakeCurrent();

    }

    // Update is called once per frame
    void Update()
    {
        stepCountUI.text = AndroidStepCounter.current.stepCounter.ReadValue().ToString();
    }
}

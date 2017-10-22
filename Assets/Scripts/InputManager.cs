using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {

    public GameManager gameManager;
    private SteamVR_TrackedObject trackedObj;

    private SteamVR_Controller.Device Controller
    {
        get { return SteamVR_Controller.Input((int)trackedObj.index); }
    }

    // Use this for initialization
    void Start ()
    {

    }

    private void Awake()
    {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
    }

    // Update is called once per frame
    void Update ()
    {
        if (Controller.GetPress(SteamVR_Controller.ButtonMask.Touchpad))
        {
            Vector2 touchpad = (Controller.GetAxis(Valve.VR.EVRButtonId.k_EButton_Axis0));

            if (touchpad.y > 0.2f)
            {
                print("Pressed top part of touch pad!");
                gameManager.LargerPutter();
            }

            else if (touchpad.y < -0.2f)
            {
                print("Pressed bottom part of touch pad!");
                gameManager.SmallerPutter();
            }

        }
    }

    public void Vibrate()
    {
        Controller.TriggerHapticPulse(100);
    }
}

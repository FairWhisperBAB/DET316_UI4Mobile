using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public GameObject pausebtn;

    public PausedScreenScript PM;

    private void Update()
    {
        if (PausedScreenScript.paused)
        {
            return;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PM.setPauseMenu(true);
        }
    }

    private void FixedUpdate()
    {
        if (PausedScreenScript.paused)
        {
            return;
        }
    }
}

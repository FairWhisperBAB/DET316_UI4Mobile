using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISafeAreaHandler : MonoBehaviour
{
    RectTransform panel;

    private void Start()
    {
        panel = GetComponent<RectTransform>();
    }

    private void Update()
    {
        Rect area = Screen.safeArea;

        Vector2 screenSize = new Vector2(Screen.width, Screen.height);

        if (Application.isEditor && Input.GetButton("Jump"))
        {
            if (Screen.height > Screen.width)
            {
                area = new Rect(0f, .038f, 1f, .913f);
            }
            else
            {
                area = new Rect(.049f, .051f, .902f, .949f);
            }

            panel.anchorMin = area.position / screenSize;
            panel.anchorMax = (area.position + area.size);

            return;
        }

        panel.anchorMin = area.position / screenSize;
        panel.anchorMax = (area.position + area.size) / screenSize;
    }
}

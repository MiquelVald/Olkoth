﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenPause : MonoBehaviour
{
    bool active;
    Canvas canvas;

    // Start is called before the first frame update
    void Start()
    {
        canvas = GetComponent<Canvas>();
        canvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            active = !active;
            canvas.enabled = active;
            Time.timeScale = (active) ? 0 : 1f;
        }
    }

    public void Exit()
    {
        Application.Quit();
    }
}

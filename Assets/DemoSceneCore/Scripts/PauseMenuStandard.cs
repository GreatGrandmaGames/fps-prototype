
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuStandard : MonoBehaviour
{
    private CursorLockMode wantedMode;

    public GameObject PersistentGameplayCanvas;
    public GameObject PauseMenuObject;


    public float defaultSensitivity = 2.0f;
    public int defaultInvertY = -1;

    private bool paused;

    void Start()
    {
        PlayerPrefs.SetFloat("CameraSensitivity", defaultSensitivity);
        PlayerPrefs.SetInt("InvertY", defaultInvertY);
        Cursor.lockState = wantedMode = CursorLockMode.Locked;
        SetCursorState();
        paused = false;
    }

    void Update()
    {
        // Release cursor on escape keypress
        if (Input.GetKeyDown(KeyCode.Tab) && !paused)
        {
            paused = true;
            Pause();
        }
        else if (Input.GetKeyDown(KeyCode.Tab) && paused)
        {
            paused = false;
            Resume();
        }
    }

    public void Pause()
    {
        Cursor.lockState = wantedMode = CursorLockMode.None;
        SetCursorState();
        PauseMenuObject.SetActive(true);
        PersistentGameplayCanvas.gameObject.SetActive(false);
        Time.timeScale = 0.0f;
    }

    public void Resume()
    {
        Cursor.lockState = wantedMode = CursorLockMode.Locked;
        SetCursorState();
        PauseMenuObject.SetActive(false);
        PersistentGameplayCanvas.SetActive(true);
        Time.timeScale = 1.0f;
    }

    // Apply requested cursor state
    void SetCursorState()
    {
        Cursor.lockState = wantedMode;
        // Hide cursor when locking
        Cursor.visible = (CursorLockMode.Locked == wantedMode);
    }
}

using UnityEngine;
using UnityEngine.InputSystem.XR.Haptics;

public class GameStateMenager : MonoBehaviour
{
    public enum GameState
    { 
        Paused,
        Running
    }
    public GameState CurrentState = GameState.Running;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetGameState(CurrentState);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Pause"))
        {
            if (CurrentState ==GameState.Paused)
            {
                SetGameState(GameState.Running);
            }
            else if (CurrentState ==GameState.Running)
            {
                SetGameState(GameState.Paused);
            }
        }
    }

    public void StartGame()
    {
        SetGameState(GameState.Running);
    }

    private void SetGameState(GameState newState)
    {
        if (newState == GameState.Paused)
        {
            Time.timeScale = 0.0f;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else if (newState == GameState.Running)
        { 
            Time.timeScale = 1.0f;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;

        }
        CurrentState = newState;
    }
}

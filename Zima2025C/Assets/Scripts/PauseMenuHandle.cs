using UnityEngine;

public class PauseMenuHandle : MonoBehaviour
{
    private GameStateMenager myGameStateMenagerRef;
    void Start()
    {
        var goGameMenagerRef = GameObject.FindGameObjectWithTag("GameController");
        myGameStateMenagerRef = goGameMenagerRef.GetComponent<GameStateMenager>();
    }

    public void OnResumeButton_Clicked()
    {
        myGameStateMenagerRef.StartGame();
    }

    public void OnExitButton_Clicked()
    {
        Application.Quit();
    }
}

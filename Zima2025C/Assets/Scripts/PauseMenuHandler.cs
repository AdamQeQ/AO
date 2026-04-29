using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenuHandler : MonoBehaviour
{
    private GameStateManager myGameStateManagerRef;

    public Slider MySlider;
    public TMP_Text MyText;
    public Animator Animator;
    void Start()
    {
        var goGameManagerRef = GameObject.FindGameObjectWithTag("GameController");
        myGameStateManagerRef = goGameManagerRef.GetComponent<GameStateManager>();
        myGameStateManagerRef.OnPauseGame += ShowPauseMenu;
        if (Animator == null)
            Animator = GetComponent<Animator>();
    }

    public void OnResumeButton_Clicked()
    {
        // myGameStateManagerRef.StartGame();
        Animator.SetBool("IsVisible", false);
    }

    public void ShowPauseMenu()
    {
        Animator.SetBool("IsVisible", true);
    }
    public void ResumeGame()
    {
        myGameStateManagerRef.StartGame();
    }
    public void OnExitButton_Clicked()
    {
        Application.Quit();

    }

    public void OnValue_Changed()
    {
        MyText.text = MySlider.value.ToString("F2");

    }

    public void OnBalueWithParameter_Changed(float value)
    {
        MyText.text = value.ToString("F2");
    }


}
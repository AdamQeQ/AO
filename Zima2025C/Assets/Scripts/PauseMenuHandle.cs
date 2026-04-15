using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenuHandle : MonoBehaviour
{
    private GameStateMenager myGameStateMenagerRef;

    public Slider Myslider;
    public TMP_Text MyText;
    public Animator Animator;

    void Start()
    {
        var goGameMenagerRef = GameObject.FindGameObjectWithTag("GameController");
        myGameStateMenagerRef = goGameMenagerRef.GetComponent<GameStateMenager>();

        if (Animator == null)
            Animator = GetComponent<Animator>();
    }

    public void OnResumeButton_Clicked()
    {
        //myGameStateMenagerRef.StartGame();
        Animator.SetBool("IsVisible", false);
    }

   

    public void OnExitButton_Clicked()
    {
        Application.Quit();
    }

    public void OnValue_Changed()
    {
        MyText.text = Myslider.value.ToString("F2"); 
    }

    public void OnValueWithParameter_Changed(float value)
    {
        MyText.text = value.ToString("F2");
    }
}

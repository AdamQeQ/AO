using UnityEngine;
using UnityEngine.UI;

public class TopBarHandler : MonoBehaviour
{
    public Image FillImage;
    public Gradient HpColorGradient;
    public Slider HpSlider;
    private PlayerController _playerController;

    void Start()
    {
        _playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        _playerController.OnHpChanged += UpdateHPBar;
        UpdateHPBar();
    }

    public void UpdateHPBar()
    {
        HpSlider.value = _playerController.hp / 100.0f;
        FillImage.color = HpColorGradient.Evaluate(_playerController.hp / 100.0f);
    }
}

using UnityEngine;
using UnityEngine.UI;

public class TurnOnButtons : MonoBehaviour
{
    [SerializeField]
    private Button _startGame;
    [SerializeField]
    private Button _easyButtonCar;
    [SerializeField]
    private Button _hardButtonCar;

    private void Start()
    {
        _easyButtonCar.gameObject.SetActive(false);
        _hardButtonCar.gameObject.SetActive(false);
    }

    public void StartGame()
    {
        _startGame.gameObject.SetActive(false);
        _easyButtonCar.gameObject.SetActive(true);
        _hardButtonCar.gameObject.SetActive(true);
    }
}

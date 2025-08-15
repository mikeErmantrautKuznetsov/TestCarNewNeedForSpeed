using Ashsvp;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class ChoiceTypeCar : MonoBehaviour
{
    [SerializeField]
    private Button[] _buttonStart;

    private Character _characterActive;
    private SimcadeVehicleController _simcadeVehicleController;

    [Inject]
    public void Construct(Character characterActive, SimcadeVehicleController simcadeVehicleController)
    {
        _characterActive = characterActive;
        _simcadeVehicleController = simcadeVehicleController;
    }

    public void ButtonActiveEasyCar()
    {
        _buttonStart[0].gameObject.SetActive(false);
        _buttonStart[1].gameObject.SetActive(false);
        _characterActive.gameObject.SetActive(true);
        _simcadeVehicleController.gameObject.SetActive(false);
        BoolStartButton.Instance = true;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void ButtonActiveHardCar()
    {
        _buttonStart[0].gameObject.SetActive(false);
        _buttonStart[1].gameObject.SetActive(false);
        _simcadeVehicleController.gameObject.SetActive(true);
        _characterActive.gameObject.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }
}

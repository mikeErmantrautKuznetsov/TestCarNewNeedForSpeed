using Ashsvp;
using UnityEngine;
using Zenject;

public class PlayerInstaller : MonoInstaller
{
    [SerializeField]
    private Transform _playerLocation;
    [SerializeField]
    private GameObject[] _playerPrefab;

    [SerializeField]
    private Character _character;
    [SerializeField]
    private SimcadeVehicleController _simcadeVehicleController;

    public override void InstallBindings()
    {
        CreateFirstController();
        CreateSecondController();
    }

    public void CreateFirstController()
    {
        Character character = Container.InstantiatePrefabForComponent<Character>(_playerPrefab[0], _playerLocation.position, Quaternion.identity, null);
        Container.Bind<Character>().FromInstance(character).AsSingle();
    }

    public void CreateSecondController()
    {
        SimcadeVehicleController simcadeVehicleController = Container.InstantiatePrefabForComponent<SimcadeVehicleController>(_playerPrefab[1], _playerLocation.position, Quaternion.identity, null);
        Container.Bind<SimcadeVehicleController>().FromInstance(simcadeVehicleController).AsSingle();
    }
}
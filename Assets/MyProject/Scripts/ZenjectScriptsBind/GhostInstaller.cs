using UnityEngine;
using Zenject;

public class GhostInstaller : MonoInstaller
{
    [SerializeField]
    private Transform _spawnGhost;
    [SerializeField]
    private GameObject _ghostPrefab;

    [SerializeField]
    private GhostController _ghostController;

    public override void InstallBindings()
    {
        GhostBind();
    }

    public void GhostBind()
    {
        GhostController controllerGhost = Container.InstantiatePrefabForComponent<GhostController>(_ghostPrefab, _spawnGhost.position, Quaternion.identity, null);
        Container.Bind<GhostController>().FromInstance(controllerGhost).AsSingle();
    }
}
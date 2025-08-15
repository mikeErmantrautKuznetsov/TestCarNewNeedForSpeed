using UnityEngine;
using Zenject;

public class StartBot : MonoBehaviour
{
    [SerializeField]
    private GhostController _botActive;
    [SerializeField]
    private FinishController _botFinished;

    [Inject]
    public void Construct(GhostController botActive)
    {
        _botActive = botActive;
    }

    private void OnTriggerExit(Collider other)
    {
        _botActive.gameObject.SetActive(true);
        _botFinished.ChangeCountFinish();
    }
}

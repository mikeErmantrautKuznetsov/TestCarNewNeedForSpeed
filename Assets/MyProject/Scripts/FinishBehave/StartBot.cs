using UnityEngine;
using Zenject;

public class StartBot : MonoBehaviour
{
    [SerializeField]
    private GhostController _botActive;

    [Inject]
    public void Construct(GhostController botActive)
    {
        _botActive = botActive;
    }

    private void OnTriggerExit(Collider other)
    {
        _botActive.gameObject.SetActive(true);
    }
}

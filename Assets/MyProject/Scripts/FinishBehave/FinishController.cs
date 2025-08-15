using TMPro;
using UnityEngine;

public class FinishController : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _scoreCheck;
    private int _scoreFinishLine;

    private void Start()
    {
        _scoreCheck.enabled = true;
        _scoreFinishLine = 0;
    }

    private void Update()
    {
        ShowNewResult();
    }

    public void ChangeCountFinish()
    {
        _scoreFinishLine++;
    }

    public void ShowNewResult()
    {
        _scoreCheck.text = _scoreFinishLine.ToString();
    }

    public void InfoScore(int score)
    {
        score = _scoreFinishLine;
    }
}

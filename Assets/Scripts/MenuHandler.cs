using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

[DefaultExecutionOrder(1000)]
public class MenuHandler : MonoBehaviour
{
    [SerializeField] private TMP_Text bestScore;
    [SerializeField] private TMP_InputField playersName;

    void SetBestScoreAndPlayersName()
    {
        bestScore.text = DataManager.Instance.GetBestScoreText();
        playersName.text = DataManager.Instance.CurrentPlayersName;
    }

    // Start is called before the first frame update
    void Start()
    {
        SetBestScoreAndPlayersName();
    }


    public void StartNew()
    {
        DataManager.Instance.CurrentPlayersName = playersName.text;
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
		Application.Quit(); // original code to quit Unity player
#endif
    }
}
using UnityEngine;
using Zork.Common;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private string ZorkGameFileAssetName = "Zork";

    [SerializeField]
    private UnityInputService InputService;

    [SerializeField]
    private UnityOutputService OutputService;

    [SerializeField]
    private TextMeshProUGUI LocationText;

    [SerializeField]
    private TextMeshProUGUI MovesText;

    [SerializeField]
    private TextMeshProUGUI ScoreText;

    void Awake()
    {
        TextAsset gameJsonAsset = Resources.Load<TextAsset>(ZorkGameFileAssetName);

        Game.StartGame(gameJsonAsset.text, InputService, OutputService);

        Game.Instance.Output.WriteLine(Game.Instance.Player.CurrentRoom);
        Game.Instance.Output.WriteLine(Game.Instance.Player.CurrentRoom.Description);

        
    }
    // Start is called before the first frame update
    void Start()
    {
        InputService.InputField.Select();
        InputService.InputField.ActivateInputField();
    }

    // Update is called once per frame
    void Update()
    {
        LocationText.text = Game.Instance.Player.CurrentRoom.ToString();
        MovesText.text = $"Moves: {Game.Instance.Player.MovesCount}";
        ScoreText.text = $"Score: {Game.Instance.Player.Score}";

        if(Game.Instance.IsRunning == false)
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
        }
    }
}

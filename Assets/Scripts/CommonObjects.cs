using TMPro;
using UnityEngine;

public class CommonObjects : MonoBehaviour
{
    #region Singleton
    private static CommonObjects _instance;
    public static CommonObjects Instance { get { return _instance; } }
    private void Awake()
    {
        _instance = this;
    }
    #endregion
    public RectTransform mainMenuUpObjectsParent;
    public RectTransform mainMenuBottomObjectsParent;
    public Transform GameCanvas;
    public Transform MainMenuCanvas;
    public Transform GameOverCanvas;
    public Transform PauseCanvas;
    public MapItem StartMapItem;
    public MapItem FirstMapItem;
    public TMP_Text CurrentCrystalCountText;
    public GameObject PauseButtonInGame;
    public TMP_Text CurrentScoreText_GameOver;
    public TMP_Text BestScoreText_GameOver;
}

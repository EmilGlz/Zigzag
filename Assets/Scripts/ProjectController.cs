using System;
using UnityEngine;

public class ProjectController
{
    private static ProjectController instance;
    public static ProjectController Instance { get => instance; set => instance = value; }
    public ProjectController()
    {
        instance = this;
        BestScore = PlayerPrefs.GetInt("BestScore");
    }
    private int _bestScore;
    private int _currentScore;
    private UIState _uiState;
    private bool _soundOn;
    public UserDatas UserDatas;
    public int BestScore
    {
        get => _bestScore;
        set
        {
            _bestScore = value;
            PlayerPrefs.SetInt("BestScore", _bestScore);
        }
    }
    public int CurrentCrystalCount
    {
        get => _currentScore;
        set
        {
            _currentScore = value;
            if (_currentScore > _bestScore)
                BestScore = _currentScore;
        }
    }
    public bool CanAddNewCrystal = true;
    public bool SoundOn
    {
        get => _soundOn;
        set
        {
            _soundOn = value;
            Camera.main.GetComponent<AudioListener>().enabled = value;
        }
    }
    public float ScreenHeight
    {
        get => Screen.height;
    }
    public float ScreenWidth
    {
        get => Screen.width;
    }
    public UIState UIState
    {
        get => _uiState; set
        {
            _uiState = value;
            UIStateChanged?.Invoke();
        }
    }
    public Action UIStateChanged;
}
public enum UIState
{
    Playing,
    Paused,
    MainMenu,
    GameOver
}
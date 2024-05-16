using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEditor.PackageManager;

public class Timer : MonoBehaviour
{
    private TMP_Text _timerText;
    enum TimerType {Countdown, Stopwatch}
    [SerializeField] private TimerType timerType;
    public bool done;
    [SerializeField] private float timeToDisplay;

    private bool _isRunning;

    public void Start()
    {
        done = false;
    }

    private void Awake()
    {
        _timerText = GetComponent<TMP_Text>();
    }

    private void OnEnable()
    {
        EventManager.TimerStart += EventManagerOnTimerStart;
        EventManager.TimerStop += EventManagerOnTimerStop;
        EventManager.TimerUpdate += EventManagerOnTimerUpdate;
    }

    private void OnDisable()
    {
        EventManager.TimerStart -= EventManagerOnTimerStart;
        EventManager.TimerStop -= EventManagerOnTimerStop;
        EventManager.TimerUpdate -= EventManagerOnTimerUpdate;
    }

    private void EventManagerOnTimerStart() => _isRunning = true;

    private void EventManagerOnTimerStop() => _isRunning = false;

    private void EventManagerOnTimerUpdate(float value) => timeToDisplay += value;
    
    void Update()
    {
        if (!_isRunning) return;
        if (timerType == TimerType.Countdown && timeToDisplay < 0.0f)
        {
            
            Debug.Log("End");
            EventManager.OnTimerStop();
            done = true;
            return;
        }
        else done = false;
        timeToDisplay += timerType == TimerType.Countdown ? -Time.deltaTime : Time.deltaTime;

        TimeSpan timeSpan = TimeSpan.FromSeconds(timeToDisplay);
        _timerText.text = timeSpan.ToString(@"mm\:ss\:ff");
    }
}

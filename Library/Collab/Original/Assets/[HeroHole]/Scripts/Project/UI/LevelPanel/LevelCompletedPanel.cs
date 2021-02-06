﻿public class LevelCompletedPanel : Panel
{
    void OnEnable()
    {
        if (Managers.Instance == null)
            return;

        HidePanel();
        EventManager.OnLevelFinish.AddListener(ShowPanel);
        EventManager.OnLevelStart.AddListener(HidePanel);
        EventManager.OnChangeLevel.AddListener(HidePanel);
    }

    void OnDisable()
    {
        if (Managers.Instance == null)
            return;

        EventManager.OnLevelFinish.RemoveListener(ShowPanel);
        EventManager.OnLevelStart.RemoveListener(HidePanel);
        EventManager.OnChangeLevel.AddListener(HidePanel);

    }
}

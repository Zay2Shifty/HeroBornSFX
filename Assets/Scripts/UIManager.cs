using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject gameWinMenu;
    
    private void OnEnable()
    {
        GameBehavior.OnPlayerWin += EnableGameWinMenu;
    }

    private void OnDisable()
    {
        GameBehavior.OnPlayerWin -= EnableGameWinMenu;
    }

    public void EnableGameWinMenu()
    {
        gameWinMenu.SetActive(true);
    }
}

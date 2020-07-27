using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GridSpace : MonoBehaviour
{
    public Button button;
    public TextMeshProUGUI buttonText;
    //public string playerSide;
    private GameController gameController;


    public void SetSpace()
    {
        if (gameController.playerMove == true)
        {
            buttonText.SetText(text: gameController.GetPlayerSide());
            button.interactable = false;
            gameController.EndTurn();
        }

    }

    public void SetGameControllerReference(GameController controller) => gameController = controller;
}

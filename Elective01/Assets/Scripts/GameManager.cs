using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject AchievementsPanel, CharacterPick, btn;
    public GameObject player_1, player_2, player_3, spawnPos;
    public Text keyPress;

    private void Awake(){
        Time.timeScale = 0;
    }

    public void OnClick()
    {
        AchievementsPanel.GetComponent<IPopUpable>().PopUp(AchievementsPanel);
    }

    public void OnClose()
    {
        AchievementsPanel.GetComponent<IPopUpable>().Close(AchievementsPanel);
    }

    public void OnPick(int _playernum)
    {
        Time.timeScale = 1;

        btn.GetComponent<IPopUpable>().PopUp(btn);

        CharacterPick.GetComponent<IPopUpable>().Close(CharacterPick);
        if(_playernum == 1){
            Instantiate(player_1, spawnPos.transform.position, Quaternion.identity);
        }
        if (_playernum == 2){
            Instantiate(player_2, spawnPos.transform.position, Quaternion.identity);
        }
        if (_playernum == 3){
            Instantiate(player_3, spawnPos.transform.position, Quaternion.identity);
        }
    }


    void Update()
    {
        if (Input.anyKeyDown)
        {
            keyPress.text = Input.inputString;
        }
    }
}

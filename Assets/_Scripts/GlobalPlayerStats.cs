using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalPlayerStats : MonoBehaviour {

    public static int playerLevel;
    public static int playerEXP;
    public static int playerStr;
    public static int playerDex;
    public static int playerCon;
    public static int playerInt;
    public static int playerWis;
    public static int playerChar;

    private int intPlayerLevel;
    private int intPlayerEXP;
    private int intPlayerStr;
    private int intPlayerDex;
    private int intPlayerCon;
    private int intPlayerInt;
    private int intPlayerWis;
    private int intPlayerChar;

    public GameObject displayPlayerLevel;
    public GameObject displayPlayerEXP;
    public GameObject displayPlayerStr;
    public GameObject displayPlayerDex;
    public GameObject displayPlayerCon;
    public GameObject displayPlayerInt;
    public GameObject displayPlayerWis;
    public GameObject displayPlayerChar;

	void Update () {
        intPlayerLevel = playerLevel;
        intPlayerEXP = playerEXP;
        intPlayerStr = playerStr;
        intPlayerDex = playerDex;
        intPlayerCon = playerCon;
        intPlayerInt = playerInt;
        intPlayerWis = playerWis;
        intPlayerChar = playerChar;

        displayPlayerLevel.GetComponent<Text>().text = "Level: " + intPlayerLevel;
        displayPlayerEXP.GetComponent<Text>().text = "Experience: " + intPlayerEXP;
        displayPlayerStr.GetComponent<Text>().text = "Strength: " + intPlayerStr;
        displayPlayerDex.GetComponent<Text>().text = "Dexterity: " + intPlayerDex;
        displayPlayerCon.GetComponent<Text>().text = "Constitution: " + intPlayerCon;
        displayPlayerInt.GetComponent<Text>().text = "Intelligence: " + intPlayerInt;
        displayPlayerWis.GetComponent<Text>().text = "Wisdom: " + intPlayerWis;
        displayPlayerChar.GetComponent<Text>().text = "Charisma: " + intPlayerChar;
    }
}

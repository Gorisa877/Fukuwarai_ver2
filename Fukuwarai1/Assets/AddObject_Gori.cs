using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AddObject_Gori : MonoBehaviour
{
    public static int gameData1 = 50;

    //　スタートボタンを押したら実行
    public void OnClickGameStart()
    {
        SceneManager.LoadScene("Main");
    }

    //ゲームオブジェクト
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}

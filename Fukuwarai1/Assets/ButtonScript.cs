using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI; //Input Field用に使う
using System.Windows.Forms; //OpenFileDialog用に使う
using UnityEngine.Networking;


public class ButtonScript : MonoBehaviour
{
    
    //オブジェクトと結びつける
    public InputField inputField;
    public Text text;
    //public PictureScript pictureScript;
    

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    /*いる
    public void OnClick()
    {
        Debug.Log("Button click!");
        OpenExistFile();
    }
    */


    /*
    public void OpenExistFile()
    {

        OpenFileDialog open_file_dialog = new OpenFileDialog();

        //InputFieldの初期値を代入しておく(こうするとダイアログがその場所から開く)
        open_file_dialog.FileName = inputField.text;

        //csvファイルを開くことを指定する
        open_file_dialog.Filter = "pdfファイル|*.pdf";

        //ファイルが実在しない場合は警告を出す(true)、警告を出さない(false)
        open_file_dialog.CheckFileExists = false;

        //ダイアログを開く
        open_file_dialog.ShowDialog();

        //取得したファイル名をInputFieldに代入する
        inputField.text = open_file_dialog.FileName;

    }
    */
    
    public void GetText()
    {
        //InputFieldのTextコンポーネントを取得
        Text inputText = GameObject.Find("InputField/Text").GetComponent<Text>();

        //Text型をstring型に変換
        string name = inputText.text;

        Debug.Log(name);

    }

}
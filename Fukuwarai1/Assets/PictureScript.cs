using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI; //Input Field用に使う
using System.Windows.Forms; //OpenFileDialog用に使う


public class PictureScript : MonoBehaviour
{

    //オブジェクトと結びつける
    public InputField input_field_path_;
    public Text text;

    // Use this for initialization
    void Start()
    {
        input_field_path_ = input_field_path_.GetComponent<InputField>();
        text = text.GetComponent<Text>();
    }


    public void InputPicture()
    {

        text.text = input_field_path_.text;

        GameObject image_object = GameObject.Find("Image");

        Image image_component = image_object.GetComponent<Image>();

        if (input_field_path_.text == "eye") 
        {

            Texture2D texture = Resources.Load("L") as Texture2D;

            image_component.sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), Vector2.zero);
        }

    }

}
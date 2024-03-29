using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static SEManager;

public class ActionSelectionUI : MonoBehaviour
{
    //取得した子要素のSelectableTextの数を出す
    SelectableText[] selectableTexts;

    //選択されている要素のインデックス
    int selectedIndex;//0:こうげき、1:まほう、2:ひっさつ

    //selectedIndexを取得できるように
    public int SelectedIndex { get => selectedIndex; }


    //自分に含まれている子要素を取得する関数
    public void Init()
    {
        //子要素のSelectableTextを取得
        selectableTexts = GetComponentsInChildren<SelectableText>();
    }


    //選択中のテキストの色を変更する関数
    public void ChangeTextColor()
    {
        //上入力で上のテキスト選択
        if(Input.GetKeyDown(KeyCode.UpArrow)) 
        {
            //選択SE再生
            SEManager.Instance.PlaySE(SESoundData.SE.Selection);
            selectedIndex--;
        }
        //下入力で下のテキスト選択
        else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            //選択SE再生
            SEManager.Instance.PlaySE(SESoundData.SE.Selection);
            selectedIndex++;
        }

        //indexがテキスト数を超えないように
        selectedIndex = Mathf.Clamp(selectedIndex, 0, selectableTexts.Length - 1);

        //選択されているテキストの色変更
        for(int i = 0; i < selectableTexts.Length; i++)
        {
            if (selectedIndex == i)
            {
                selectableTexts[i].SetSelectedColor(true);
            }
            else
            {
                selectableTexts[i].SetSelectedColor(false);
            }

        }
    }

    //UIを表示するための関数
    public void OpenSelectionUI()
    {
        //0に初期化
        selectedIndex = 0;
        //UIを表示
        gameObject.SetActive(true);

    }

    //UIを閉じるための関数
    public void CloseSelectionUI()
    {
        //0に初期化
        selectedIndex = 0;
        //UIを閉じる
        gameObject.SetActive(false);

    }
}
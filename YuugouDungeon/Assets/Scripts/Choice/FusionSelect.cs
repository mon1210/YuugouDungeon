using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FusionSelect : MonoBehaviour
{
    // 色変更用
    private Image image;

    // 合成可能かどうか　三体選ぶとtrue
    private bool isFusionAble;

    // 合成先を判別する
    private bool isFirstFusionChara;
    private bool isSecondFusionChara;
    private bool isThirdFusionChara;

    // キャラを何体選択しているか判別
    private int selectCount = 0;

    // キャラ選択を表すフラグ ------------------------------------
    private bool isNotSelect;   // 何もしていないときにfor文が回るので、falseで初期化
    private bool isFirstChara;
    private bool isSecondChara;
    private bool isThirdChara;
    private bool isFourthChara;
    private bool isFifthChara;
    private bool isSixthChara;
    public bool IsNotSelect { get => isNotSelect; }
    public bool IsFirstChara { get => isFirstChara; }
    public bool IsSecondChara { get => isSecondChara; }
    public bool IsThirdChara { get => isThirdChara; }
    public bool IsFourthChara { get => isFourthChara; }
    public bool IsFifthChara { get => isFifthChara; }
    public bool IsSixthChara { get => isSixthChara; }
    // キャラ選択を表すフラグ ------------------------------------

    void Start()
    {
        image = GetComponent<Image>();
    }

    void Update()
    {
        // キャラ選択
        charaSelectManager();
        // 融合先を判断
        fusionHandle();
    }

    // キャラ選択を管理
    private void charaSelectManager()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // マウスの位置にあるオブジェクトを取得
            Collider2D HitCollider = Physics2D.OverlapPoint(Input.mousePosition);

            // 特定のゲームオブジェクトがクリックされたかどうかの判定
            if (HitCollider != null)
            {
                // 01
                if (HitCollider.gameObject.CompareTag("Character1") && selectCount < 3 && !isFirstChara)
                {
                    isFirstChara = true;
                    selectCount++;
                }
                // 02
                if (HitCollider.gameObject.CompareTag("Character2") && selectCount < 3 && !isSecondChara)
                {
                    isSecondChara = true;
                    selectCount++;
                }
                // 03
                if (HitCollider.gameObject.CompareTag("Character3") && selectCount < 3 && !isThirdChara)
                {
                    isThirdChara = true;
                    selectCount++;
                }
                // 04
                if (HitCollider.gameObject.CompareTag("Character4") && selectCount < 3 && !isFourthChara)
                {
                    isFourthChara = true;
                    selectCount++;
                }
                // 05
                if (HitCollider.gameObject.CompareTag("Character5") && selectCount < 3 && !isFifthChara)
                {
                    isFifthChara = true;
                    selectCount++;
                }
                // 06
                if (HitCollider.gameObject.CompareTag("Character6") && selectCount < 3 && !isSixthChara)
                {
                    isSixthChara = true;
                    selectCount++;
                }
            }
        }
        else if (isSelectChara())
        {
            isNotSelect = false;

            // Escapeで選択解除
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                // フラグを折る
                isFirstChara = false;
                isSecondChara = false;
                isThirdChara = false;
                isFourthChara = false;
                isFifthChara = false;
                isSixthChara = false;

                isFirstFusionChara = false;
                isSecondFusionChara = false;
                isThirdFusionChara = false;

                isNotSelect = true;

                // カウントリセット
                selectCount = 0;
            }
        }

        // 三体選ぶと合成ボタンの色変化
        if (selectCount >= 3) 
        {
            image.color = Color.black; 
            // 合成可能に
            isFusionAble = true; 
        }
        else { image.color = Color.gray; }
    }

    // 融合先を判断する
    private void fusionHandle()
    {
        // ※どこかの条件を二体にしないと三体選んでも合成できない組み合わせができる

        // 一体目 or 四体目を選んだ　且つ　他に入ってない
        if (isFourthChara || isFirstChara && !isSecondFusionChara && !isThirdFusionChara)
        {
            isFirstFusionChara = true;
        }
        // 犬を選んだ　且つ　他に入ってない
        if (isFifthChara && !isFirstFusionChara && !isThirdFusionChara)
        {
            isSecondFusionChara = true;
        }
        // 魔法使いを選んだ　且つ　他に入ってない
        if (isThirdChara && !isFirstFusionChara && !isSecondFusionChara)
        {
            isThirdFusionChara = true;
        }
    }

    // if文省略用
    private bool isSelectChara()
    {
        // どれか一つでもtrueなら
        return isFirstChara || isSecondChara || isThirdChara || isFourthChara || isFifthChara || isSixthChara;
    }

    // ボタンクリック時、呼び出される
    public void OnCrick()
    {
        // 合成可能なら
        if (isFusionAble)
        {
            // 1キャラ目
            if (isFirstFusionChara)
            {
                SceneManager.LoadScene("FirstSynthesisScene");
            }
            // 2キャラ目
            if (isSecondFusionChara)
            {
                SceneManager.LoadScene("SecondSynthesisScene");
            }
            // 3キャラ目
            if (isThirdFusionChara)
            {
                SceneManager.LoadScene("ThirdSynthesisScene");
            }
        }
    }
}

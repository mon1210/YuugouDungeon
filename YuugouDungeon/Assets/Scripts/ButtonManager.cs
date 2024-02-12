using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// 各ボタンに効果を付与する
/// </summary>
public class ButtonManager : MonoBehaviour
{
    // ゲーム開始
    public void ToStart()
    {
        SceneManager.LoadScene("ChoiceScene");
    }


    // 攻撃キャラ -------------------------------------------------
    // BOSS描画へ
    public void result01()
    {
        SceneManager.LoadScene("A.Boss01");
    }
    // BOSS戦へ
    public void toA_Battle01()
    {
        SceneManager.LoadScene("A.First");
    }
    // 二戦目へ
    public void toA_Battle02()
    {
        SceneManager.LoadScene("A.Second");
    }
    // 三戦目へ
    public void toA_Battle03()
    {
        SceneManager.LoadScene("A.Third");
    }

    // バランスキャラ ---------------------------------------------　
    // BOSS描画へ
    public void result02()
    {
        SceneManager.LoadScene("B.Boss01");
    }
    // BOSS戦へ
    public void toB_Battle01()
    {
        SceneManager.LoadScene("B.First");
    }
    // 二戦目へ
    public void toB_Battle02()
    {
        SceneManager.LoadScene("B.Second");
    }
    // 三戦目へ
    public void toB_Battle03()
    {
        SceneManager.LoadScene("B.Third");
    }


    // 魔法キャラ -------------------------------------------------
    // BOSS描画へ
    public void result03()
    {
        SceneManager.LoadScene("M.Boss01");
    }
    // BOSS戦へ
    public void toM_Battle01()
    {
        SceneManager.LoadScene("M.First");
    }
    // 二戦目へ
    public void toM_Battle02()
    {
        SceneManager.LoadScene("M.Second");
    }
    // 三戦目へ
    public void toM_Battle03()
    {
        SceneManager.LoadScene("M.Third");
    }


    // ゲーム終了　タイトルへ
    public void ToTitle()
    {
        SceneManager.LoadScene("TitleScene");
    }
}

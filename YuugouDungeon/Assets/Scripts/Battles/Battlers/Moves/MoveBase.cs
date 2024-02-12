using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//わざの基礎データ
[CreateAssetMenu]
public class MoveBase : ScriptableObject
{
    //名前
    [SerializeField] new string name;
    //外部で取得できるように
    public string Name { get => name; }

    //種類
    public enum SkillType
    {
        Default = -1,
        Attack,
        Magic,
        Ultimate,
    }
    //Inspecterから設定できるように
    [SerializeField]private SkillType moveStatus;
    public SkillType MoveStatus { get => moveStatus; }

    //仮想関数宣言
    //ダイアログ表示関数
    public virtual string RunMoveResult(BattleUnit sourcerUnit, BattleUnit targetUnit)
    {
        return "";
    }
}

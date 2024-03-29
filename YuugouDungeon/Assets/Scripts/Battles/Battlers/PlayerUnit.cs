using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUnit : BattleUnit
{
    [SerializeField] Text nameText;
    [SerializeField] Text hpText;
    [SerializeField] Text mpText;

    //セットアップのオーバーライド
    public override void Setup(Battler battler)
    {
        base.Setup(battler);
        //playerのステータス設定
        nameText.text = battler.Base.Name;
        hpText.text=$"HP:{battler.HP}/{battler.MaxHp}";
        mpText.text=$"MP:{battler.MP}/{battler.MaxMp}";
    }

    //UIの更新
    public override void UpdateUI()
    {
        //HP,MPの更新
        hpText.text = $"HP:{Battler.HP}/{Battler.MaxHp}";
        mpText.text = $"MP:{Battler.MP}/{Battler.MaxMp}";
    }
}

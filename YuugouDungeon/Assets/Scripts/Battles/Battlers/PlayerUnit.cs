using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUnit : BattleUnit
{
    [SerializeField] Text nameText;
    [SerializeField] Text hpText;
    [SerializeField] Text mpText;

    //�Z�b�g�A�b�v�̃I�[�o�[���C�h
    public override void Setup(Battler battler)
    {
        base.Setup(battler);
        //player�̃X�e�[�^�X�ݒ�
        nameText.text = battler.Base.Name;
        hpText.text=$"HP:{battler.HP}/{battler.MaxHp}";
        mpText.text=$"MP:{battler.MP}/{battler.MaxMp}";
    }

    //UI�̍X�V
    public override void UpdateUI()
    {
        //HP,MP�̍X�V
        hpText.text = $"HP:{Battler.HP}/{Battler.MaxHp}";
        mpText.text = $"MP:{Battler.MP}/{Battler.MaxMp}";
    }
}
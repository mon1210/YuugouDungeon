using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FusionSelect : MonoBehaviour
{
    // �F�ύX�p
    private Image image;

    // �����\���ǂ����@�O�̑I�Ԃ�true
    private bool isFusionAble;

    // ������𔻕ʂ���
    private bool isFirstFusionChara;
    private bool isSecondFusionChara;
    private bool isThirdFusionChara;

    // �L���������̑I�����Ă��邩����
    private int selectCount = 0;

    // �L�����I����\���t���O ------------------------------------
    private bool isNotSelect;   // �������Ă��Ȃ��Ƃ���for�������̂ŁAfalse�ŏ�����
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
    // �L�����I����\���t���O ------------------------------------

    void Start()
    {
        image = GetComponent<Image>();
    }

    void Update()
    {
        // �L�����I��
        charaSelectManager();
        // �Z����𔻒f
        fusionHandle();
    }

    // �L�����I�����Ǘ�
    private void charaSelectManager()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // �}�E�X�̈ʒu�ɂ���I�u�W�F�N�g���擾
            Collider2D HitCollider = Physics2D.OverlapPoint(Input.mousePosition);

            // ����̃Q�[���I�u�W�F�N�g���N���b�N���ꂽ���ǂ����̔���
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

            // Escape�őI������
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                // �t���O��܂�
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

                // �J�E���g���Z�b�g
                selectCount = 0;
            }
        }

        // �O�̑I�Ԃƍ����{�^���̐F�ω�
        if (selectCount >= 3) 
        {
            image.color = Color.black; 
            // �����\��
            isFusionAble = true; 
        }
        else { image.color = Color.gray; }
    }

    // �Z����𔻒f����
    private void fusionHandle()
    {
        // ���ǂ����̏������̂ɂ��Ȃ��ƎO�̑I��ł������ł��Ȃ��g�ݍ��킹���ł���

        // ��̖� or �l�̖ڂ�I�񂾁@���@���ɓ����ĂȂ�
        if (isFourthChara || isFirstChara && !isSecondFusionChara && !isThirdFusionChara)
        {
            isFirstFusionChara = true;
        }
        // ����I�񂾁@���@���ɓ����ĂȂ�
        if (isFifthChara && !isFirstFusionChara && !isThirdFusionChara)
        {
            isSecondFusionChara = true;
        }
        // ���@�g����I�񂾁@���@���ɓ����ĂȂ�
        if (isThirdChara && !isFirstFusionChara && !isSecondFusionChara)
        {
            isThirdFusionChara = true;
        }
    }

    // if���ȗ��p
    private bool isSelectChara()
    {
        // �ǂꂩ��ł�true�Ȃ�
        return isFirstChara || isSecondChara || isThirdChara || isFourthChara || isFifthChara || isSixthChara;
    }

    // �{�^���N���b�N���A�Ăяo�����
    public void OnCrick()
    {
        // �����\�Ȃ�
        if (isFusionAble)
        {
            // 1�L������
            if (isFirstFusionChara)
            {
                SceneManager.LoadScene("FirstSynthesisScene");
            }
            // 2�L������
            if (isSecondFusionChara)
            {
                SceneManager.LoadScene("SecondSynthesisScene");
            }
            // 3�L������
            if (isThirdFusionChara)
            {
                SceneManager.LoadScene("ThirdSynthesisScene");
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// �e�{�^���Ɍ��ʂ�t�^����
/// </summary>
public class ButtonManager : MonoBehaviour
{
    // �Q�[���J�n
    public void ToStart()
    {
        SceneManager.LoadScene("ChoiceScene");
    }


    // �U���L���� -------------------------------------------------
    // BOSS�`���
    public void result01()
    {
        SceneManager.LoadScene("A.Boss01");
    }
    // BOSS���
    public void toA_Battle01()
    {
        SceneManager.LoadScene("A.First");
    }
    // ���ڂ�
    public void toA_Battle02()
    {
        SceneManager.LoadScene("A.Second");
    }
    // �O��ڂ�
    public void toA_Battle03()
    {
        SceneManager.LoadScene("A.Third");
    }

    // �o�����X�L���� ---------------------------------------------�@
    // BOSS�`���
    public void result02()
    {
        SceneManager.LoadScene("B.Boss01");
    }
    // BOSS���
    public void toB_Battle01()
    {
        SceneManager.LoadScene("B.First");
    }
    // ���ڂ�
    public void toB_Battle02()
    {
        SceneManager.LoadScene("B.Second");
    }
    // �O��ڂ�
    public void toB_Battle03()
    {
        SceneManager.LoadScene("B.Third");
    }


    // ���@�L���� -------------------------------------------------
    // BOSS�`���
    public void result03()
    {
        SceneManager.LoadScene("M.Boss01");
    }
    // BOSS���
    public void toM_Battle01()
    {
        SceneManager.LoadScene("M.First");
    }
    // ���ڂ�
    public void toM_Battle02()
    {
        SceneManager.LoadScene("M.Second");
    }
    // �O��ڂ�
    public void toM_Battle03()
    {
        SceneManager.LoadScene("M.Third");
    }


    // �Q�[���I���@�^�C�g����
    public void ToTitle()
    {
        SceneManager.LoadScene("TitleScene");
    }
}

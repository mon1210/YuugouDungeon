using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

/// <summary>
/// �摜�̌��̍���(�l�p)���N���[���Ƃ��Ĕz��ɂ��č쐬����
/// </summary>
public class BoxMaker : MonoBehaviour
{
    // ���W���X�g����
    [SerializeField] private Vector2[] posList;
    // Box��Prefab�擾
    [SerializeField] private GameObject boxPrefab;

    List<GameObject> boxList = new List<GameObject>();
    List<SpriteRenderer> renderers = new List<SpriteRenderer>();

    [SerializeField] private FusionSelect fusionSelect;

    void Start()
    {
        createBox();

        // �X�N���v�g�擾
        if (fusionSelect == null)   // ���ꂪ�Ȃ���NullReference�ɂȂ�
            fusionSelect = GetComponent<FusionSelect>();
    }

    void Update()
    {
        changeColor();
    }

    // box�쐬
    private void createBox()
    {
        for(int i = 0; i < posList.Length; i++)
        {
            // �����̎q�֌W��Box���� ���X�g�ɕۑ�
            boxList.Add(Instantiate(boxPrefab, posList[i], Quaternion.identity, this.transform));
            // Box����SpriteRenderer���擾
            renderers.Add(boxList[i].GetComponent<SpriteRenderer>());
        }
    }

    // �I�����A�F�ύX
    private void changeColor()
    {
        // �I�����A�F�ύX
        if (fusionSelect.IsFirstChara)
            renderers[0].color = Color.red;

        if (fusionSelect.IsSecondChara)
            renderers[1].color = Color.red;

        if (fusionSelect.IsThirdChara)
            renderers[2].color = Color.red;

        if (fusionSelect.IsFourthChara)
            renderers[3].color = Color.red;

        if (fusionSelect.IsFifthChara)
            renderers[4].color = Color.red;

        if (fusionSelect.IsSixthChara)
            renderers[5].color = Color.red;

        // �I������
        if(fusionSelect.IsNotSelect)
        {
            for (int i = 0; i < renderers.Count; i++)
            {
                renderers[i].color = Color.black;
            }
        }
    }
}

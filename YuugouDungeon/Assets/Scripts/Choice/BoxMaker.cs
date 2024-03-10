using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

/// <summary>
/// 画像の後ろの黒縁(四角)をクローンとして配列にして作成する
/// </summary>
public class BoxMaker : MonoBehaviour
{
    // 座標リスト生成
    [SerializeField] private Vector2[] posList;
    // BoxのPrefab取得
    [SerializeField] private GameObject boxPrefab;

    List<GameObject> boxList = new List<GameObject>();
    List<SpriteRenderer> renderers = new List<SpriteRenderer>();

    [SerializeField] private FusionSelect fusionSelect;

    void Start()
    {
        createBox();

        // スクリプト取得
        if (fusionSelect == null)   // これがないとNullReferenceになる
            fusionSelect = GetComponent<FusionSelect>();
    }

    void Update()
    {
        changeColor();
    }

    // box作成
    private void createBox()
    {
        for(int i = 0; i < posList.Length; i++)
        {
            // 自分の子関係にBox生成 リストに保存
            boxList.Add(Instantiate(boxPrefab, posList[i], Quaternion.identity, this.transform));
            // Box分のSpriteRendererを取得
            renderers.Add(boxList[i].GetComponent<SpriteRenderer>());
        }
    }

    // 選択時、色変更
    private void changeColor()
    {
        // 選択時、色変更
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

        // 選択解除
        if(fusionSelect.IsNotSelect)
        {
            for (int i = 0; i < renderers.Count; i++)
            {
                renderers[i].color = Color.black;
            }
        }
    }
}

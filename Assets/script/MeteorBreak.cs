using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MeteorBreak : MonoBehaviour
{
    public int wantclick = 15;
    public AudioSource audioSource; // インスペクターで設定する

    [SerializeField] GameObject Effect1;
    [SerializeField] GameObject Effect2;

    RaycastHit2D[] hits = new RaycastHit2D[1]; // 一度だけ作成する

    void Start()
    {
        audioSource = GetComponent<AudioSource>(); // コンポーネントを正しく取得する
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            // RaycastNonAlloc を使ってヒットした数を取得する
            int numHits = Physics2D.RaycastNonAlloc(ray.origin, ray.direction, hits);

            if (numHits > 0 && hits[0].collider != null)
            {
                GameObject hitObject = hits[0].collider.gameObject;

                if (hitObject.CompareTag("Meteor")) // tag の比較は CompareTag を使う方が効率的
                {
                    Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    mousePosition.z = 0;

                    audioSource.Play(); // 効果音を再生

                    if (wantclick <= 0)
                    {
                        GameObject effect = Instantiate(Effect2, mousePosition, Quaternion.identity);
                        Destroy(effect, 3);

                        Destroy(this.gameObject); // 自分自身を破棄する
                    }
                    else
                    {
                        GameObject effect1 = Instantiate(Effect1, mousePosition, Quaternion.identity);
                        Destroy(effect1, 2.5f);
                    }

                    wantclick--; // クリック回数を減らす
                }
            }
        }
    }
}

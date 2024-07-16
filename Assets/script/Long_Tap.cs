using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Long_Tap : MonoBehaviour
{
    [SerializeField] private float threshold = 2.0f; // ロングタップ成立までの時間
    [SerializeField] private UnityEvent onLongTap; // ロングタップ成立時の処理

    private float startTime;
    private bool isTapping;
    private bool isCoroutineRunning;

    public void PointEnter()
    {
        if (!isCoroutineRunning)
        {
            isTapping = true;
            startTime = Time.time;
        }
    }

    public void PointExit()
    {
        isTapping = false;
    }

    private void FixedUpdate()
    {
        if (isTapping && Time.time - startTime >= threshold && !isCoroutineRunning)
        {
            StartCoroutine(Tap());
        }
    }

    private IEnumerator Tap()
    {
        isCoroutineRunning = true;

        while (isTapping)
        {
            onLongTap?.Invoke();
            yield return new WaitForSeconds(0.1f);
        }

        isCoroutineRunning = false;
    }
}

using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Long_Tap : MonoBehaviour
{
    [SerializeField] private float threshold = 2.0f; // �����O�^�b�v�����܂ł̎���
    [SerializeField] private UnityEvent onLongTap; // �����O�^�b�v�������̏���

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

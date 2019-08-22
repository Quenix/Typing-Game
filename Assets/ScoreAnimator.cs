using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAnimator : MonoBehaviour
{
    private bool shaking = false;
    public static Vector3 OriginalPos;

    [SerializeField]
    private float shakeAmt;

    private void Start()
    {
        OriginalPos = transform.position;
    }

    private void Update()
    {
        if (shaking)
        {
            //Vector3 newPos = new Vector3 ((Time.deltaTime * shakeAmt), transform.position.y);

            Vector3 newPos = OriginalPos + Random.insideUnitSphere * (Time.deltaTime * shakeAmt);
            newPos.y = transform.position.y;
            newPos.z = transform.position.z;

            transform.position = newPos;
        }
    }

    public void ShakeMe()
    {
        StartCoroutine("ShakeNow");
    }

    IEnumerator ShakeNow()
    {
        Debug.Log(gameObject.name);
        Vector3 originalPos = transform.position;

        if (shaking == false)
        {
            shaking = true;
        }

        yield return new WaitForSeconds(0.25f);
        shaking = false;

        transform.position = originalPos;
    }
}

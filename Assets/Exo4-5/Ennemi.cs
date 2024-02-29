using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ennemi : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(GoRight());
    }

    private void Update()
    {
        transform.Translate(Vector3.up * 1 * Time.deltaTime);
    }

    IEnumerator GoRight()
    {
        Transform transformObject = transform;

        transformObject.rotation = Quaternion.FromToRotation(Vector3.up, Vector3.right);

        yield return new WaitForSeconds(3);

        StartCoroutine(GoLeft());
    }

    IEnumerator GoLeft()
    {
        Transform transformObject = transform;

        transformObject.rotation = Quaternion.FromToRotation(Vector3.up, Vector3.left);

        yield return new WaitForSeconds(3);

        StartCoroutine(GoRight());
    }
}

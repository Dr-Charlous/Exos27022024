using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarShip : MonoBehaviour
{
    public List<Transform> Ennemies;
    [SerializeField] GameObject _missilePrefab;

    private void Start()
    {
        StartCoroutine(LaunchMissiles());
    }

    IEnumerator LaunchMissiles()
    {
        var missile = Instantiate(_missilePrefab, transform.position, Quaternion.identity);
        missile.GetComponent<Missile>().Ennemies = Ennemies;
        missile.GetComponent<Missile>().Player = this;

        yield return new WaitForSeconds(5);
        StartCoroutine(LaunchMissiles());
    }
}

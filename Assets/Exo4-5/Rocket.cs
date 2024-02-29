using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    public Planet GoFrom;
    public Planet GoTo;
    [SerializeField] int _pilots;
    [SerializeField] bool _willExplode;

    private void Start()
    {
        _pilots = (int)(GoFrom.Population / 2);

        if (_pilots < 2)
            Destroy(gameObject);

        GoFrom.Population -= _pilots;

        int number = Random.Range(0, 10);

        if (number == 0)
            _willExplode = true;
    }

    private void Update()
    {
        transform.rotation = Quaternion.FromToRotation(Vector3.up, GoFrom.transform.position - GoTo.transform.position);
        transform.Translate(Vector3.down * 1 * Time.deltaTime);

        if (transform.position == GoTo.transform.position - GoFrom.transform.position)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Planet>() != null && other.GetComponent<Planet>() == GoTo)
        {
            GoTo.Population += _pilots;
            Destroy(gameObject);
        }
    }
}

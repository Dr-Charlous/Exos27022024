using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Missile : MonoBehaviour
{
    public List<Transform> Ennemies;
    public StarShip Player;
    [SerializeField] GameObject _ennemyPrefab;
    [SerializeField] int _number;

    private void Update()
    {
        Move();
    }

    void SearchNearestEnnemy()
    {
        float distance = 100000;
        int number = 0;

        for (int i = 0; i < Ennemies.Count; i++)
        {
            float distanceFromEnnemy = Vector3.Distance(Ennemies[i].position, transform.position);

            if (distanceFromEnnemy < distance)
            {
                distance = distanceFromEnnemy;
                number = i;
            }
        }

        _number = number;
    }

    void Move()
    {
        SearchNearestEnnemy();

        Transform transformObject = transform;
        Vector2 direction = Ennemies[_number].position - transformObject.position;

        transformObject.rotation = Quaternion.FromToRotation(Vector3.up, direction);
        transformObject.Translate(Vector3.up * 1 * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Ennemi>() != null)
        {
            Destroy(gameObject);

            GameObject obj = Instantiate(_ennemyPrefab, new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), 0), Quaternion.identity);

            Player.Ennemies.Add(obj.transform);

            Player.Ennemies.Remove(collision.transform);

            Destroy(collision.gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Planet : MonoBehaviour
{
    public GameObject TextUI;
    public int Population;

    [SerializeField] TextMeshProUGUI _populationText;
    [SerializeField] GameObject[] _otherPlanets;
    [SerializeField] GameObject _rocketPrefab;

    private void Start()
    {
        TextUI.SetActive(false);
    }

    private void Update()
    {
        Population += (int)(Random.Range(0, 1000) * Time.deltaTime);

        _populationText.text = Population.ToString();

        var number = Random.Range(0, 10000);

        if (number == 0)
        {
            LaunchRocket();
        }
    }

    private void OnMouseDown()
    {
        for (int i = 0; i < _otherPlanets.Length; i++)
        {
            _otherPlanets[i].GetComponent<Planet>().TextUI.SetActive(false);
        }

        TextUI.SetActive(!TextUI.activeSelf);
    }

    void LaunchRocket()
    {
        var rocket = Instantiate(_rocketPrefab, transform.position, Quaternion.identity);
        rocket.GetComponent<Rocket>().GoFrom = this;

        var number = Random.Range(0, _otherPlanets.Length);

        rocket.GetComponent<Rocket>().GoFrom = this;
        rocket.GetComponent<Rocket>().GoTo = _otherPlanets[number].GetComponent<Planet>();
    }
}

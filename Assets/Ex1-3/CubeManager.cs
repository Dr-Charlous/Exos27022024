using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour
{
    //Exo 1
    //#region Exo1
    //[SerializeField] GameObject _spherePrefab;
    //[SerializeField] List<GameObject> _sphereList;

    //private void OnMouseDown()
    //{
    //    var transformObj = gameObject.transform;

    //    for (int i = 0; i < 6; i++)
    //    {
    //        GameObject obj = Instantiate(_spherePrefab, transformObj.position + Vector3.up * 2, Quaternion.Euler(transform.position));
    //        _sphereList.Add(obj);
    //    }

    //    for (int i = 0; i < _sphereList.Count; i++)
    //    {
    //        _sphereList[i].GetComponent<Rigidbody>().AddForce(Vector3.up * 4, ForceMode.Impulse);
    //    }
    //}
    //#endregion Exo1

    //--------------------------------------------------------------------------------------------------------------------

    //Exo 2
    //#region Exo2
    //[SerializeField] GameObject _spherePrefab;
    //[SerializeField] List<GameObject> _sphereList;
    //[SerializeField] List<Color> _sphereColors;

    //private void OnMouseDown()
    //{
    //    var transformObj = gameObject.transform;

    //    GameObject obj = Instantiate(_spherePrefab, transformObj.position + Vector3.up * 2, Quaternion.Euler(transform.position));

    //    obj.GetComponent<MeshRenderer>().material.color = ChangeColor(obj.GetComponent<MeshRenderer>().material.color);

    //    _sphereList.Add(obj);

    //    for (int i = 0; i < _sphereList.Count; i++)
    //    {
    //        _sphereList[i].GetComponent<MeshRenderer>().material.color = ChangeColor(_sphereList[i].GetComponent<MeshRenderer>().material.color);
    //    }
    //}

    //Color ChangeColor(Color objColor)
    //{
    //    if (_sphereColors.Count <= 1)
    //        return objColor;

    //    var randomValue = Random.Range(0, _sphereColors.Count);

    //    if (objColor != _sphereColors[randomValue])
    //        return _sphereColors[randomValue];
    //    else
    //        return ChangeColor(objColor);
    //}
    //#endregion Exo2

    //--------------------------------------------------------------------------------------------------------------------

    //Exo 3
    //#region Exo3
    //[SerializeField] List<GameObject> _sphereList;

    //private void OnMouseDown()
    //{
    //    GameObject obj = null;
    //    float distanceMin = 1000000000000;

    //    Vector3 cubePosition = gameObject.transform.position;

    //    for (int i = 0; i < _sphereList.Count; i++)
    //    {
    //        if (distanceMin > Vector3.Distance(cubePosition, _sphereList[i].transform.position))
    //        {
    //            distanceMin = Vector3.Distance(cubePosition, _sphereList[i].transform.position);
    //            obj = _sphereList[i];
    //        }
    //    }

    //    if (obj != null)
    //        obj.GetComponent<Rigidbody>().AddForce(Vector3.up * 4, ForceMode.Impulse);
    //}
    //#endregion Exo3

    //--------------------------------------------------------------------------------------------------------------------

}

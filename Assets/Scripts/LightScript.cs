using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    private Light _light;
    private bool _isLight;
    private float _time;

    private void Awake()
    {
        _light = GetComponent<Light>();
        _isLight = true;
        _time = Random.Range(1, 3);
    }

    void Update()
    {
        if (_time <= 0)
        {
            LightUpdate();
            _time = Random.Range(1, 3);
        }
        else
            _time -= Time.deltaTime;
    }

    private void LightUpdate()
    {
        if (_isLight)
            _light.range = 30;
        else
            _light.range = 0;

        _isLight = !_isLight;
    }
}

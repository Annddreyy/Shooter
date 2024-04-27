using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerCharacter : MonoBehaviour
{
    private int _health;
    [SerializeField] private TMP_Text _healthText;

    private void Awake()
    {
        _health = 5;
        _healthText.text = $"HP: {_health}";
    }

    public void Hurt(int damage)
    {
        _health -= damage;
        _healthText.text = $"HP: {_health}";
        if (_health <= 0)
            SceneManager.LoadScene(0);
    }
}

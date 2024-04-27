using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    public float speed = 10.0f;
    public int damage = 1;

    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerCharacter character = other.GetComponent<PlayerCharacter>();
        if (character != null)
        {
            character.Hurt(1);
        }
        Destroy(gameObject);
    }
}

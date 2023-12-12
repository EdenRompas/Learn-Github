using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBurung : MonoBehaviour
{
    public int force;
    public Rigidbody2D _rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        OnClickLayar();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            OnClickLayar();
        }
    }

    public void OnClickLayar() {
        _rigidbody.AddForce(new Vector2(0, 1) * force, ForceMode2D.Impulse);
    }
}

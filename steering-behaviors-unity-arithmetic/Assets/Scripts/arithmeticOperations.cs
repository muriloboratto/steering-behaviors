using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arithmeticOperations: MonoBehaviour
{
    public Vector2 v1 = new Vector2(0, 0);
    public Vector2 v2 = new Vector2(1, 1);

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Evaluate("Add", v1 + v2, Add(v1, v2));
            Evaluate("Subtraction", v1 - v2, Subtraction(v1, v2));
            Evaluate("Multiplication", v1 * v2, Multiplication(v1, v2));
            Evaluate("Division", v1 / v2, Division(v1, v2));
        }
    }

    private void Evaluate(string opName, Vector2 expected, Vector2 calculated)
    {
            Debug.LogFormat("Operation {0} é {1}", opName, calculated);
        
    }

    Vector2 Add(Vector2 a, Vector2 b)
    {
        return new Vector2(a.x + b.x, a.y + b.y);
    }

    Vector2 Subtraction(Vector2 a, Vector2 b)
    {
        return new Vector2(b.x - a.x, b.y - a.y);
    }

    Vector2 Multiplication(Vector2 a, Vector2 b)
    {
        return new Vector2(a.x * b.x, a.y * b.y);
    }

    Vector2 Division(Vector2 a, Vector2 b)
    {
        return new Vector2(a.x / b.x, a.y / b.y);
    }


}

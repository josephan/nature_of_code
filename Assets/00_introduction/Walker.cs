using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walker : MonoBehaviour
{
    public int x = 0;
    public int y = 0;

    private HashSet<(int, int)> walkedPointCache = new HashSet<(int, int)>();

    void Update()
    {
        Walk();
    }

    void Display()
    {
        if (walkedPointCache.Contains((x, y)))
            return;

        var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.parent = transform;
        cube.transform.position = new Vector3(x, y, 0);
        walkedPointCache.Add((x, y));
    }

    void Walk()
    {
        int choice = Random.Range(0, 4);

        switch (choice)
        {
            case 0:
                x++;
                break;
            case 1:
                x--;
                break;
            case 2:
                y++;
                break;
            case 3:
                y--;
                break;
        }

        Display();
    }
}

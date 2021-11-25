using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
<<<<<<< HEAD
=======
    [SerializeField] private Transform bottomLeftSquareTransform;
    [SerializeField] private float squareSize;

   internal Vector3 CalculatePositionFromCoords(Vector2Int coords)
    {
        return bottomLeftSquareTransform.position + new Vector3(coords.x * squareSize, 0f, coords.y * squareSize);
>>>>>>> 691a2ae15040a47ac61b8b6c62bfd3643064e2f0
    }
}

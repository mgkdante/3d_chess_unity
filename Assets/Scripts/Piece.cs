using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(IObjectTweener))]
[RequireComponent(typeof(MaterialSetter))]
public class Piece : MonoBehaviour
{

    private MaterialSetter materialSetter;

    public Board board { protected get; set; }

    public Vector2Int occupiedSquare { get; set; }

    public TeamColor team { get; set; }
   
    public bool hasMoved { get; private set; }

    public List<Vector2Int> availableMoves;

    private IObjectTweener tweener;

    public abstract List<Vector2Int> SelectAvailableSquares();

    private void Awake()
    {
        availableMoves = new List<Vector2Int>();
        tweener = GetComponent<IObjectTweener>();
        materialSetter = GetComponent<materialSetter>();
        hasMoved = false;
    }

    private void SetMaterial(Material material)
    {
        materialSetter.SetSingleMaterial(material);
    }

    public bool IsFromSameTeam(Piece piece)
    {

    }

    public bool CanMoveTo(Vector2Int coords)
    {

    }
}

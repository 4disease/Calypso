using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameWorld : MonoBehaviour
{
    private List<Actor> _actors;
    private RelationshipManager _relationshipManager;

    public List<Actor> Actors { get { return _actors; } }
    public RelationshipManager RelationshipManager { get { return _relationshipManager; } }

    public GameWorld()
    {
        _actors = new List<Actor>();
        _relationshipManager = new RelationshipManager();
    }
}

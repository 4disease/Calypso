using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RelationshipManager : MonoBehaviour
{
    [SerializeField]
    private Dictionary<Actor, Dictionary<Actor, Relationship>> _relationships;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool RelationshipExists(Actor owner, Actor target)
    {
        return _relationships.ContainsKey(owner) && _relationships[owner].ContainsKey(target);
    }

    public Relationship GetRelationship(Actor owner, Actor target)
    {
        if (_relationships.ContainsKey(owner) && _relationships[owner].ContainsKey(target))
        {
            return _relationships[owner][target];
        }
        else
        {
            Relationship relationship = new Relationship(owner, target);

            if (_relationships.ContainsKey(owner) == false)
            {
                _relationships[owner] = new Dictionary<Actor, Relationship>();
            }

            _relationships[owner][target] = relationship;

            return relationship;
        }
    }
}

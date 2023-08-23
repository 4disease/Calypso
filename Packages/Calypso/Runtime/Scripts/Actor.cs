using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Actor : MonoBehaviour
{
    /// <summary>
    /// Text name for displaying to the player
    /// </summary>
    /// 
    [SerializeField]
    private string _name;

    /// <summary>
    /// A unique identifier for refering to this character in writing
    /// </summary>
    [SerializeField]
    private string _uid;

    public string Name
    {
        get { return _name; }
        set { this._name = value; }
    }

    public string UID
    {
        get { return _uid; }
    }


    public Actor(string name, string uid)
    {
        _name = name;
        _uid = uid;
    }

    public override string ToString()
    {
        return $"Actor({_name})";
    }
}

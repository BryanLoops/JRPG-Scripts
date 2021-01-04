using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Input the Structure item creation on Unity
[CreateAssetMenu(menuName = "Value/Structure")]
public class ValueStructure : ScriptableObject
{
    public List<Value> values;
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Part
{
	public EnumTypes.PartName Name;
	public GameObject PartPrefab;
}
public class BasePart : MonoBehaviour
{
	public virtual void OnGetPart(CarMoveSystem carMoveSystem) { }
}

public class PartManager : BaseManager
{
	public List<Part> Parts = new List<Part>();	
}

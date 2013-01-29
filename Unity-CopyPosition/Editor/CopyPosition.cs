using UnityEngine;
using UnityEditor;
using System.Collections;

public class CopyPosition : MonoBehaviour
{
	
	private static Vector3 copiedPosition;
	
	[MenuItem ("Edit/Transform/Copy Position %#c")]
	static void Copy ()
	{
		Transform t = Selection.activeTransform;
		copiedPosition = t.position;
        
		Debug.Log (" copy " + t.position);
	}

	[MenuItem ("Edit/Transform/Paste Position %#v")]
	static void Paste ()
	{
		foreach (Transform t in Selection.transforms) {	
			t.position = copiedPosition;
		}
		Debug.Log (" paste " + copiedPosition);
	}
	
	[MenuItem ("Edit/Transform/Same Position %#x")]
	static void Same ()
	{
		Transform act = Selection.activeTransform;
		foreach (Transform t in Selection.transforms) {	
			t.position = act.position;
		}
		Debug.Log (" move to " + act);
	}
}

using UnityEngine;
using System.Collections;

public class MultiplyValueModifier : ValueModifier 
{
	public readonly float toMultiply;

	public MultiplyValueModifier (int sortOrder, float toMultiply) : base (sortOrder)
	{
		this.toMultiply = toMultiply;
	}

	public override float Modify (float fromValue, float toValue)
	{
		return toValue * toMultiply;
	}
}
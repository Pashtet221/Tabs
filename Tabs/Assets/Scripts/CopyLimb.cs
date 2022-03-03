using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyLimb : MonoBehaviour
{
    [SerializeField] private Transform targetLimb;
	[SerializeField] private ConfigurableJoint m_ConfigurableJoint;
	
	Quaternion targetInitialRotation;
	
	private void Start()
	{
		this.m_ConfigurableJoint = this.GetComponent<ConfigurableJoint>();
		this.targetInitialRotation = this.targetLimb.transform.localRotation;
	}
	
	private void Update()
	{
		
	}
	
	private void FixedUpdate()
	{
		
	}
	
	private Quaternion copyRotation()
	{
		return Quaternion.Inverse(this.targetLimb.localRotation) * this.targetInitialRotation;
	}
}

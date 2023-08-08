using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class FeedbackLink : MonoBehaviour
{
	public void OpenFeedbackForm()
	{
#if !UNITY_EDITOR
		openWindow("https://docs.google.com/forms/d/e/1FAIpQLSdQ1nK0IL9haI21qKOZFoN-vxghhiQAyE2zQUC_aITZjhbP7w/viewform");
#endif
	}

	[DllImport("__Internal")]
	private static extern void openWindow(string url);
}

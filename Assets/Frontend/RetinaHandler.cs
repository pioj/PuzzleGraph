/*
 * Copyright (c) 2021 Rune Skovbo Johansen
 *
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 */

using UnityEngine;

public class RetinaHandler : MonoBehaviour {

	public static float width { get { return m_Width; } }
	public static float height { get { return m_Height; } }
	public static float scale { get { return m_Scale; } }

	static float m_Width;
	static float m_Height;
	static float m_Scale;

	public static void SetGUIMatrix () {
		GUI.matrix = Matrix4x4.TRS (
			Vector3.zero,
			Quaternion.identity,
			new Vector3 (m_Scale, m_Scale, 1f));
	}

    void Update () {
		// Note we can't use UnityEditorUtility.pixelsPerPoint as it
		// seems to not be consistent for different event types.
#if UNITY_EDITOR
		m_Scale = Screen.width > 1920 ? 2f : 1f;
#else
		m_Scale = Mathf.Round (Screen.currentResolution.width / Display.main.systemWidth);
#endif

		m_Width = Screen.width / scale;
		m_Height = Screen.height / scale;
	}
}

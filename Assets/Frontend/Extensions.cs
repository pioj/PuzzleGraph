/*
 * Copyright (c) 2021 Rune Skovbo Johansen
 *
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 */

using UnityEngine;
using System.Collections;

public static class Extensions {

	public static Rect FlipY (this Rect rect) {
		return new Rect (rect.x, RetinaHandler.height - rect.yMax, rect.width, rect.height);
	}

	public static Rect ToPixels (this Rect rect) {
		float s = RetinaHandler.scale;
		return new Rect (rect.x * s, rect.y * s, rect.width * s, rect.height * s);
	}

	public static Rect ToPoints (this Rect rect) {
		float s = 1f / RetinaHandler.scale;
		return new Rect (rect.x * s, rect.y * s, rect.width * s, rect.height * s);
	}
}

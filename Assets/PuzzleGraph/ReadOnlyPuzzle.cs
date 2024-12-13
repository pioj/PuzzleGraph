/*
 * Copyright (c) 2016 Rune Skovbo Johansen
 *
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 */

using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;
using System;

public class ReadOnlyPuzzle {
	public string name = string.Empty;

	public PuzzleNode[] nodes;
	public PuzzleEdge[] edges;
	public PuzzleElement[] staticElements;
	public PuzzleElement[] dynamicElements;
	public PuzzleItem[] items;

	public int stateMapCount;
	public PuzzleStateNode[] stateNodes;
	public PuzzleStateNode startNode;
	public bool exploredAll;
	public int longestPathSteps;
	public int goalPathSteps;
	public int goalStates;

	public ReadOnlyPuzzle (Puzzle puzzle) {
		nodes = puzzle.nodes.ToArray ();
		edges = puzzle.edges.ToArray ();
		staticElements = puzzle.staticElements.ToArray ();
		dynamicElements = puzzle.dynamicElements.ToArray ();
		items = puzzle.items.ToArray ();

		stateMapCount = puzzle.stateMap.Count;
		stateNodes = puzzle.stateNodes.ToArray ();
		startNode = puzzle.startNode;
		exploredAll = puzzle.exploredAll;
		longestPathSteps = puzzle.longestPathSteps;
		goalPathSteps = puzzle.goalPathSteps;
		goalStates = puzzle.goalStates;
	}
}

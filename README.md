# Gambrawl 2D
Unity game

- Gambrawl (Prototype v0.1.x)
- Unity: 6.3 LTS (URP optional) — 2D portrait maze-crawler

## What you get

Zero manual scene setup: on first Editor load, assets + a sandbox scene are auto-generated.
Press Play: the game spawns itself (camera, UI, maze, player).
Controls: Swipe (mouse drag / touch) OR keyboard (WASD / arrows).
3 layouts (hand-made) + 1 slot-roll mod per run.
Slide-to-wall movement + spikes + bumpers/springs + score + combo + best score.
Unity Editor Level Editor panel: paint, validate, save/load layouts, quick Play Mode testing.

## Notes

Packages: TextMeshPro required. Input System is optional:
If installed, it is used for keyboard/gamepad + swipe.
If not installed, keyboard + mouse swipe still work via legacy input.
All visuals are runtime-generated (primitives + generated sprites/particles). No external art.

## Level Editor

Menu: TappyTale/Gambrawl/Level Editor
Grid paint:
Left click/drag = paint
Right click/drag = erase
Maze view supports vertical + horizontal scrolling (painting remains accurate while scrolled).
Validation: Start/Exit, border walls, solvability (with/without spikes).
Save/Load TT_MazeLayout assets + Play Mode tools (Test / Push Live / Pull From Runtime).
Folders

_Assets/TappyTale/Gambrawl/Runtime : gameplay code
Assets/TappyTale/Gambrawl/Editor : auto-setup + editor tooling
Assets/TappyTale/Gambrawl/Documentation : extended README + changelog + GDD summary_

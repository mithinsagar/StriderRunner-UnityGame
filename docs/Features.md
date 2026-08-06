# Features

Author: Mithin Sagar S
GitHub: https://github.com/mithinsagar

A grouped, checkable list of what ships in the current release.

## Player Controller

- Ground and air movement with configurable speed.
- Sprite flip based on horizontal input.
- Single ground jump with tunable jump force.
- Extra air jump with independent tuning.
- Air dash with duration and cooldown parameters.
- Wall grab with per-side collision offset, slide speed cap.
- Wall jump with a two-component force vector.
- Sword strike attack for the sword character.

## Enemies

- Ground patrol enemy with waypoint movement.
- Ranged shooter enemy with projectile spawn.
- Shared damage contract that talks to the player life system.

## Environment

- Saw trap.
- Spike trap.
- Fire trap with cyclic damage window.
- Trampoline.
- Falling platform.
- Sticky platform.
- Fan.
- Pendulum.
- Rotating hazard.
- Death zone.
- Checkpoint and respawn system.
- Finish trigger for level completion.
- Item collector with tally.

## UI

- Start screen.
- Character selection screen.
- Settings menu with volume, input, and reset.
- Pause menu.
- Game over menu.
- Restart Journey confirmation.
- Insufficient Lives screen.
- Extra Lives grant screen.
- Quit confirmation.

## Systems

- Level manager that tracks unlock progress.
- Level loader that handles scene transitions.
- Audio manager, pooled and singleton, with random music selection.
- Camera follower with dead zone.
- Camera shake on impact.
- PlayerPrefs save layer.

## Input

- Unity Input System asset with keyboard and gamepad bindings.
- Runtime rebind support (backend). UI in progress.

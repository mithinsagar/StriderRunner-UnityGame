# Architecture

Author: Mithin Sagar S
GitHub: https://github.com/mithinsagar

This document describes the runtime architecture of Strider Runner, how the
code is organised, and how systems talk to each other. It is intended for
contributors and readers who want to reason about the codebase without opening
every scene.

## Layers

Strider Runner separates responsibilities into four layers:

1. Input layer. The Unity Input System asset in `Assets/Input/` declares
   actions. `PlayerMovement` and `PlayerSwordAttack` subscribe to the actions
   generated from that asset.
2. Simulation layer. MonoBehaviours in `Assets/Scripts/Player/`,
   `Assets/Scripts/Enemy/`, and `Assets/Scripts/Objects/` update physics,
   respond to collisions, and drive animator states.
3. Presentation layer. UI scripts in `Assets/Scripts/UI/` render menus, HUD,
   and menu transitions. Audio playback goes through `AudioManager`.
4. Persistence layer. Level unlocks, character selection, and player
   preferences are stored through PlayerPrefs via `LevelManager` and the
   settings menu.

## Scene Flow

```
Start Screen ---> Character Selection ---> Level 1 ---> ... ---> Level 7 ---> End Screen
```

Every level scene is independent. Progression is stored between scenes by
`LevelManager`, which persists the highest unlocked level to PlayerPrefs.
Pause and Game Over UIs are additive within each level scene and are toggled
by `PauseManager` and `GameOverMenu`.

## Player Controller

`PlayerMovement.cs` is the core controller. Its responsibilities:

- Read movement input from the generated input actions.
- Compute grounded state via a BoxCollider2D against a configurable
  `groundLayer`.
- Handle jump, extra (air) jump, and dash with cooldowns.
- Handle wall grab and wall jump when the character supports it.
- Set an integer animator parameter named `state` driven by an internal
  `MovementState` enum: idle, running, jumping, falling, doubleJumping,
  wallSliding.

Character-specific tuning is applied by `CharacterLoader` which reads a
`CharacterData` ScriptableObject and pushes values into `PlayerMovement`.

## Enemy System

Enemies expose a common `EnemyDamage` component that reacts to player contact
and applies damage through `PlayerLife`. Two archetypes are shipped:

- `EnemyMovement` drives a patrolling ground enemy between waypoints.
- `RangedEnemy` cycles a shoot timer and spawns `EnemyProjectile` instances
  along a configurable direction.

## Object and Trap System

`Assets/Scripts/Objects/` provides reusable environment behaviours. Traps and
platforms share the following patterns:

- `Trap` is a base type extended by `SawTrap`, `SpikeTrap`, `FireTrap`.
- `WaypointFollower` and `MovementDirection` drive moving platforms.
- `Rotate`, `RotationDirection`, and `Pendulum` drive rotating hazards.
- `Trampoline`, `FallingPlatform`, `StickyPlatform`, and `Fan` provide
  physics interactions with the player.
- `Checkpoint` and `CheckpointManager` set the respawn position on trigger.
- `DeathZone` sends the player to the last checkpoint.
- `Finish` triggers level completion and hands off to `LevelLoader`.
- `ItemCollector` tallies pickups.

## Audio

`AudioManager` is a singleton that lives across scenes. It maintains a pool of
`AudioSource` components and looks up `Sound` entries by `AudioType`. It also
handles random selection of background tracks and cross-fades on level change.

## Camera

`CameraFollower` smoothly follows the player with a configurable dead zone.
`CameraShaker` applies a short positional shake on impact events, called by
`PlayerLife` and by trap collisions.

## Save and Load

The game persists state through Unity `PlayerPrefs`:

- Highest unlocked level index.
- Selected character index.
- Extra lives balance.
- Audio and settings preferences.

There is no external file I/O.

## Dependencies

All non-Unity dependencies are declared in `Packages/manifest.json`. Notable
entries include the Input System, 2D Animation, 2D SpriteShape, Cinemachine,
and TextMesh Pro.

# Game Design

Author: Mithin Sagar S
GitHub: https://github.com/mithinsagar

## Concept

Strider Runner is a fast, precision 2D platformer. The player picks one of
several strider characters, each with a distinct movement profile, and pushes
through a themed campaign of increasingly demanding obstacle courses. The core
promise is expressive movement: a good player can chain dashes and wall jumps
to skip large sections of a level, while a new player can still complete every
stage with basic jumping.

## Pillars

1. Movement first. Traversal is the primary verb. Every mechanic exists to
   support movement expression.
2. Readable failure. Every death should be obviously caused by a decision the
   player made, not by hidden state.
3. Short loops. Levels are short and checkpointed frequently. Retrying is
   cheap.
4. Distinct characters. Each character teaches a different playstyle by
   restricting or amplifying part of the movement kit.

## Player Kit

- Move: horizontal ground and air movement.
- Jump: single ground jump.
- Extra jump: one air jump after leaving the ground.
- Dash: fixed-distance horizontal burst on a cooldown.
- Wall grab and slide: hold a wall to slow the fall.
- Wall jump: leap away from a grabbed wall.
- Sword strike: melee attack (sword-equipped character only).

## Characters

Character stats are defined by ScriptableObject assets in
`Assets/ScriptableObjects/`. Each character has its own tuning for move speed,
jump force, dash cooldown, and whether wall grab is allowed. A character
without wall grab has to rely on double jumps.

## Enemies

- Ground patroller. Walks between waypoints. Damages on contact.
- Ranged shooter. Stationary. Fires projectiles at a fixed cadence.

## Traps

- Saw. Rotates in place or along a path. Instant damage on touch.
- Spike. Stationary damage.
- Fire. Cyclic damage window driven by an animation.
- Falling platform. Drops after being stood on for a short duration.
- Trampoline. Launches the player upward.
- Sticky platform. Reduces horizontal input while standing on it.
- Fan. Pushes the player upward while inside its column.
- Pendulum. Swings across a path.
- Rotating hazard. Spins with configurable direction.
- Death zone. Instant respawn.

## Progression

The player starts with a fixed number of lives. Completing levels grants
extra lives. Running out of lives sends the player to the Insufficient Lives
menu, where they can either restart the journey or watch the Extra Lives
prompt.

## Audio

- Background music switches on scene load, chosen randomly from a per-scene
  playlist to keep replays fresh.
- SFX for jump, land, dash, dash recharge, hit, death, checkpoint, pickup,
  and menu clicks.

## Attributions

Sound and font assets are used under permissive licenses. Contributors adding
new assets must record the source and license in this section.

# Changelog

All notable changes to Strider Runner are documented in this file.

The format is based on Keep a Changelog and this project adheres to Semantic
Versioning.

Author: Mithin Sagar S
GitHub: https://github.com/mithinsagar

---

## [1.0.0] - 2026-08-06

Initial public release.

### Added
- Full 2D character controller: move, flip, jump, double jump, air dash,
  wall grab, wall slide, wall jump.
- Seven playable levels plus start and end screens.
- Character selection screen with per-character movement profiles.
- Ranged and melee enemy variants.
- Trap set: saws, spikes, fire, falling platforms, trampolines, sticky
  platforms, fans, pendulums, rotating hazards, death zones.
- Collectible items with per-level counter.
- Central AudioManager with pooled effects and randomised music.
- Checkpoint and respawn system.
- PlayerPrefs-based save system for lives, unlocks, and settings.
- Full UI suite: Start, Pause, Game Over, Quit, Extra Lives, Insufficient
  Lives, Character Select, Restart Journey.
- Camera follower and camera shake.
- Unity Input System asset with keyboard and gamepad bindings.

### Notes
- Wall climb and jump migration to the new input system completed.
- Repository restructured for public distribution.

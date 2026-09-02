# Controls

Author: Mithin Sagar S
GitHub: https://github.com/mithinsagar

Strider Runner uses the Unity Input System. Bindings are declared in
`Assets/Input/PlayerInputActions.inputactions`. The defaults below apply on
first launch; the Settings menu can be used to rebind actions at runtime.

## Keyboard and Mouse

| Action             | Binding                                                                        |
| ------------------ | ------------------------------------------------------------------------------- |
| Move                | A / D or Left / Right arrows                                                   |
| Jump                | Space                                                                           |
| Air jump            | Space (while airborne)                                                         |
| Dash                | Left Shift                                                                     |
| Wall grab & slide   | Automatic while airborne against a wall, for characters with wall grab enabled |
| Wall jump           | Space while wall grabbing                                                      |
| Sword strike        | K (sword characters only)                                                      |
| Pause               | P                                                                               |
| Confirm menu        | Enter or Space                                                                 |
| Cancel menu         | Escape                                                                         |

## Gamepad (Xbox layout)

| Action             | Binding                                                                        |
| ------------------ | ------------------------------------------------------------------------------- |
| Move                | Left Stick or D-Pad                                                            |
| Jump                | A (South button)                                                               |
| Air jump            | A (while airborne)                                                             |
| Dash                | B (East button)                                                                |
| Wall grab & slide   | Automatic while airborne against a wall, for characters with wall grab enabled |
| Wall jump           | A while wall grabbing                                                          |
| Sword strike        | Not yet mapped — currently keyboard-only                                      |
| Pause               | Start                                                                          |
| Confirm menu        | A                                                                              |
| Cancel menu         | B                                                                              |

## Notes

- Gamepad UI navigation is on the roadmap. On current builds, use the mouse
  to interact with menus when playing with a controller.
- Rebinding writes overrides into PlayerPrefs. Resetting via the Settings
  menu clears them.
- Wall grab and wall slide are not a held button: a character with wall grab
  enabled automatically clings to a wall whenever it is airborne and
  touching one (`PlayerMovement.isOnWall`/`WallSlide`). Wall jump then
  fires off the regular jump input while clinging.
- `PlayerInputActions.inputactions` also declares `SwordAttack` and
  `BowAttack` actions (bound to F and C on keyboard), but neither is
  currently read by a gameplay script. The sword attack instead polls the
  legacy `K` key directly in `PlayerSwordAttack.cs`. Treat those two
  bindings as reserved for a future input pass rather than working
  controls.

# Controls

Author: Mithin Sagar S
GitHub: https://github.com/mithinsagar

Strider Runner uses the Unity Input System. Bindings are declared in
`Assets/Input/PlayerInputActions.inputactions`. The defaults below apply on
first launch; the Settings menu can be used to rebind actions at runtime.

## Keyboard and Mouse

| Action        | Binding                       |
| ------------- | ----------------------------- |
| Move          | A / D or Left / Right arrows  |
| Jump          | Space                         |
| Air jump      | Space (while airborne)        |
| Dash          | Left Shift                    |
| Wall grab     | Hold Left Shift against wall  |
| Wall jump     | Space while wall grabbing     |
| Sword strike  | J (sword characters only)     |
| Pause         | Escape                        |
| Confirm menu  | Enter or Space                |
| Cancel menu   | Escape                        |

## Gamepad (Xbox layout)

| Action        | Binding                    |
| ------------- | -------------------------- |
| Move          | Left Stick                 |
| Jump          | A                          |
| Air jump      | A (while airborne)         |
| Dash          | Right Trigger              |
| Wall grab     | Hold Left Trigger          |
| Wall jump     | A while wall grabbing      |
| Sword strike  | X                          |
| Pause         | Start                      |
| Confirm menu  | A                          |
| Cancel menu   | B                          |

## Notes

- Gamepad UI navigation is on the roadmap. On current builds, use the mouse
  to interact with menus when playing with a controller.
- Rebinding writes overrides into PlayerPrefs. Resetting via the Settings
  menu clears them.

# Contributing to Strider Runner

Thank you for considering a contribution. This document explains how to file
issues, propose changes, and open pull requests against Strider Runner.

Author: Mithin Sagar S
GitHub: https://github.com/mithinsagar

---

## Ways to Contribute

- Report a bug through the issue tracker using the bug report template.
- Suggest a feature or a design idea using the feature request template.
- Improve documentation under `docs/` or the top-level `README.md`.
- Submit code changes through a pull request.

## Getting Set Up

1. Fork the repository on GitHub.
2. Clone your fork locally.
3. Open the project in Unity Hub with the editor version listed in
   `ProjectSettings/ProjectVersion.txt`.
4. Create a topic branch for your change:

   ```
   git checkout -b feature/short-description
   ```

## Coding Standards

- All new scripts must include the standard file header used across the
  project (name, author, GitHub, license).
- Use PascalCase for public members and types, camelCase for locals and
  private serialised fields.
- Group serialised fields under `[Header("...")]` for editor clarity.
- Prefer `SerializeField` over `public` for editor-exposed fields.
- Keep MonoBehaviour update loops small; extract logic into helper methods.
- New enemies and traps should implement the shared damage contract.
- Do not commit files under `Library/`, `Temp/`, `Build/`, `Logs/`, or
  `UserSettings/`. These are gitignored.

## Commit Messages

Use concise, imperative commit messages. Example:

```
Add wall climb cooldown to PlayerMovement
```

Reference issues where relevant, for example `Fixes #12`.

## Pull Request Checklist

Before you open a pull request:

- The project opens in Unity without console errors.
- Play mode succeeds on the Start Screen scene.
- Every scene under `Assets/Scenes/` still loads.
- New scripts include the file header.
- `docs/` is updated if behaviour has changed.

## Code of Conduct

By participating, you agree to abide by `CODE_OF_CONDUCT.md`.

## License of Contributions

By submitting a contribution you agree that it will be licensed under the MIT
License, matching the project.

# LEGACY — Tech Prototype (Phase 1)

**Goal:** Prove ball physics + player controller feel great. Vertical Slice foundation.

## What Was Built

### 1. Unity C# Scripts (`Assets/Scripts/Match/`)
| Script | Purpose |
|--------|---------|
| `PlayerController.cs` | WASD + gamepad movement, sprint, kick with cooldown, smooth acceleration |
| `BallPhysics.cs` | Drag, bounce, spin, kick impulse, goal detection, reset |
| `AIOpponent.cs` | Simple chase-and-shoot AI (Phase 2: roles + difficulty) |
| `GameManager.cs` | Score, 3-min timer, kickoff reset, win/draw |
| `CameraController.cs` | Broadcast-style follow camera |

### 2. Web Prototype (`prototype/index.html`)
Playable in browser — same physics/logic as Unity scripts. Test feel instantly without Unity install.

## How To Run (Web — Instant)
```bash
open prototype/index.html
# or
python3 -m http.server 8000
# → http://localhost:8000/prototype/
```

**Controls:** WASD/Arrows move • Shift sprint • Space kick • R reset ball

## How To Run (Unity 6 — Steam Version)
1. Install **Unity 6 LTS** from unity.com
2. Open this repo as a Unity project (`Assets/` is the project root)
3. Create scene `Assets/Scenes/Prototype.unity`:
   - Plane (pitch 68×105m scaled) + 2 goal boxes
   - Player capsule → add `PlayerController` + Rigidbody (kinematic)
   - CPU capsule → add `AIOpponent` + Rigidbody (kinematic)
   - Ball sphere → add `BallPhysics` + Rigidbody (dynamic)
   - Empty GameObject → add `GameManager`
   - Main Camera → add `CameraController`, offset (0, 18, -12)
4. Wire references in Inspector (ball, goals, UI TextMeshPro)
5. Press Play — move, sprint, kick, score!

## Physics Tuning (Game Feel)
| Parameter | Value | Notes |
|-----------|-------|-------|
| Ball drag | 0.6 | Rolling friction — tune for grass feel |
| Bounciness | 0.55 | Post/wall bounce |
| Kick force | 14 | Shot power |
| Kick range | 1.6m | Must be close to shoot |
| Player speed | 6 m/s | Sprint ×1.6 |

## Exit Criteria (Phase 1)
- [x] Ball rolls, bounces, spins realistically
- [x] Player moves smoothly, sprints, kicks on cooldown
- [x] Goals detected, score updates, kickoff resets
- [x] CPU chases and shoots
- [ ] 60fps on Steam Deck (test in Unity)
- [ ] Feels fun for 30 minutes (playtest)

## Next (Phase 2 Preview)
- Dribbling (close control), passing (through/lob), skill moves
- Tackling, stamina, injuries
- Full Player Career systems (attributes, trust, training)

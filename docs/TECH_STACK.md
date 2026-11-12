# LEGACY — Tech Stack & Steam Plan

## Engine Decision: Unity 6 LTS

### Why Unity?
- **Steam-native:** Best Steamworks integration, Workshop, cloud saves, Deck Verified path
- **C# speed:** Fast iteration for gameplay + career systems (small team friendly)
- **Sports ecosystem:** Asset Store stadiums, animations, crowd systems
- **Performance:** DOTS/ECS for 20k crowd, URP for scalable graphics
- **Console later:** PS5/Xbox export without rewriting

### Why Not Unreal?
Unreal 5 gives stunning visuals (Lumen/Nanite) but is heavier for a small team, slower iteration, C++/Blueprint split, and weaker sports templates. We can revisit for a sequel.

### Why Not Godot?
Godot 4 is excellent and free, but sports/motion-capture/Steam Workshop ecosystem is smaller. Unity gets us to Steam faster.

---

## Stack

| Layer | Choice |
|-------|--------|
| Engine | Unity 6 LTS, URP |
| Language | C# |
| Physics | Unity Physics + custom ball |
| Animation | Animation Rigging, Timeline, Mocap (Rokoko/iClone) |
| Crowd | DOTS/ECS, GPU Instancing |
| Save | JSON (local) + Steam Cloud |
| UI | UI Toolkit, TextMeshPro |
| Audio | FMOD (or Unity Audio) |
| Mods | Addressables + Steam Workshop |
| VCS | Git + Git LFS |

---

## Steam Plan

- **Price:** $39.99 premium, no MTX
- **Features:** Achievements (50+), Cloud Saves, Workshop, Controller, Deck Verified
- **No DRM beyond Steam.** No always-online.
- **DLC:** Content only (leagues, legends, stories) — never pay-to-win

---

## Project Structure (To Be Created in Phase 1)

```
Assets/
  Scripts/
    Match/       # Player controller, ball, AI, camera
    Career/      # Player, Manager, Club systems
    World/       # Leagues, fixtures, transfers, sim
    UI/          # Menus, career hub, HUD
    Audio/       # Commentary, SFX, music
    Data/        # Clubs, players, leagues (ScriptableObjects)
  Prefabs/
  Scenes/        # MainMenu, CareerHub, Match, Training
  Art/           # Models, textures, animations
  Audio/
Packages/
ProjectSettings/
```

---

## Performance Targets
- Min: 60fps @ 1080p Medium (GTX 1060)
- Rec: 60fps @ 1440p High (RTX 3060)
- Ultra: 60fps @ 4K (RTX 4070)
- Steam Deck: 60fps @ 720p–1080p (Medium)

## Save Format
- `Documents/LEGACY/Saves/slot_1.json` — full career state
- Versioned, backward-compatible, human-readable (for modders)
- Autosave every week + manual save

## Mod Support (Workshop)
- Kits, faces, stadiums, leagues, legends
- Addressables for hot-load without full rebuild
- Editor for renaming clubs/players (fictional → real-world if player wants)

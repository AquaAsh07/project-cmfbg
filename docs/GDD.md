# LEGACY — The Career Football Game
## Game Design Document v1.0
**Project Codename:** CMFBG (Career Mode Football Game)  
**Genre:** 3D Football / Career Simulation  
**Platform:** PC (Steam) → Console (PS5 / Xbox Series X|S) → Switch 2  
**Engine:** Unity 6 LTS  
**Business Model:** Premium single-player. No microtransactions. No live service.  
**Date:** 12 November 2026  
**Status:** Design Lock — Ready for Vertical Slice

---

> **Logline:** *No cards. No coins. No live service. Just your career.*
>
> LEGACY is a AAA-quality, offline-first football game where career mode is not a side mode — it *is* the game. Create a player, manage a club, or build a dynasty from the bottom up. Every attribute earned, every trophy won, every legend made — on the pitch, by you, forever saved locally.

---

## Table of Contents
1. [Vision & Pillars](#1-vision--pillars)
2. [Why This Game Exists](#2-why-this-game-exists)
3. [Target Audience & Platform](#3-target-audience--platform)
4. [Game Modes — All Careers, One World](#4-game-modes--all-careers-one-world)
5. [Core Loop](#5-core-loop)
6. [Match Gameplay (3D Playable)](#6-match-gameplay-3d-playable)
7. [Player Career — Deep Dive](#7-player-career--deep-dive)
8. [Manager Career — Deep Dive](#8-manager-career--deep-dive)
9. [Club Career: Road to Glory — Deep Dive](#9-club-career-road-to-glory--deep-dive)
10. [Season Structure & World](#10-season-structure--world)
11. [Progression, Economy & Ethics](#11-progression-economy--ethics)
12. [AI Systems](#12-ai-systems)
13. [Presentation, Art & Audio](#13-presentation-art--audio)
14. [UI/UX](#14-uiux)
15. [Tech Stack & Steam Plan](#15-tech-stack--steam-plan)
16. [Monetization & DLC Roadmap](#16-monetization--dlc-roadmap)
17. [Roadmap & Milestones](#17-roadmap--milestones)
18. [Scope, Risks & Mitigations](#18-scope-risks--mitigations)
19. [Success Metrics](#19-success-metrics)
20. [Appendix: Fictional World](#20-appendix-fictional-world)

---

## 1. Vision & Pillars

### 1.1 Vision Statement
To recapture the golden era of football games — when career mode was the heart of FIFA and Pro Evolution Soccer — and rebuild it as a modern, AAA-quality, single-player experience that respects the player's time, money, and intelligence.

We are not building another live-service. We are building the game you play for 10 seasons straight, offline, on a rainy evening, with your own save file that no server can ever take away.

### 1.2 Design Pillars

| # | Pillar | What It Means In Practice |
|---|--------|---------------------------|
| **1** | **Career First, Always Offline** | Every system serves the career. Full game playable offline. No login, no server dependency, no daily rewards. |
| **2** | **One Save, One Story** | Your career is persistent and personal. Player → Manager → Club dynasty can continue in the same world. Your legacy follows you. |
| **3** | **Playable Football, Not Just Menus** | You *play* matches in full 3D. Simulation is an option, never a requirement. Skill on the pitch matters. |
| **4** | **Earn Everything On The Pitch** | No pay-to-win. No loot boxes. No Ultimate Team cards. Ratings, transfers, and trophies are earned through performance. |
| **5** | **AAA Feel, Indie Heart** | AAA presentation (broadcast, commentary, crowd, animation) with indie scope discipline. Moddable, Steam-native, controller-first. |

### 1.3 Anti-Pillars (What We Will NEVER Do)
- ❌ No microtransactions, loot boxes, or card packs
- ❌ No battle pass, seasons, or FOMO timers
- ❌ No always-online requirement or DRM beyond Steam
- ❌ No pay-to-win boosts, XP multipliers, or attribute unlocks for sale
- ❌ No Ultimate Team / FUT clone as the main mode
- ❌ No ads, no tracking, no data selling

> If a feature requires a server, a store, or a timer to pressure the player, it does not ship.

### 1.4 The Promise
> "Buy it once. Own it forever. Your career lives on your PC, not on our servers."

---

## 2. Why This Game Exists

### 2.1 The Problem
Modern football games have shifted from career depth to live-service monetization:
- Career mode is neglected in favor of Ultimate Team / MyClub
- Progression is gated behind coins, points, and packs
- Offline modes feel like tutorials for online spending
- Saves are tied to accounts and can be lost
- Licensed content forces yearly reskins with minimal career innovation

Players who grew up with FIFA 07–14 and PES 2010–18 career modes have nowhere to go.

### 2.2 The Opportunity
- **Steam audience:** Millions of PC players want a premium, offline football game. Games like *Football Manager*, *eFootball (offline mods)*, and *Rocket League* prove demand.
- **Nostalgia + Modern Tech:** Unity 6 + modern animation/physics can deliver AAA-feel football without AAA licensing costs.
- **Underserved niche:** No major publisher currently offers a deep, offline, all-in-one career game (Player + Manager + Club) on Steam.
- **Mod community:** Steam Workshop support for kits, leagues, and faces creates longevity without live-service costs.

### 2.3 Our Answer
A single, unified career world where:
- You can be the **player**, the **manager**, or the **club builder** — or all three across one lifetime.
- Matches are **fully playable in 3D** with skill-based controls.
- Every system (transfers, training, morale, injuries, press, fans) is deep, transparent, and offline.
- The game ships as a **complete premium product** on Steam, with optional expansion DLCs (new leagues, eras, legends) — never pay-to-win.

---

## 3. Target Audience & Platform

### 3.1 Primary Audience
| Segment | Description | Size |
|---------|-------------|------|
| **Career Veterans (25–45)** | Grew up on FIFA/PES career mode, now on PC/Steam, want depth without MTX | Core |
| **Football Manager Players** | Love management depth, want playable matches | Secondary |
| **Casual Football Fans** | Want to "Be a Pro" without learning complex sim | Secondary |
| **Modders / Creators** | Want to build leagues, kits, legends | Community |

### 3.2 Platform Strategy
| Phase | Platform | Why |
|-------|----------|-----|
| **Launch** | **PC (Steam)** | Largest indie football audience, mod support, no cert costs, fastest iteration |
| **Post-Launch** | **PS5 / Xbox Series X\|S** | Console football audience, couch co-op, broadcast presentation shines |
| **Later** | **Switch 2** | Portable career mode, handheld seasons |

**Why Steam first?** Zero platform fees beyond Steam's 30%, Workshop integration, cloud saves, achievements, controller support, and direct community feedback. We can ship Early Access if needed, but target is full 1.0 launch.

### 3.3 System Requirements (Target)
- **Min:** GTX 1060 / RX 580, 8GB RAM, 60fps @ 1080p (Medium)
- **Recommended:** RTX 3060 / RX 6600, 16GB RAM, 60fps @ 1440p (High), 4K @ 60fps (Ultra)
- **Controller:** Xbox / PlayStation / Switch Pro — fully supported, remappable

---

## 4. Game Modes — All Careers, One World

LEGACY has **three career modes** that share **one persistent world**. Your choices carry over.

```
┌─────────────────────────────────────────────────────────┐
│                  LEGACY WORLD (Shared)                  │
│  Leagues • Cups • Transfers • Injuries • History • Fans │
└──────────┬──────────────┬──────────────┬────────────────┘
           │              │              │
    ┌──────▼──────┐ ┌─────▼─────┐ ┌─────▼──────┐
    │ PLAYER      │ │ MANAGER   │ │ CLUB       │
    │ CAREER      │ │ CAREER    │ │ CAREER     │
    │ "Be a Pro"  │ │ "The Boss"│ │ "Road to   │
    │             │ │           │ │  Glory"    │
    └──────┬──────┘ └─────┬─────┘ └─────┬──────┘
           │              │              │
           └──────► Retire / Switch ◄───┘
                    (Legacy continues)
```

### 4.1 Mode Overview

| Mode | You Are | Fantasy | Core Systems |
|------|---------|---------|--------------|
| **Player Career** | A footballer, age 16–18 → retire ~35–40 | "What if I became a legend?" | Attributes, trust, training, transfers, lifestyle, story |
| **Manager Career** | Head coach of a club | "Can I win the league with tactics?" | Tactics, transfers, morale, board, press, youth |
| **Club Career** | Owner + Manager of a club | "Can I build a dynasty from League Two to Champions League?" | Finances, stadium, academy, facilities, long-term planning |
| **Quick Match** | Any team | Jump in and play | Full 3D match, no career |
| **Training Ground** | Any player | Practice skills | Shooting, passing, dribbling drills |

### 4.2 The Unified World Rule
- All three careers exist in the **same save file** if you choose "Continue Legacy."
- Example: Play as Player "Arif Rahman" for 12 seasons → Retire → Become Manager of your old club → Build them into champions → Take over as Club Owner.
- Other clubs, players, and managers are AI-driven and evolve whether you watch or not.
- History is recorded: records, trophies, transfers, rivalries, Hall of Fame.

### 4.3 Save System
- **Local-first:** JSON saves in `Documents/LEGACY/Saves/`
- **Slots:** 5 career slots + autosave
- **Steam Cloud:** Optional sync, never required
- **No server:** Game fully playable offline, forever

---

## 5. Core Loop

### 5.1 Moment-to-Moment (Match Day)
```
Train / Prepare → Team Talk → Play Match (3D) → Post-Match (ratings, press, fans) → Recover
```

### 5.2 Week-to-Week (Career)
```
Check Fixtures → Manage Squad / Training → Play / Sim Match → Transfer / Contract → Rest / Lifestyle → Next Week
```

### 5.3 Season-to-Season (Legacy)
```
Pre-Season (transfers, objectives) → League + Cups → Continental → Awards → Off-Season (growth, retire, newgen) → Next Season
```

### 5.4 Lifetime Loop (Decades)
```
Youth → Breakthrough → Star → Legend / Journeyman → Retire → Manager → Dynasty → Hall of Fame
```

**Design Rule:** Every loop must be completable in 15–90 minutes. A full season = ~3–5 hours. A full career (16→38) = 40–60 hours. Respect the player's time.

---

## 6. Match Gameplay (3D Playable)

### 6.1 Philosophy
- **Skill-based, not stat-based:** A 70-rated player with good timing beats an 85-rated player with bad input. Attributes influence, never override, player skill.
- **Accessible, deep:** One-button pass/shoot for beginners, advanced skill moves and timed finishing for veterans.
- **Controller-first:** Designed for gamepad, fully playable on keyboard/mouse.

### 6.2 Controls (Default — Xbox Layout)
| Action | Button | Advanced |
|--------|--------|----------|
| Move | Left Stick | — |
| Sprint | RT (hold) | — |
| Pass (short) | A / X | Through: LB+A, Lob: RB+A |
| Shoot | X / Square | Power: hold, Finesse: RB+X, Chip: LB+X |
| Switch Player | LB / RB | Manual: Right Stick |
| Tackle / Pressure | B / Circle | Standing: B, Sliding: B (hold) |
| Skill Move | Right Stick flick | Rainbow, Elastico, etc. (contextual) |
| Call for Ball | Y / Triangle | — |
| Pause / Tactics | Start / Options | In-match tactics menu |

All controls remappable. Keyboard: WASD + arrows + modifiers.

### 6.3 Camera Options
- **Broadcast (Default):** Side view, dynamic zoom — TV feel
- **Tele Broadcast:** Higher, wider
- **End-to-End:** Behind goal, FIFA-style
- **Pro / Player Cam:** Follow your player (Player Career)
- **Free / Tactical:** High tactical view (Manager Career live)

### 6.4 Match Systems
| System | Design |
|--------|--------|
| **Passing** | Contextual, assisted but skill-driven. First-touch matters. Through balls weighted by vision attribute. |
| **Shooting** | Timed finishing (green = perfect). Shot placement by stick direction. Goalkeeper AI reads body shape. |
| **Dribbling** | Close control vs. pace. Skill moves have risk/reward. Stamina affects late-game control. |
| **Defending** | Jockey, contain, press. No auto-tackle spam. Positioning > button mashing. |
| **Set Pieces** | Corners, free kicks, penalties — fully playable, not auto-sim. |
| **Fouls & Cards** | Referee AI with personality (strict/lenient). VAR for major incidents (toggleable). |
| **Substitutions** | Up to 5 subs, 3 windows (league rules). Tactical shifts mid-match. |
| **Weather & Pitch** | Rain, snow, wind affect ball physics and grip. Pitch wear over season. |

### 6.5 Difficulty
| Level | AI Behavior |
|-------|-------------|
| **Amateur** | Slow reactions, poor positioning — learn the game |
| **Pro** | Balanced, punishes mistakes |
| **World Class** | Fast, clinical, exploits your patterns |
| **Legendary** | Near-perfect, requires mastery |
| **Custom** | Sliders for every attribute (speed, pass, shot, AI aggression) |

Difficulty affects AI decision speed and error rate, **not** player stat nerfs. No rubber-banding.

### 6.6 Match Length
- Halves: 4 / 6 / 10 / 15 min (default 6 min halves = ~25 min match)
- Full match option for purists
- Sim option: instant result from attributes + tactics (for Manager/Club careers)

---

## 7. Player Career — Deep Dive

> *"Be a Pro" — the mode that made a generation. Rebuilt with depth.*

### 7.1 Player Creation
- **Identity:** Name, nationality, age (16–18), position (GK, DEF, MID, FWD), preferred foot, height/weight, appearance (face, hair, boots, celebration)
- **Archetype:** Pace Merchant, Playmaker, Poacher, Engine, Wall, Shot-Stopper, etc. (starting attribute bias)
- **Potential:** Hidden star rating (1–5 stars) — determines growth ceiling. Not shown directly; discovered through training.
- **Personality:** Driven, Professional, Selfish, Team Player, Rebel — affects morale, training, press.

### 7.2 Attributes (0–99, displayed as Overall + Key Stats)
| Category | Attributes |
|----------|------------|
| **Technical** | Finishing, Dribbling, Passing, Crossing, Ball Control, Volleys, Penalties |
| **Physical** | Pace, Acceleration, Strength, Stamina, Jumping, Balance, Aggression |
| **Mental** | Vision, Positioning, Composure, Reactions, Work Rate, Decisions |
| **Goalkeeping** | Reflexes, Handling, Positioning, Kicking, 1v1, Command |

**Overall (OVR)** = weighted average by position. Shown, but never the whole story.

### 7.3 Progression
- **Growth:** Training + match performance + age curve. Peak at 27–29, decline after 32.
- **Training:** Weekly sessions (Shooting, Passing, Fitness, Tactics). Choose 2 per week. Risk of injury if overtrained.
- **Match Ratings:** 6.0–10.0 per match. Affects trust, growth, transfer value.
- **Skill Points:** Earn XP from matches/training. Spend on attribute boosts. No microtransactions.
- **Injuries:** Hamstring, ankle, knee, etc. Recovery time, physio, risk of recurrence if rushed back.

### 7.4 Manager Trust System
- **Trust (0–100):** Starts at 30 (bench). Earn via training, match ratings, professionalism.
- **Roles:** Prospect → Bench → Rotation → Starter → Key Player → Star Player → Captain
- **Consequences:** Trust determines starting XI, set pieces, penalty duty, contract offers, transfer requests.
- **Manager Personality:** Some managers favor youth, others veterans. Adapt or request transfer.

### 7.5 Contracts & Transfers (Player View)
- **Contract:** Length, wage, release clause. Negotiate or request transfer.
- **Transfer Requests:** If unhappy (low trust, low wage, no playing time), request move. Clubs negotiate.
- **Loans:** Early career loans to lower leagues for playing time.
- **Free Agency:** At contract end, choose new club. Offers based on OVR, age, form.

### 7.6 Lifestyle & Off-Pitch
- **Energy / Morale:** Affected by training load, match minutes, lifestyle choices.
- **Lifestyle:** Balanced, Focused, Social, Night Owl — affects recovery, press, injury risk.
- **Press & Fans:** Interviews, social media (fictional), fan sentiment. Choices have consequences.
- **Relationships:** Teammates, manager, rival player. Chemistry affects team performance.

### 7.7 Story & Events
- **Key Moments:** Debut, first goal, derby, cup final, title race, injury comeback, transfer saga.
- **Rivalries:** Generated rival player (same position, same age) — head-to-head stats tracked.
- **Mentors:** Veteran teammate who boosts growth if you train with them.
- **Legacy Goals:** Win league, win continental cup, win Ballon d'Or (fictional "Golden Ball"), become club legend.

### 7.8 Retirement & Legacy
- Retire at 35–40 (or earlier after injuries). Career summary: clubs, apps, goals, trophies, awards.
- **Hall of Fame:** Top players in world history. Your rank determined by trophies, OVR peak, longevity.
- **Continue as Manager:** Transition to Manager Career with your reputation as a bonus.

---

## 8. Manager Career — Deep Dive

> *"The Boss" — tactics, transfers, and trophies.*

### 8.1 Manager Creation
- Name, nationality, experience (Rookie → World-Class), preferred style (Possession, Counter, Pressing, Long Ball), appearance.

### 8.2 Tactics
- **Formation:** 4-3-3, 4-4-2, 3-5-2, 5-3-2, custom. Drag-and-drop XI.
- **Instructions:** Tempo, width, build-up, chance creation, defensive line, pressing intensity, mentality (Defensive → Attacking).
- **Player Roles:** Poacher, Target Man, False 9, Box-to-Box, Regista, Sweeper Keeper, etc. Roles affect AI movement.
- **In-Match:** Live tactical shifts, subs, team talks (calm/aggressive/inspirational).

### 8.3 Squad Management
- **Morale:** Playing time, wage, team form, manager relationship.
- **Fitness:** Training load, rotation, injury risk.
- **Youth Academy:** Intake each season (ages 15–18). Scout, promote, loan out.
- **Contracts:** Renew, sell, release. Wage budget vs. transfer budget.

### 8.4 Transfers (Manager View)
- **Budget:** Transfer budget + wage budget. Board sets expectations (e.g., "Finish top 4, sell for profit").
- **Scouting:** Scout reports (accuracy by scout quality). Watch list, shortlist, negotiate.
- **Negotiation:** Fee, add-ons, sell-on, loan, release clause. AI clubs negotiate realistically.
- **Transfer Window:** Summer + January. Deadline day drama, last-minute deals.

### 8.5 Board, Press & Fans
- **Board Confidence (0–100):** Affected by results, finances, style. Low confidence = sacked.
- **Press:** Pre/post-match interviews. Tone affects fans and board.
- **Fan Sentiment:** Results + style + transfers. Affects atmosphere and board pressure.
- **Objectives:** Seasonal goals (win league, reach cup semi, develop youth, sell players).

### 8.6 Match Options
- **Play as Manager:** Watch from touchline, make live subs/tactics (Manager Cam).
- **Play as Player:** Jump into match as a player (hybrid).
- **Sim Match:** Instant result. Use for cup ties or when you want to focus on management.
- **Interactive Sim:** Key moments only (penalties, big chances) — quick but involved.

---

## 9. Club Career: Road to Glory — Deep Dive

> *"Build a dynasty." — Owner + Manager combined.*

### 9.1 Fantasy
Start with a small club in the lowest league. Build facilities, grow finances, develop academy, and climb to continental glory over 10–20 seasons.

### 9.2 Club Systems
| System | Description |
|--------|-------------|
| **Finances** | Ticket sales, TV money, sponsorships, transfers, wages. Balance sheet, profit/loss. |
| **Stadium** | Capacity, facilities, upgrades (expand, hospitality, training ground). |
| **Academy** | Youth facilities level → better newgens. |
| **Training Ground** | Gym, physio, tactics room — affects growth and injuries. |
| **Reputation** | Club prestige affects transfer ability, sponsorships, fan growth. |
| **Sponsorships** | Kit sponsor, stadium naming, sleeve deals. Negotiate based on reputation. |

### 9.3 Long-Term Planning
- **5-Year Plan:** Board sets long-term goals (e.g., "Reach top flight in 5 seasons").
- **Youth vs. Experience:** Build with academy or buy stars? Both viable.
- **Sell & Rebuild:** Sell stars for profit, rebuild with youth — dynasty cycles.

### 9.4 Club Career = Manager Career + Ownership
- All Manager systems apply, plus finances and facilities.
- You set budgets, approve transfers, hire staff (scouts, coaches, physios).
- Staff quality affects scouting accuracy, training, injury recovery.

---

## 10. Season Structure & World

### 10.1 Fictional World (No Licensing Needed)
To avoid licensing costs and legal issues, LEGACY uses a **fictional but familiar** world:
- **Leagues:** 6 tiers across 8 fictional nations (inspired by real football cultures)
- **Clubs:** 120+ fictional clubs with unique kits, stadiums, rivalries, histories
- **Players:** 3,000+ fictional players with generated names, faces, attributes
- **Competitions:** League, Domestic Cup, Continental Cup (Champions League equivalent), Super Cup

> **Why fictional?** Real licenses cost millions per year. Fictional world = 100% ownership, moddable, no yearly reskin. Players can rename clubs/players via editor or Workshop mods.

### 10.2 Season Calendar
| Month | Activity |
|-------|----------|
| **June** | Pre-season: transfers, friendlies, objectives |
| **July–August** | Transfer window opens, season starts |
| **Sep–Nov** | League + Cups + Continental group stage |
| **Dec** | Winter break, mid-season review |
| **Jan** | January transfer window |
| **Feb–May** | Knockouts, title race, relegation battle |
| **May** | Finals, awards, season review |
| **June** | Off-season: growth, retirements, newgens, transfers |

### 10.3 Fixtures & Tables
- Full league tables, form guide (W/D/L last 5), top scorers, assists, clean sheets.
- Cup draws, knockout brackets, continental group + knockout.
- Relegation / promotion between tiers.
- Rivalry matches highlighted (derbies).

### 10.4 World Simulation
- AI clubs play matches, make transfers, sack managers, sign newgens — even when you're not watching.
- Player attributes evolve, values change, injuries happen.
- News feed: transfers, injuries, sackings, records, rumors.

---

## 11. Progression, Economy & Ethics

### 11.1 Progression Philosophy
- **Transparent:** Show exactly why attributes grow/decline. No hidden paywalls.
- **Earned:** Every boost comes from training, matches, or smart management.
- **Balanced:** No single path dominates. Youth, experience, and transfers all viable.

### 11.2 In-Game Economy (No Real Money)
| Currency | Earned By | Spent On |
|----------|-----------|----------|
| **Transfer Budget** | Board, sales, TV money | Player fees |
| **Wage Budget** | Board, sponsorships | Player wages, staff |
| **Skill Points (Player)** | Matches, training | Attribute boosts |
| **Club Funds (Club Career)** | Ticket sales, sponsors | Stadium, facilities |

No premium currency. No coins. No packs.

### 11.3 Ethics Charter
1. **No dark patterns:** No countdown timers, no "only 2 left!", no fake scarcity.
2. **No pay-to-win:** DLC never sells attributes, budgets, or advantages.
3. **Offline forever:** Game works without internet. No server shutdown can kill your save.
4. **Transparent odds:** If we ever add cosmetics (we won't at launch), odds and prices are public.
5. **Player-first:** If a feature harms the career experience to sell something, we cut it.

---

## 12. AI Systems

### 12.1 Match AI
| AI | Behavior |
|----|----------|
| **Player AI** | Positioning by role, off-ball runs, pressing triggers, decision-making by attributes + difficulty |
| **Goalkeeper AI** | Shot-stopping by reflexes, positioning, 1v1, distribution |
| **Manager AI (Opposition)** | Tactics by club style, subs by fitness/score, adapts to your patterns |
| **Referee AI** | Strictness personality, advantage play, VAR |

### 12.2 Career AI
| AI | Behavior |
|----|----------|
| **Transfer AI** | Clubs value players by OVR, age, form, contract. Negotiates, walks away, deadline deals. |
| **Manager AI** | AI managers pick tactics, transfers, youth by club philosophy. Gets sacked if underperforming. |
| **Player AI** | AI players grow, decline, request transfers, retire. Newgens enter each season. |
| **Board AI** | Sets objectives by club size, judges performance, hires/fires managers. |

### 12.3 Difficulty Scaling
- AI decision speed and error rate scale with difficulty.
- No stat inflation for AI. Same attributes, better decisions.
- Custom sliders for every aspect (AI speed, pass accuracy, shot power, etc.).

---

## 13. Presentation, Art & Audio

### 13.1 Art Direction: "Stylized AAA"
- **Not photoreal, not cartoon:** Clean, readable, broadcast-quality. Think *Rocket League* meets *FIFA* — vibrant, performant, timeless.
- **Stadiums:** 30+ unique stadiums (capacity, architecture, atmosphere). Day/night, weather, crowd.
- **Players:** Procedural faces (10,000+ combinations), kits, boots, hairstyles. Motion-captured animations (run, kick, celebrate, tackle).
- **Crowd:** 20,000+ animated fans per stadium (DOTS/ECS for performance). Banners, tifos, chants.
- **Performance:** 60fps target. LOD system for crowd/players. Scalable settings.

### 13.2 Broadcast Presentation
- **TV-style:** Score bug, replays, slow-mo, tactical cam, post-match analysis.
- **Commentary:** Two-person team (play-by-play + color). Contextual: knows your career, rivalries, form, history.
- **Crowd Audio:** Chants, boos, cheers scale with match importance.
- **Music:** Licensed-style original tracks (no licensing costs). Menu, stadium, career hub.

### 13.3 Audio
- **Commentary:** Recorded lines + dynamic text-to-speech fallback for generated names. 5,000+ lines at launch.
- **SFX:** Ball physics, boots, tackles, crowd, whistles — all procedural/recorded.
- **Music:** Original soundtrack. No live-service playlists.

---

## 14. UI/UX

### 14.1 Design Principles
- **Controller-first:** Navigate everything with gamepad. No mouse required.
- **Readable:** Large fonts, high contrast, colorblind modes.
- **Fast:** No loading screens between career weeks. Instant sim.
- **Beautiful:** Dark, premium UI with club colors. Animated transitions.

### 14.2 Main Menus
```
Main Menu
├── Continue Career (slot select)
├── New Career (Player / Manager / Club)
├── Quick Match
├── Training Ground
├── Settings
└── Workshop (mods)
```

### 14.3 Career Hub (Weekly View)
- Fixtures, table, news, training, transfers, squad — all on one screen.
- "Advance Week" button. No timers, no waiting.
- Notifications: injuries, contract expiring, scout reports, press.

### 14.4 Accessibility
- Colorblind modes, subtitles, remappable controls, difficulty options, assist features (auto-pass, auto-shoot).
- No QTEs, no reaction-time gates for core progression.

---

## 15. Tech Stack & Steam Plan

### 15.1 Engine Choice: Unity 6 LTS
| Criteria | Unity 6 | Unreal Engine 5 | Godot 4 |
|----------|---------|-----------------|---------|
| **Steam pipeline** | Excellent | Good | Good |
| **C# / Iteration speed** | Excellent | Medium (C++/BP) | Good (GDScript) |
| **Sports templates** | Strong (Asset Store) | Weak | Weak |
| **Crowd / DOTS performance** | Excellent (ECS) | Good | Medium |
| **Console export** | Good | Excellent | Medium |
| **Team size fit (1–10)** | Perfect | Heavy | Good |
| **Licensing cost** | Free until $1M | 5% royalty | Free |

**Decision: Unity 6 LTS** — fastest path to Steam, best for small team, C# ecosystem, Asset Store for stadiums/animations, DOTS for crowd, Addressables for mods/DLC.

### 15.2 Tech Stack
| Layer | Technology |
|-------|------------|
| **Engine** | Unity 6 LTS, URP (Universal Render Pipeline) |
| **Language** | C# |
| **Physics** | Unity Physics + custom ball physics |
| **Animation** | Animation Rigging, Timeline, Motion Capture (iClone / Rokoko) |
| **Crowd** | DOTS / ECS, GPU Instancing |
| **Save System** | JSON + SQLite (local), Steam Cloud sync |
| **UI** | UI Toolkit + TextMeshPro |
| **Audio** | FMOD / Wwise (or Unity Audio) |
| **Mod Support** | Addressables + Steam Workshop |
| **Analytics** | Local only (no tracking without consent) |
| **Version Control** | Git + Git LFS |

### 15.3 Steam Integration
- **Steamworks.NET:** Achievements, cloud saves, Workshop, leaderboards (optional, offline-friendly)
- **Steam Deck:** Verified (60fps, controller, offline)
- **Achievements:** 50+ (e.g., "First Goal", "Win the League", "Hall of Fame")
- **Workshop:** Kits, faces, leagues, stadiums, legends — community content
- **No DRM beyond Steam:** No Denuvo, no always-online

### 15.4 Project Structure
```
project-cmfbg/
├── docs/                  # Design docs (this folder)
│   ├── GDD.md             # This document
│   ├── ROADMAP.md         # Milestones & timeline
│   └── TECH_STACK.md      # Technical decisions
├── Assets/                # Unity project (to be created)
│   ├── Scripts/           # C# gameplay, career, AI
│   ├── Prefabs/           # Players, stadiums, UI
│   ├── Scenes/            # Menu, Match, Career Hub
│   ├── Art/               # Models, textures, animations
│   └── Audio/             # Music, SFX, commentary
├── Packages/              # Unity packages
├── ProjectSettings/       # Unity settings
└── README.md
```

---

## 16. Monetization & DLC Roadmap

### 16.1 Launch Model: Premium
- **Price:** $39.99 USD (Steam) — AAA feel, indie price
- **Includes:** All 3 career modes, 120+ clubs, 6 leagues, full 3D matches, commentary, Workshop
- **No microtransactions. No loot boxes. No premium currency.**

### 16.2 DLC Roadmap (Optional, Cosmetic/Content Only)
| DLC | Content | Price | Pay-to-Win? |
|-----|---------|-------|-------------|
| **Expansion 1: New Nations** | 2 new leagues, 30 clubs, new stadiums | $14.99 | No |
| **Expansion 2: Legends Pack** | 50 classic fictional legends, retro kits | $9.99 | No |
| **Expansion 3: Career Stories** | New story events, rivalries, documentaries | $9.99 | No |
| **Cosmetic Pack** | Boots, celebrations, stadium themes | $4.99 | No |

> DLC adds content, never advantages. A player who buys no DLC can still reach Hall of Fame.

### 16.3 Free Updates
- Balance patches, bug fixes, quality-of-life — free forever
- Community Workshop content — free
- No "Season Pass" or battle pass

---

## 17. Roadmap & Milestones

### Phase 0: Design (Now — Month 1)
- [x] GDD v1.0 (this document)
- [ ] Tech prototype: Unity project setup, ball physics, basic player controller
- [ ] Art style test: 1 stadium, 1 player model, broadcast camera

### Phase 1: Vertical Slice (Months 2–4) — *Playable Proof*
**Goal:** One player, one club, one playable 3D match, one week of career.
- Player creation (basic)
- 1 club, 1 league (10 teams)
- Playable 3D match: move, pass, shoot, tackle, score
- Basic career hub: fixtures, table, advance week
- Save/load (1 slot)
- **Exit Criteria:** Playable on Steam Deck, 60fps, fun for 30 minutes

### Phase 2: Player Career Alpha (Months 5–8)
- Full Player Career: attributes, training, trust, contracts, transfers, injuries
- 3 leagues, 40 clubs, full season simulation
- Commentary (basic), crowd, stadiums (5)
- **Exit Criteria:** Play a full season (16→17), earn transfer, retire path works

### Phase 3: Manager & Club Career (Months 9–12)
- Manager Career: tactics, transfers, board, press
- Club Career: finances, stadium, academy
- Unified world: Player → Manager transition
- 6 leagues, 120 clubs, continental cup
- **Exit Criteria:** All 3 modes playable, world simulation stable

### Phase 4: Polish & Steam (Months 13–15)
- Full commentary (5,000+ lines), motion capture, 30 stadiums
- Workshop support, achievements, Steam Cloud
- Localization (EN, ES, PT, DE, FR)
- Beta test (closed, 500 players)
- **Exit Criteria:** Steam Deck Verified, 60fps, no game-breaking bugs

### Phase 5: Launch (Month 16)
- Steam launch (1.0)
- Day-1 patch, community support
- DLC roadmap begins

**Total Timeline:** ~16 months for 1.0 with a small team (3–5). Early Access possible at Month 10 if needed.

---

## 18. Scope, Risks & Mitigations

### 18.1 Scope Control
| Must Have (1.0) | Nice to Have (DLC) | Cut (Never) |
|-----------------|--------------------|-------------|
| 3 career modes | New leagues | Live service |
| Playable 3D matches | Legends pack | Microtransactions |
| 6 leagues, 120 clubs | Story DLC | Ultimate Team clone |
| Commentary, crowd | Cosmetic packs | Always-online |
| Workshop | — | Loot boxes |

### 18.2 Risks
| Risk | Impact | Mitigation |
|------|--------|------------|
| **Match AI feels dumb** | Core fun dies | Prototype AI early (Phase 1), playtest weekly |
| **Scope creep (3 modes)** | Delays, bugs | Unified world = shared systems. Vertical slice first. |
| **Performance (crowd)** | FPS drops | DOTS/ECS, LOD, scalable settings, Steam Deck test |
| **Licensing temptation** | Legal/cost | Fictional world from day 1. No real names. |
| **Team burnout** | Delays | Small scope, weekly playable builds, no crunch |

### 18.3 What "AAA Quality" Means For Us
- 60fps on recommended specs, Steam Deck Verified
- Broadcast presentation, commentary, crowd — every match feels like TV
- Motion-captured animations, no janky movement
- Polished UI, no placeholder screens at launch
- Zero game-breaking bugs, stable saves

---

## 19. Success Metrics

### 19.1 Player Success
- **Fun:** 80%+ of beta testers play 5+ hours in first week
- **Depth:** Average career lasts 20+ seasons (players *want* to continue)
- **Fairness:** 90%+ agree "I earned everything, nothing was pay-to-win"

### 19.2 Business Success
- **Steam:** 50,000+ copies in first year (indie AAA target)
- **Rating:** 90%+ positive on Steam
- **Longevity:** 10,000+ Workshop items in first year

### 19.3 Community Success
- Modders create leagues, kits, legends
- Players share career stories (screenshots, videos)
- No "dead game" after launch — DLC + Workshop keep it alive

---

## 20. Appendix: Fictional World

### 20.1 Nations & Leagues (Inspired By, Not Copied)
| Nation | League | Tier 1 Clubs | Culture |
|--------|--------|--------------|---------|
| **Aurelia** | Aurelian Premier League | 12 | English-style, fast, physical |
| **Caldera** | Caldera Primera | 12 | Spanish-style, possession, technical |
| **Nordhavn** | Nordhavn Allsvenskan | 10 | Scandinavian, cold, direct |
| **Solmara** | Solmara Serie A | 12 | Italian-style, tactical, defensive |
| **Rheinland** | Rheinland Bundesliga | 10 | German-style, pressing, efficient |
| **Costa Verde** | Costa Verde Liga | 10 | Portuguese-style, flair, youth |
| **Highland** | Highland Premiership | 10 | Scottish-style, passionate, derby-heavy |
| **New Albion** | New Albion MLS-style | 12 | American-style, franchise, growth |

*Total: 8 nations, 6 tiers, 120+ clubs. All names fictional.*

### 20.2 Club Naming
- Fictional city + nickname: "Port Azure FC", "Ironhold United", "Solaris City"
- Unique kits, stadiums, rivalries, histories
- Editor allows renaming to real-world equivalents (player choice, not bundled)

### 20.3 Player Names
- Generated from 500+ first/last name pools per nation
- Diverse, culturally accurate, no real player likenesses

---

## Document Control

| Version | Date | Author | Changes |
|---------|------|--------|---------|
| 1.0 | 2026-11-12 | LEGACY Team | Initial GDD — Design Lock |

**Next Steps:**
1. Review & approve this GDD
2. Set up Unity 6 project structure
3. Build Vertical Slice (Phase 1)
4. Weekly playable builds → Steam demo

---

*LEGACY — No cards. No coins. No live service. Just your career.*

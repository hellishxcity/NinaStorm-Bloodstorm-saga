# NinaStorm: Blood Rising
## Sequel Project — Game Design Foundation

**Project status:** Early design / pre-production  
**Series:** NinaStorm  
**Relationship to original:** Sequel to *NinaStorm: The Bloodstorm*  
**Setting:** Approximately 100 years after the first game  
**Genre target:** Dark-fantasy, third-person action RPG; mobile-first design target  
**Implementation status:** This document records approved direction and proposals. It does not claim the gameplay systems described here are implemented.

---

## 1. High Concept

A century after the events of *NinaStorm: The Bloodstorm*, Nina Storm has established her queendom and built a family. The Fallen Angels have not forgotten that Nina killed one of their own. They return under the banner of revenge, but revenge conceals a much larger plan involving Nina's bloodline and the balance of power between the celestial and mortal worlds.

The sequel follows two playable protagonists:

- **Nina Storm**, the vampire queen known as the Bloodstorm.
- **King Kaine**, Nina's husband: a half-demon, half-human berserker who uses no magic and is immune to direct magical effects.

The central fantasy is two distinct warriors fighting together: Nina's speed, precision, and blood magic complement Kaine's raw physical power and resistance to magic.

**Tagline:** *A Queen's Legacy. A Fallen Heaven. A War Written in Blood.*

## 2. Story Premise

Roughly 100 years after the first game, Nina's realm has endured and changed. Nina now has a husband and family. The Fallen Angels launch a campaign against her, claiming vengeance for the member she killed a century earlier.

Their public motive is revenge; their true objective is larger. The details of the conspiracy remain to be developed. Possible directions include a celestial ritual, a sealed realm, or a weapon connected to Nina's bloodline. These are story options, not established canon.

The family must be written as active characters with their own motives and choices—not merely as recurring hostages.

### Core story questions

- What truly happened to the Fallen Angel Nina killed?
- Why does the faction need Nina's bloodline for its hidden plan?
- What does Nina's century of rule mean when her family and legacy are threatened?
- Can the queen protect her family without becoming the very monster her enemies claim she is?

### Proposed campaign outline

1. **Prologue — The Queen's Last Peace:** A threat surfaces during a period of relative stability in the queendom.
2. **Act I — The Broken Halo:** The Fallen Angels strike the outer territories and reveal that the invasion has been planned.
3. **Act II — The Bloodline Hunt:** The royal family and court face escalating danger while Nina and Kaine uncover the conspiracy.
4. **Act III — The Mythic Covenant:** Ancient regions and mythic foes reveal pieces of the history behind the conflict.
5. **Act IV — Heaven's Betrayal:** The protagonists confront the faction's deeper objective.
6. **Act V — Blood Rising:** The war reaches the queendom; choices shape the resolution and its cost.

This outline is provisional and should be revised as the story is developed.

## 3. Playable Protagonists

### Nina Storm — The Bloodstorm Queen

- Fast, technical third-person action combat.
- Sword combos, dodge timing, counters, parries, aerial attacks, and executions.
- Blood magic and vampiric abilities.
- Strong at precision damage, mobility, enemy control, and exploiting openings.

### King Kaine — The Unspellable Berserker

- Nina's husband; half-demon and half-human.
- Uses no magic, spells, or mana-based abilities.
- Direct magical effects cannot control, curse, possess, or magically bind him.
- Extraordinary physical strength, resilience, and ability to disrupt armored enemies.
- Fights with physical weapons such as greatswords, battle axes, and war hammers.
- His limitations should come from physical positioning, attack recovery, reach, stamina/pressure management, and environmental hazards.

**Magic-immunity rule:** Immunity to magic is not immunity to physical consequences. A spell that attempts to curse or control Kaine should fail, but a magical blast can still throw him into a wall, collapse a bridge beneath him, or cause other physical/environmental harm. This rule keeps him distinctive without making every encounter trivial.

### Kaine's proposed combat resource: Demonbreak

Kaine has no mana bar. Instead, a physical combat meter called **Demonbreak** may reward successful heavy attacks, counters, armor breaks, and aggressive play. At full charge, he enters a temporary berserker state with stronger stagger and interruption. This is a design proposal awaiting prototyping and balance tests.

## 4. Bloodbond Combat System

The defining gameplay feature is a two-hero combat system built around **Switch, Synergy, and Bloodbond**.

### Solo mode: switch between heroes

- The player can switch between Nina and Kaine during combat when the active character is not locked in a committed animation.
- The inactive hero is controlled by companion AI.
- AI assists can extend pressure or create openings.
- Switching should not automatically reset every combo; selected attacks can create handoff opportunities.
- Each hero has separate combat abilities and health management.

Example sequence: Nina launches an enemy, the player switches to Kaine for a heavy aerial strike, then switches back to Nina for a follow-up.

### Two-player co-op

The intended target is a shared campaign in which one player controls Nina and the other controls Kaine. Additional co-op boss encounters, challenges, and rewards may provide exclusive reasons to play with a friend.

Co-op is a major technical feature and should be implemented after the core combat and AI companion systems have been proven. Network synchronization, latency, reconnection, and boss-state consistency require dedicated testing.

### Bloodbond Attacks

Coordinated attacks reward players for creating and exploiting openings together.

- **Launch-and-Crush:** Nina launches an enemy; Kaine follows with a heavy slam.
- **Royal Crossfire:** Nina draws an enemy's guard while Kaine attacks from another angle.
- **Bloodstorm Breaker:** Nina exposes a weakness with blood magic; Kaine physically breaks the enemy's guard; Nina follows with a precision combo.
- **King's Judgment:** A contextual team execution for a staggered elite or boss.

These are design targets, not implemented mechanics. Each should have clear telegraphs, fair timing, and solo equivalents so story progress never requires finding a co-op partner.

### Bond Meter

A proposed shared meter can charge from coordinated counters, partner assists, boss interruptions, and successful double-team combos. At thresholds, it unlocks a powerful Bloodbond attack or finisher. It should be situational and not spammable.

## 5. Boss Design for Two Heroes

Some bosses should explicitly test the differences between Nina and Kaine without making either character mandatory in solo play.

Possible encounter roles:

- **Celestial Warden:** Nina exploits openings; Kaine resists selected direct magical controls and physically pressures its guard.
- **Abyssal Colossus:** Nina attacks exposed limbs; Kaine breaks armor plates and interrupts selected heavy attacks.
- **Fallen Seraph:** Nina handles precise counters and aerial openings; Kaine punishes the boss when it lands.

Bosses should remain readable and fair on mobile. Team mechanics must have a solo solution, while co-op can offer more efficient or more spectacular ways to exploit the same openings.

## 6. The 15 Mythic Bosses

The 15 mythic bosses already designed for the original game's wider boss-planning document are intended as the starting roster for *Blood Rising*. Their existing concepts and rewards should be reviewed and adapted to the sequel's century-later setting; none should be assumed implemented.

1. Varkhul, the Ashen Warlord
2. Sythra, Widow of the Moon
3. Khepra, the Dune Oracle
4. Ruun, Thunder-Eater
5. Eirvane, the Hollow Knight — name must be checked against the original game's existing Hollow Knight to avoid a naming conflict.
6. Lady Vael, Thorn of the Court
7. Pelagos, the Drowned King
8. The Kuro Twins
9. Morrigaine, the Raven Matron
10. Azhdara, Coil of the First Flame
11. Nimue, the Glass Leviathan
12. Baba Yaga's Iron Stag
13. Xolotl, the Bone-Crowned
14. Tiamat's Exile, Nhalassa
15. The Starved Saint

Each major boss should have a distinct arena, readable attack language, a meaningful weakness or counterplay loop, and a memorable reward. Some mythic bosses may be optional or faction-neutral; they should not all automatically be Fallen Angels.

### Co-op execution principle

Major bosses may have unique Nina-and-Kaine finishers. Reusable execution logic can support bespoke animation, camera, audio, and reward beats. Solo players must be able to trigger equivalent story rewards without a second player.

Example concept: Nina exposes a boss's core while Kaine breaks its guard, allowing a synchronized final attack. The exact animation and mechanics remain to be designed and tested.

## 7. Nina and Kaine's Family

The current story direction includes **twins: a son and a daughter**. Their ages, names, powers, personalities, and playable status are not yet locked.

The twins should have agency and individual goals. Their heritage may create tension or mystery, but the rules of inheritance must be defined before their abilities are finalized. The initial scope should prioritize Nina and Kaine as the two playable protagonists; a playable heir could be considered for a later expansion or sequel.

## 8. Proposed Mobile Controls

- Left-side movement joystick.
- Right-side light/heavy attacks, dodge, block/parry, and ability controls.
- Character-switch control in solo mode.
- Contextual Bloodbond/finisher control.
- Optional lock-on targeting.
- Customizable button placement and size.
- Clear teammate status and revive/recovery feedback in co-op.

The interface must remain usable on smaller screens and avoid requiring simultaneous multi-finger inputs that are unrealistic for mobile players.

## 9. Development Roadmap

### Phase 1 — Dual-character foundation
- Prototype Nina and Kaine movement and combat.
- Implement character switching.
- Implement AI companion following, combat assists, and recovery.
- Establish and test Kaine's anti-magic rules.

### Phase 2 — Team combat
- Add assist attacks and combo handoffs.
- Prototype Bloodbond attacks and the Bond Meter.
- Build one team finisher.
- Validate that every essential encounter is completable solo.

### Phase 3 — Boss integration
- Build one boss with distinct Nina and Kaine counterplay.
- Test solo and co-op strategies.
- Add synchronized stagger states and execution triggers.

### Phase 4 — Online co-op
- Add two-player sessions.
- Synchronize movement, attacks, enemy states, boss phases, and finishers.
- Test latency, disconnects, reconnection, and mobile performance.

### Phase 5 — Content expansion
- Adapt the 15 mythic bosses.
- Expand the story and royal sanctuary.
- Add optional co-op encounters and rewards.
- Balance the campaign for solo and two-player play.

## 10. Production Principles

1. **Distinct protagonists:** Nina and Kaine must feel different in movement, combat rhythm, strengths, and weaknesses.
2. **Teamwork with agency:** Co-op should reward coordination, not require both players to press a button at the same time for every encounter.
3. **Solo parity:** Essential story content and rewards must remain available to solo players.
4. **Fair anti-magic design:** Kaine rejects direct magical effects but can still be harmed by physical attacks and environmental consequences.
5. **Mobile readability:** Telegraphs, controls, and camera framing must work on small screens.
6. **Reward every major victory:** Bosses can unlock weapons, techniques, relics, secrets, or story consequences.
7. **Scope responsibly:** Prove the core dual-character combat before building all 15 bosses and online co-op.
8. **Design versus implementation:** All mechanics in this document are design goals until implemented and tested.

---

## Browser Prototype Milestone — v0.1

A first browser-based combat-feel prototype has been added at [`docs/blood-rising-prototype.html`](./blood-rising-prototype.html) on the `dev/blood-rising-project` branch. It is an early playable experiment, not a production build. Current intended prototype systems include:

- Nina/Kaine hero switching in solo play, with the inactive hero following as a simple AI companion.
- Distinct light/heavy attack damage and cooldowns to test Nina's faster rhythm against Kaine's heavier strikes.
- A basic Team Bond meter and area Bloodbond finisher.
- Enemy pursuit, hit reactions, health bars, dodge input, and keyboard/touch controls.
- A small arena encounter for evaluating combat pacing before expanding into story missions.

**Verification status:** The file is committed to the development branch and its contents were fetched back from GitHub. It has not yet been browser-tested across devices, and its systems are prototype logic only. Online co-op, real networking, animation-driven combat, production-grade AI, full character rigs, and Unity implementation are not included in this milestone.

## Current Project Decisions

- Title: **NinaStorm: Blood Rising**
- Timeline: approximately 100 years after *NinaStorm: The Bloodstorm*
- Main playable heroes: Nina Storm and King Kaine
- Nina: vampire queen with blood magic and precision action combat
- Kaine: half-demon/half-human berserker; no magic; immune to direct magical effects
- Family: Nina and Kaine have twins, a son and a daughter; details TBD
- Antagonists: Fallen Angels seek revenge, but revenge conceals a larger plan
- Combat: switchable heroes in solo mode; AI partner; intended two-player co-op
- Signature system: Bloodbond coordinated attacks, double-team boss strategies, and co-op finishers
- Boss foundation: 15 mythic bosses adapted from prior planning
- Production status: design foundation plus an early browser combat prototype; full game and online co-op remain unimplemented

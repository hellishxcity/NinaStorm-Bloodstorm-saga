# NinaStorm: The Bloodstorm — Boss Bible of Veilfell
**Working design document · Test branch · v0.1**

> **Canon rule:** This document separates previously established project details from new proposals. Only the Hollow Knight and the browser prototype's Dread Knight are currently established boss concepts in the available project notes. All other bosses below are proposals for Kaine to approve, rename, combine, or reject.

## Design pillars
- **Precision over button-mashing:** readable wind-ups, dodge windows, parries/counters, punish windows, and escalating phases.
- **Every boss teaches a lesson:** each fight tests a skill the player needs later.
- **Bloodright Executions:** a defeated major boss can trigger a signature execution sequence, a relic/weapon reward, and a new ultimate. Treat the current browser implementation as a prototype of this system, not the finished cinematic version.
- **Mobile-first fairness:** clear telegraphs, generous touch targets, short input sequences, camera readability, and no attack that requires pixel-perfect touch input.
- **Lore consequences:** boss victories reveal what happened to Veilfell and give Nina a choice between mercy, dominion, or destruction where the story supports it.

## Roster status at a glance

| Boss | Status | Arena / role | Signature mechanic | Proposed reward |
|---|---|---|---|---|
| Hollow Knight — “The Knight Who Forgot Death” | Established concept; subtitle is proposed | Ruined chapel / early skill-check | Heavy, delayed strikes and a punishable recovery | Chapel Oath: parry/counter relic |
| Dread Knight | Present in browser prototype | Ashen March / first major execution | Heavy pursuit, wide sword arcs, boss health bar | Ashen Judgment |
| Blood Abbess Veyra | New proposal | Sunken abbey | Blood pools that reshape safe ground | Vein Benediction |
| Mirefang, the Fen Tyrant | New proposal | Drowned fen | Ambushes, poison bog, exposed weak points | Mirefang's Grasp |
| The Cinder Wyrm | New proposal | Furnace undercroft | Heat zones, sweeping breath, breakable armor plates | Cinderwake |
| The Bellfather | New proposal | Bell tower above Veilfell | Sound-wave timing and bell-strike shockwaves | Funeral Resonance |
| Father Malrec, the Blood Inquisitor | Based on established antagonist name; encounter design is proposed | Cathedral tribunal | Marks Nina, then punishes repeated dodge patterns | Inquisitor's Brand |
| Seraphel, the Fallen Angel | Established antagonist identity; final-boss mechanics are proposed | The Veil Throne | Multi-phase duel, light/shadow lanes, bloodstorm finale | Crown of the Last Storm (ending-dependent) |

## Boss dossiers

### 1. Hollow Knight — “The Knight Who Forgot Death”
**Status:** The Hollow Knight was previously identified as a planned tougher boss with distinct attack patterns and a boss health bar. The epithet and details below are proposals.

**Story role:** A once-honored guardian still defending a kingdom that no longer exists. His armor is empty of life but driven by an oath twisted by the Bloodstorm.

**Fight beats**
1. **Oathbound:** slow, readable two-handed cleaves; teaches dodge timing.
2. **Grave March:** a short advancing combo; a late dodge creates a clear punish window.
3. **Hollow Resolve (low health):** adds a delayed overhead strike to catch panic-dodging.

**Counterplay:** bait the overhead, dodge to the side, then use a short combo. Do not let the player safely mash attacks through his armor.

**Proposed Bloodright reward:** *Chapel Oath*, a parry-focused relic that briefly strengthens Nina's next counter. **Not implemented.**

### 2. Dread Knight
**Status:** The current browser prototype's final enemy is configured as a larger boss with 12 HP and a boss health bar. The execution flow awards the Ashen Judgment ability. His combat AI is not yet a fully bespoke boss encounter, and the reward's sword attachments are visual placeholders rather than a real inventory weapon.

**Fight beats (design target)**
1. **Iron Advance:** closes distance and uses a wide sword arc.
2. **Crimson Guard:** braces against frontal attacks; circle behind or break his stance.
3. **Last Stand:** faster follow-up after a clearly telegraphed heavy strike.

**Execution / reward:** the prototype uses W → A → SPACE on keyboard or three taps on the mobile EXECUTE button. Completion grants the *Ashen Judgment* area attack in the prototype: radius 7, 5 damage, stun/knockback, 8-second cooldown. These values are implementation notes and need real gameplay balancing.

**Testing note:** syntax has passed, but browser rendering, touch behavior, boss combat, execution timing, and reward persistence still require actual runtime/device testing.

### 3. Blood Abbess Veyra *(new proposal)*
**Arena:** a flooded abbey where crimson water runs through cracked stone channels.

**Identity:** A former healer who decided that every wound could be cured by taking someone else's blood.

**Mechanics:** Veyra paints blood pools on the floor. Pools pulse after a short delay, forcing the player to reposition. In phase two, she links pools into a narrow lane and attacks down it.

**Counterplay:** read the floor telegraph, move to dry stone, then punish her channeling animation.

**Proposed reward — Vein Benediction:** a short-range blood siphon that restores a small amount of health when it hits an enemy. It should have a clear cooldown and should not trivialize boss fights.

### 4. Mirefang, the Fen Tyrant *(new proposal)*
**Arena:** a drowned forest and sinking causeway in the Ashen March.

**Identity:** An ancient beast swollen by alchemical runoff from a hidden blood-forge.

**Mechanics:** disappears into shallow water, attacks from marked ripple zones, and uses a poison-breath cone. Its plated head resists frontal damage until it misses a charge and exposes its flank.

**Counterplay:** use the ripple warning to evade the ambush; bait the charge into roots or stone to open the weak point.

**Proposed reward — Mirefang's Grasp:** a short pull that interrupts lighter enemies. Bosses should resist or only partially react to it.

### 5. The Cinder Wyrm *(new proposal)*
**Arena:** a furnace chamber beneath a ruined keep.

**Identity:** A dragon-like creature chained to the machinery of an ancient forge.

**Mechanics:** sweeping fire breath, falling embers, and armor plates that glow before a heavy attack. Destroying or staggering a plate briefly exposes a weak point.

**Counterplay:** move between marked heat lanes and attack after the breath or slam.

**Proposed reward — Cinderwake:** a forward-moving flame slash with a limited number of charges or a Blood Essence cost.

### 6. The Bellfather *(new proposal)*
**Arena:** Veilfell's shattered bell tower, suspended above a ravine.

**Identity:** A towering keeper who rings the bells to summon the dead and believes the kingdom must never be allowed to rest.

**Mechanics:** bell strikes send expanding ground waves; each bell has a different rhythm. Later phases layer two rhythms but keep safe gaps readable on mobile.

**Counterplay:** jump or dodge through the shockwave at its marked timing, then strike the bell chain or boss during recovery.

**Proposed reward — Funeral Resonance:** a radial pulse that briefly staggers nearby lesser enemies.

### 7. Father Malrec, the Blood Inquisitor *(encounter proposal using established antagonist name)*
**Arena:** a cathedral tribunal lined with broken saint statues.

**Identity:** A fanatical architect of the kingdom's suffering, convinced Nina's return proves that all life must be judged.

**Mechanics:** places a visible mark on Nina; repeating the same dodge direction lets him predict and punish her. He alternates between close-range sword pressure and a clearly marked line attack.

**Counterplay:** vary dodge direction, parry the end of his three-strike sequence, and punish the recovery of his line attack.

**Proposed reward — Inquisitor's Brand:** a short curse that makes marked ordinary enemies take extra damage for a limited time. Its effect on bosses should be reduced.

### 8. Seraphel, the Fallen Angel *(final-boss encounter proposal)*
**Arena:** the Veil Throne, where the Bloodstorm tears open the sky.

**Identity:** The established fallen-angel antagonist; the encounter structure below is proposed, not yet implemented.

**Fight beats**
1. **The Radiant Judge:** deliberate spear or blade attacks with high-contrast telegraphs.
2. **The Broken Halo:** arena lanes alternate between dangerous light and shadow; the player must reposition rather than hold one spot.
3. **The Bloodstorm Crown:** combines familiar patterns from earlier bosses, then opens brief, earned punish windows.

**Counterplay:** use the lessons from earlier fights. No unavoidable damage loops; every major attack needs a readable tell and a viable dodge/parry response.

**Proposed ending reward:** *Crown of the Last Storm*, with the final form and powers shaped by Nina's story choices. The reward and ending details need Kaine's approval.

## Bloodright Execution system — target specification
1. Boss reaches zero health and enters a short staggered execution state.
2. Camera, sound, and boss pose clearly communicate the opening (full cinematic treatment is a later milestone).
3. Player completes a short, accessible input sequence. Mobile uses large, clearly labeled tap targets; avoid long rapid-tap sequences.
4. Nina performs a boss-specific finisher; the boss's weapon/relic is shown being claimed.
5. Reward is added to a real unlock/inventory state and saved only after the game confirms success.
6. New ultimate is explained in a short on-screen card, with its cost, range, cooldown, and a safe practice opportunity.
7. If the player misses the sequence, allow a retry or a brief recovery fight rather than silently losing the reward.

## Implementation truth vs. target vision
- **Currently represented in browser prototype:** Dread Knight-style final enemy, boss health bar, execution input sequence, visual sword reward, and Ashen Judgment area ability.
- **Not yet confirmed/implemented as production systems:** unique boss arenas, bespoke phase logic for every boss, true weapon inventory/unlocks, cinematic cameras/animations/audio, persistent reward saves, Unity integration, and mobile-device testing.
- **Recommended first playable order:** Hollow Knight tutorial boss → Dread Knight execution → Blood Abbess Veyra. Build and tune these three before committing to all eight.
- **Performance direction:** telegraph attacks with simple readable shapes and limited simultaneous effects; keep touch controls forgiving; test on a real mid-range Android device before expanding enemy counts or visual effects.

## Decisions for Kaine
1. Approve, rename, or replace any of the six proposed bosses.
2. Choose whether Father Malrec is a penultimate boss and Seraphel the final boss.
3. Decide whether Nina's major executions are always lethal, or whether certain story choices allow mercy, binding, or recruitment.
4. Confirm if Ashen Judgment should remain the Dread Knight reward and whether its current 5-damage / 7-radius / 8-second-cooldown prototype values feel right after testing.

**Status:** Design draft for review. Nothing in this document changes the live/main branch or claims these proposed encounters are already playable.

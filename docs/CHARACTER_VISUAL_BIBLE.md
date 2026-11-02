# NinaStorm: The Bloodstorm — Character Visual Bible

**Source basis:** User-provided Nina Storm expression board, 3D sprite/model reference sheet, character-creation mockup, outfit boards, and turnaround reference. These are concept references, not proof that a production-ready 3D model or animations already exist.

## 1. Character identity and continuity
- Name: Nina Storm.
- Title: Queen of Veilfell; the Bloodstorm Queen.
- Core presentation: commanding vampire queen, dangerous and composed, with a gothic medieval fantasy identity.
- Signature visual cues in the supplied references: dark skin, long dark braids with crimson-red accents, red supernatural eye glow, black/dark armor and fitted layered clothing, dark metal accessories, and blood-red VFX.
- Keep the face, braid silhouette, red accents, eye treatment, jewelry, body proportions, and armor details consistent across gameplay, cinematics, portraits, and promotional art.
- Avoid allowing AI image/video variations to silently become canon. New variations are proposals until approved.

## 2. Expression set
The supplied expression reference labels four core expressions:
1. **Neutral** — calm, watchful default; controlled and regal.
2. **Angry** — narrowed eyes and restrained hostility; used for threats or tense dialogue.
3. **Smirk** — confident, knowing expression; used after a successful counter, taunt, or victory.
4. **Rage** — open aggression and supernatural intensity; reserved for Blood Surge, rage-state combat, or major story beats.

Implementation target: create a facial-expression blend-shape or equivalent rig for these four states, with transitions that do not distort Nina's facial identity. This is a target, not yet confirmed as implemented.

## 3. Model and animation reference
The supplied 3D sprite sheet depicts front, front three-quarter, side, back three-quarter, and back views; head close-up; detail crops; color variants; and animation/contact sheets.

Animation categories visible in the reference:
- Idle
- Walk
- Run
- Melee attack
- Ranged attack
- Skill / special
- Jump
- Hurt
- Death
- Blood manipulation

The sheet also proposes particle-effect categories:
- Blood aura
- Blood slash
- Lightning
- Teleport
- Blood storm

Production guidance:
- Treat the supplied sheets as visual/animation targets; do not assume they are engine-ready sprite sheets or rigged animation files.
- For the intended full 3D third-person Unity game, prioritize a properly rigged 3D character, animation clips, root-motion/movement policy, and readable combat hit timing.
- If a 2D/3D sprite-sheet prototype is used, confirm frame order, dimensions, transparency, and licensing before importing.
- Avoid relying on a static concept sheet as an actual playable model.

## 4. Outfit wardrobe reference
The user-provided outfit boards show multiple proposed looks, including:
- Royal Vampire / crown-and-cape look
- Gothic Lace / classic dark formal look
- Leather combat look
- Blood Priestess / ritual look
- Night Hunter / practical dark look
- White Vampire / pale ceremonial look
- Witch / occult look
- Battle Vampire / warrior look
- Dark Angel / fallen look
- Red Queen / luxury royal look
- Shadow / hooded look
- Casual Vampire
- Nun of Darkness
- Leather Jacket
- Fur Coat
- Silk Robe
- Assassin
- Angel of Death
- Street Vampire

These are **wardrobe concepts**, not a commitment that every outfit ships in the base game. Recommended wardrobe organization:
- **Core story outfit:** one stable, canonical black-and-crimson combat design.
- **Royal / ceremonial:** crown, cape, regal trim; suitable for Queendom and story scenes.
- **Combat variants:** practical silhouettes that preserve weapon readability and movement.
- **Stealth / assassin:** hood or mask options with restrained VFX.
- **Occult / ritual:** Blood Priestess and Witch-inspired options.
- **Cosmetic variants:** White Vampire, Red Queen, fur coat, silk robe, casual looks, and other approved skins, scheduled only after core combat is solid.

Outfits must preserve silhouette and readability, avoid clipping during attacks and dodges, and maintain clear material separation between cloth, leather, metal, hair, and blood VFX. Cosmetic outfits should not silently change combat stats unless explicitly designed as equipment.

## 5. Character creation mockup
The provided UI concept depicts class choices (Vampire, Warrior, Rogue, Sorceress, Ranger) and customization controls for skin tone, hair style, eye color, and body type.

**Canon/design caution:** Nina is the named protagonist and established vampire queen. Do not make the core identity or story dependent on changing Nina into an unrelated class. If this UI is used, consider separating:
- Nina's fixed story identity and signature features, from
- optional cosmetic customization, alternate loadouts, or a separate create-your-own-character mode.

Class selection is currently a concept shown in the reference image, not an approved change to Nina's canonical class system.

## 6. Gameplay and VFX readability
- Red/crimson is Nina's signature supernatural accent; use it to communicate blood magic and high-value combat events.
- Keep VFX short enough that enemies, boss tells, and weapon contact remain readable on mobile screens.
- Blood Storm should feel large and powerful but have a clear start, peak, and end.
- Teleport and lightning effects in the sheet are visual proposals; their mechanics and naming should be finalized against the combat design before implementation.
- Rage expression should be tied to a defined gameplay or story trigger rather than played constantly.

## 7. Mobile-first production priorities
1. Approve one canonical model/outfit silhouette.
2. Build and validate idle, walk, run, dodge, light attack, heavy attack, hurt, and execution animations.
3. Add the four facial expressions.
4. Implement one signature blood effect and verify readability/performance on target mobile hardware.
5. Add outfit swapping only after the base rig and combat animations are stable.
6. Add extra cosmetic outfits as modular content with clipping checks.
7. Capture real gameplay footage separately from AI/concept footage for marketing.

## 8. Scope and status
- Main game: *NinaStorm: The Bloodstorm*.
- Exactly **26** main-campaign boss slots; the additional **15** bosses remain reserved for *NinaStorm: Blood Rising*.
- This document records approved visual direction and implementation targets. It does not claim that a final 3D model, expression rig, outfits, or listed animation clips have been built or tested.
- The spreadsheet referenced by the user should be reconciled with this visual bible once its actual file is available. Do not infer spreadsheet-only stats or names from the images.

import { readFileSync } from 'node:fs';
import assert from 'node:assert/strict';

const html = readFileSync(new URL('../docs/index.html', import.meta.url), 'utf8');
const scriptMatch = html.match(/<script>([\s\S]*?)<\/script>/i);

assert.ok(scriptMatch, 'Expected an inline game script in docs/index.html');
const script = scriptMatch[1];

// Compile without executing browser APIs or starting the game loop.
assert.doesNotThrow(() => new Function(script), 'Inline game script must parse as valid JavaScript');

const scriptChecks = [
  ['versioned Bloodright save key', /ninastorm_bloodright_save_v1/],
  ['legacy save migration key', /ninastorm_bloodright_skull_tithe/],
  ['save format version', /version:1/],
  ['Skull-Tithe unlock persistence', /unlockedWeapons:\[\s*["']skull-tithe["']\s*\]/],
  ['weapon toggle action', /function toggleWeapon\(/],
  ['Arsenal button interaction', /arsenalBtn.*toggleWeapon/s],
  ['duplicate reward guard', /const firstClaim=!bossWeaponClaimed/],
  ['gold reward only on first claim', /if\(firstClaim\)goldCount\+=100/],
  ['save failure messaging', /SAVE UNAVAILABLE/],
];

for (const [label, pattern] of scriptChecks) {
  assert.match(script, pattern, \`Missing expected feature: \${label}\`);
  console.log(\`PASS: \${label}\`);
}

assert.match(html, /id="pad"/, 'Missing mobile touch movement control');
console.log('PASS: mobile touch controls');
console.log('PASS: inline JavaScript syntax');
console.log('Bloodright prototype static validation passed. Browser/device gameplay is not tested by this script.');

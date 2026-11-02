import assert from 'node:assert/strict';
import { spawn } from 'node:child_process';
import { setTimeout as delay } from 'node:timers/promises';
import { chromium } from 'playwright';

const port = 4173;
const server = spawn('python3', ['-m', 'http.server', String(port), '--directory', 'docs'], {
  stdio: 'ignore',
});
let browser;
try {
  let ready = false;
  for (let i = 0; i < 40; i++) {
    try {
      const response = await fetch(`http://127.0.0.1:${port}`);
      if (response.ok) { ready = true; break; }
    } catch {}
    await delay(250);
  }
  assert.ok(ready, 'Local prototype server should start');
  browser = await chromium.launch({ headless: true, args: ['--use-gl=swiftshader', '--enable-webgl'] });

  // Desktop boot and locked-weapon behavior.
  {
    const page = await browser.newPage({ viewport: { width: 1280, height: 800 } });
    const pageErrors = [];
    page.on('pageerror', error => pageErrors.push(error.message));
    await page.goto(`http://127.0.0.1:${port}`, { waitUntil: 'domcontentloaded' });
    await page.waitForSelector('canvas', { timeout: 20000 });
    await page.waitForFunction(() => window.THREE && document.querySelector('canvas'));
    assert.equal(await page.title(), 'NinaStorm: The Bloodstorm — Prototype');
    assert.equal(await page.locator('#arsenalBtn').innerText(), 'ARSENAL: BLOOD BLADE');
    await page.locator('#arsenalBtn').click();
    await page.waitForFunction(() => document.querySelector('#message').textContent.includes('SKULL-TITHE IS LOCKED'));
    await page.locator('#play').click();
    await page.waitForFunction(() => document.querySelector('#start').style.display === 'none');
    assert.deepEqual(pageErrors, [], 'Desktop page should not throw runtime JavaScript errors');
    await page.close();
  }

  // Seed a legitimate existing unlock, toggle it, and confirm persistence across reload.
  {
    const context = await browser.newContext({ viewport: { width: 1280, height: 800 } });
    await context.addInitScript(() => localStorage.setItem('ninastorm_bloodright_save_v1', JSON.stringify({
      version: 1, unlockedWeapons: ['skull-tithe'], equippedWeapon: 'blood-blade'
    })));
    const page = await context.newPage();
    await page.goto(`http://127.0.0.1:${port}`, { waitUntil: 'domcontentloaded' });
    await page.waitForSelector('canvas', { timeout: 20000 });
    assert.equal(await page.locator('#arsenalBtn').innerText(), 'ARSENAL: BLOOD BLADE');
    await page.locator('#arsenalBtn').click();
    await page.waitForFunction(() => document.querySelector('#arsenalBtn').textContent === 'ARSENAL: SKULL-TITHE');
    let saved = await page.evaluate(() => JSON.parse(localStorage.getItem('ninastorm_bloodright_save_v1')));
    assert.equal(saved.equippedWeapon, 'skull-tithe');
    await page.reload({ waitUntil: 'domcontentloaded' });
    await page.waitForSelector('canvas', { timeout: 20000 });
    assert.equal(await page.locator('#arsenalBtn').innerText(), 'ARSENAL: SKULL-TITHE');
    await page.locator('#arsenalBtn').click();
    await page.waitForFunction(() => document.querySelector('#arsenalBtn').textContent === 'ARSENAL: BLOOD BLADE');
    saved = await page.evaluate(() => JSON.parse(localStorage.getItem('ninastorm_bloodright_save_v1')));
    assert.equal(saved.equippedWeapon, 'blood-blade');
    await context.close();
  }

  // Mobile viewport: controls exist and touch layout is available.
  {
    const context = await browser.newContext({
      viewport: { width: 390, height: 844 }, isMobile: true, hasTouch: true,
      deviceScaleFactor: 1
    });
    const page = await context.newPage();
    await page.goto(`http://127.0.0.1:${port}`, { waitUntil: 'domcontentloaded' });
    await page.waitForSelector('canvas', { timeout: 20000 });
    assert.equal(await page.locator('#pad').count(), 1);
    assert.equal(await page.locator('#attackBtn').count(), 1);
    assert.equal(await page.locator('#dodgeBtn').count(), 1);
    assert.equal(await page.locator('#arsenalBtn').isVisible(), true);
    await context.close();
  }

  console.log('PASS: browser boot and locked Skull-Tithe behavior');
  console.log('PASS: unlocked Arsenal toggle and localStorage persistence across reload');
  console.log('PASS: mobile viewport and touch-control markup');
  console.log('NOTE: boss execution animation and physical Android device behavior still require manual verification.');
} finally {
  if (browser) await browser.close();
  server.kill('SIGTERM');
}

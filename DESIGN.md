# Design document

## Goal

Entice and reward the player to play "stylish", by changing regularly of weapon,
creating combos, activate the weapons powers more often and overall play riskier
and with a more diverse move set.

## Concept

### Exploration

While exploring and moving on the map, the style meter will not appear.

When encountering one or multiple enemies, it will appear as a big letter at the
top of the screen, representing the player's style rank (except for Blasphemous
and Blasphemous II).

1. Blasphemous II
2. Blasphemous
3. A
4. B
5. C
6. D

A style board with the list of actions that gives styles points ot maluses could
be displayed at the bottom of the screen (under The Penitent One), with messages
appearing when the player fights.

### Boss fights

Boss fights will have a separate Style Meter from the normal Exploration one,
but this one will keep the same mechanics and ranks.

The style meter will start at 0 no matter what the exploration style meter's
status was, and is specific to a boss.

One the boss is defeated, the average rank will be computed and will represent
the rank of the fight.

I don't have any idea where the fight's rank or style score could be displayed
or consulted. Maybe a separate menu?

### Idling

Idling will pause the style meter, giving temporarily the "aura farming" status,
as The Penitent One farms aura while waiting for the player's input.

## Style

### What is "stylish"?

Moves or attacks that icreases the style meter and/or multiplicator.

- Swapping weapons often.
- Making combos of attacks.
- Casting prayers and quickverses.
- Using the weapons powers.
- Riposting.
- Taking a kill.
- Executing an enemy.
- Killing a boss.
- Dodging through attacks or enemies.

### What is NOT "stylish"?

Moves or attacks that do not increase the style meter and/or multiplicator, and
can even decrease it.

- Repeating the same attack.
- Repeating the same combo.
- Repeating the same prayer/quickverse.
- Taking damage.

### What boosts style?

Passively buffs the style multiplicator.

- Having altarpieces resonances.
- Having lower health (not max health), more risks = more rewards.

## How to reward the player?

- Score
- Higher chances of gaining marks or martyrdom
- More tears of atonement
- Less damage taken
- More damage given
- Reduce guilt?

## How to make a progression?

At the start, the player only has one weapon, a few prayers and quick verses,
and few martyrdom points. How can we make it so that the player's style can
still be recognised with less diversity in the weapons and move set?

### Idea 1: Bosses

Increase the "expected" style ranks for every boss defeated.

Pros:
- This forces the players to look for items that will help them optimize their
  style for the next fight.

Cons:
- Depending on the boss fought, this might be easier or harder to reach the
  style goals.
- A boss could be skipped with a bug, lowering the style goals, or an optional
  boss fought, increasing the style goals.

### Idea 2: Upgrades

Increase the "expected" style ranks for every prayer/quick verse found or
martyrdom point gained/weapon skill unlocked.

Pros:
- The player is expected to use all of the items and upgrades they have found,
  or to improve their playstyle for every new upgrade.

Cons:
- The player can skip every upgrade or item to keep their expected style ranks
  lower and easier to achieve.

### Idea 3: Save score

Chose Idea 1 and/or Idea 2, and add a global score to the save file which is a
total of all the points gained + the play time until reaching the end.

Pros:
- If the player wants a better save score, they need to get upgrades and items,
  and beat bosses to increase their style goals, allowing them to mark more
  points and a higher score.

Cons:
- If normal enemies are taken into account, the player can farm enemies to
  inflate the save score.
- If normal enemies are not taken into account, the player might just skip them
  and rush to the bosses.


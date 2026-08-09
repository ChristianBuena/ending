# ENDING

## GAME DESIGN DOCUMENT

Version 1.0

## 01. GAME IDENTITY

Title: ENDING
Genre: Top-Down Survival Farming / Base Defense
Platform: PC
Engine: Unity
Camera: Top-Down Orthographic
Art Style: Cute, stylized, chibi, cartoon-like 2D
Core Inspiration:
Zombie survival
Farming
Base defense
Resource management

## 02. GAME CONCEPT

ENDING is a top-down survival farming game set during a zombie apocalypse.
The player owns a small farm that becomes their main source of survival and defense.
Unlike traditional zombie survival games, the player's strongest defenses are not guns.
They are living plants. The player must plant, grow, water, and maintain defensive plants that protect the farm from incoming zombies.
The player must balance:
Farming
Plant maintenance
Combat
Ammunition
Coins
Equipment
Preparation
The game follows a day-and-night survival structure.
During the day, the player prepares.
During the night, the player survives.

## 03. CORE GAME FANTASY

The player's fantasy is:
"I am turning a small farm into a living fortress while the world around me
is being destroyed by zombies."
The player should gradually see their farm transform.

### AT THE BEGINNING:

Small farm
Few plants
Weak weapon
Few resources

### LATER:

More plants
Stronger defenses
Better equipment
More resources
More dangerous zombies
The farm should feel alive.

## 04. CORE GAMEPLAY LOOP

### DAY:

Wake up  Check farm  Water plants   Plant seeds  Prepare defenses  Buy supplies  Repair / organize  Prepare for night

### NIGHT:

Zombie wave begins  Zombies enter the farm  Player fights  Plants defend automatically  Player protects vulnerable plants  Zombies are defeated  Coins are collected  Wave ends  Morning begins

## 05. CORE DESIGN PRINCIPLE

GUNS = SHORT-TERM POWER
PLANTS = LONG-TERM POWER
The player should never feel that guns completely replace plants. A gun helps the player survive immediate danger. A healthy plant provides defense repeatedly.
This creates a strategic decision:
"Do I spend my coins on ammunition?" OR "Do I invest in another plant?"

## 06. PLAYER

The player controls a survivor living on a farm.
PLAYER ACTIONS
Movement
Aim
Shoot
Reload
Interact
Use Hoe
Plant Seeds
Water Plants
Buy Items

### FUTURE:

Explore
Craft
Build
Repair
Upgrade

## 07. PLAYER RESOURCES

HEALTH: Represents the player's survival. If health reaches zero: GAME OVER
AMMO: Used by guns. Ammo is limited. The player must purchase additional ammunition.
COINS: Primary currency. Obtained by defeating zombies. Used for:
Seeds
Ammo
Equipment
Weapons
Future upgrades
SEEDS: Used to grow defensive plants. Different seeds produce different plants.
WATER: Used to maintain plants. Water is required for plants to remain effective.

## 08. FARM

The farm is the player's main base.
MVP FARM AREAS
Player Spawn
Planting Area
Shop
Water Source
Zombie Entry Points
FUTURE
Storage
Workbench
Greenhouse
Animal Area
Buildings
Walls
Traps

## 09. FARMING SYSTEM

The farming system is one of the main mechanics of ENDING. The player must physically prepare the land before planting.
PROCESS
Equip Hoe  Till Soil  Select Seed  Plant Seed  Water Plant  Wait for Growth  Plant Becomes Mature  Plant Becomes Defensive

## 10. PLANT SYSTEM

Plants are living defensive units. They are not static towers. They have needs.
Each plant can have:
Health
Water
Growth Stage
Damage
Attack Speed
Range
Plants can:
Grow
Attack
Take Damage
Become Weak
Die

## 11. PLANT MAINTENANCE

Plants gradually lose water. Water level affects their performance.
FULL WATER: 100% effectiveness
MEDIUM WATER: Reduced effectiveness
LOW WATER: Significantly reduced effectiveness
NO WATER:  Plant stops functioning
ZERO HEALTH: Plant dies

## 12. STARTER PLANTS

### PEA PLANT:

Role: Basic ranged defense
Attack: Projectile
Range: Medium
Damage: Low
Attack Speed: Fast
Purpose: Reliable basic defense.

### CACTUS:

Role: Close-range defense
Attack: Contact damage
Range: Very short
Health: High
Purpose: Acts as a defensive barrier.

## 13. ZOMBIES

Zombies are the primary enemy. Their main objective is to reach and kill the player.
However, some zombie types can prioritize plants. This forces the player to actively protect their farm.

## 14. ZOMBIE TYPES

NORMAL ZOMBIE: Balanced enemy.
Purpose: Basic enemy.
Average health
Average speed
Average damage
RUNNER ZOMBIE: Fast enemy.
Purpose: Creates immediate pressure.
High speed
Low health
FARMER ZOMBIE
Plant-focused enemy. Prioritizes attacking plants.
Purpose: Forces the player to protect their defenses.

## 15. COMBAT

Combat happens primarily during nighttime.
PLAYER: Uses guns.
PLANTS: Automatically attack.
The player and plants work together.
Example:
Zombie approaches   Player shoots zombie  Zombie survives  Pea Plant attacks.
Zombie reaches farm  Player moves closer   Cactus blocks zombie  Zombie attacks cactus  Player kills zombie  Zombie drops coins.

## 16. SHOP

The shop allows the player to exchange coins for resources. Only open at day time

### MVP ITEMS:

Ammo
Seeds
Hoe
Water Can

### FUTURE:

Weapons
Rare Seeds
Equipment
Upgrades
Crafting Materials

## 17. DAY/NIGHT SYSTEM

DAY
The player can safely prepare.
Available activities:
Farming
Watering
Shopping
Planting
Reloading
Preparing defenses
NIGHT
Zombie attack period.
The player must defend the farm.
The shop is unavailable.
Zombie waves become increasingly difficult.

## 18. WAVE SYSTEM

Night 1: Small number of Normal Zombies.
Night 2: More Normal Zombies.
Night 3: Runner Zombies introduced.
Night 5: Farmer Zombies introduced.
Future:
Special zombies
Elite zombies
Boss zombies
Difficulty increases through:
Zombie count
Zombie health
Zombie speed
Zombie damage
Zombie variety

## 19. ECONOMY

Zombie dies   Coin drops  Player collects coins ->Player decides how to spend coins
AMMO: SHORT TERM (SURVIVAL)
SEEDS: LONG TERM (DEFENSE)

## 20. GAME OVER

The game ends when the player reaches zero health.
GAME OVER SCREEN
Days Survived
Zombies Killed
Coins Earned
Plants Grown
Plants Lost
Options:
Retry
Main Menu

## 21. MVP SCOPE

The MVP must focus on proving one thing:
"Is taking care of plants while surviving zombie attacks actually fun?"
Therefore, the MVP should NOT contain:
Story
NPCs
Crafting
Large map
Multiple biomes
Complex inventory
Bosses
Weather
Multiplayer
Complex progression

## 22. MVP FEATURES

PLAYER
Movement
Mouse Aim
Shooting
Reload
Health
Death
COMBAT
Zombie AI
Zombie Damage
Zombie Death
Coin Drops
Zombie Waves
FARMING
Hoe
Soil
Seeds
Planting
Watering
Plant Growth
Plant Health
Plant Death
PLANTS
Pea Plant
Cactus
GAME SYSTEMS
Day/Night
Shop
Coins
Ammo
Game Over
UI
Health
Ammo
Coins
Day Number
Plant Status

## 23. MVP GAMEPLAY SCENARIO

DAY 1: Player wakes up.
Player has:
Pistol
Limited Ammo
Hoe
Water Can
Small amount of Coins
Player prepares the farm.
Player tills soil.
Player plants Pea Plant.
Player waters the plant.
Night begins.
Five zombies spawn.
Player shoots zombies.
Pea Plant attacks automatically.
Player survives.
Zombies drop coins.
Morning begins.
Player buys another seed.
Player plants another defensive plant.
Night 2 begins.
More zombies appear.
The player now has more defenses but also more things to maintain.
This cycle continues.

## 24. MVP SUCCESS CRITERIA

The MVP is successful if the player naturally understands:
"I need plants."
"I need to water them."
"I need coins."
"I need ammo."
"I need to prepare before night."
"I need to protect my plants."
"I need to decide what to spend my resources on."
Most importantly:
The player should WANT to survive another night.

## 25. FUTURE EXPANSION

FARM
Greenhouses
Storage
Walls
Traps
Irrigation
Buildings
PLANTS
Rare Plants
Plant Evolution
Plant Mutations
Plant Upgrades
Plant Synergies
ZOMBIES
Tank
Spitter
Exploder
Digger
Bosses
SURVIVAL
Weather
Seasons
Drought
Rain
Random Events
EXPLORATION
Abandoned Houses
Hospital
Police Station
Laboratory
Forest
PROGRESSION
Crafting
Skill Tree
Equipment
Weapons
Permanent Upgrades
STORY
Why did the apocalypse happen?
Why are the plants evolving?
Why does the farm remain safe?
What is "ENDING"?

## 26. CORE IDENTITY

ENDING should NOT feel like:
"Plants vs Zombies but top-down."
ENDING should feel like:
"A zombie survival game where farming is your defense system."
The important distinction is that the plants are not simply placed on a battlefield.
They are grown.
They require care.
They can become weak.
They can die.
The player becomes responsible for keeping their defenses alive. That relationship between survival and farming is the game's identity.

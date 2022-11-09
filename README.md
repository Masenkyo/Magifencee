# Magifence

## Gameplay

#### Klik op start button.
#### Begin de wave.
#### Plaats torens om de enemies mee te killen en je gate te beschermen.
#### Je gebruikt verschillende elementen tegen verschillende elemental enemies, vuur doet bijv. geen damage op vuur enemies, maar bijv. double damage op Lightning Enemies.
#### Als je 100 hp verliest dan heb je verloren.
#### Je kan ook torens roteren, wat dus handig is voor torens die niet kunnen ronddraaien, zoals de kanon.
#### Als alle waves zijn gecomplete (10), dan heb je gewonnen.

## Technisch

### Wave Systeem

#### Ik heb een scriptable object gemaakt waarbij je kan aanpassen in de inspector wat voor enemies je wilt spawnen en hoeveel en in een bepaalde volgorde.
#### Dan heb ik een spawn script gemaakt die langs alle waves gaat 1 voor 1, en als alle enemies in de current wave dood zijn gaat hij naar de volgende.

![Wave Scriptable Object in Inspector](../../Afbeeldingen/Imagee.png)

### Aimen van torens

#### Met onze wiskunde lessen heb ik geleerd hoe ik makkelijk een object naar een andere object kan laten kijken/volgen.
![Simple Aim Script](../../Afbeeldingen/aimm.png)

### Het HP en Cash laten zien in nummers

#### Ik heb een text gemaakt en dan veranden ik wat er in de text staat door een script.
#### De script checkt basicly wat de current hp is bij enemyhp en veranderd het getal naar dat getal, hetzelfde met de Cash.
![](../../Afbeeldingen/UII.png)

### TowerPlace

#### Ik heb buttons gemaakt die torens instantiaten met de TowerPlace script.

#### Wat ik eerst heb gedaan is een Vector3 aanmaken die ervoor zorgt dat de tower die geinstantiate is de muis position volgt in 0.5f distances, dus hij heeft squares waar je de torens kan plaatsen, en beweegt in squares, je kan de tower dus bijv. niet tussen de squares plaatsen.

#### Hij checkt daarna of hij op de positie zit van een andere tower, als hij op dezelfde positie zit mag hij de tower niet plaatsen, ander mag het wel.

#### Dan laat hij in de update (Tower en Range) de muis volgen, je kan met Q en E de tower rond draaien in 90 graden rotaties.

#### Daarna checkt hij of hij grass aanraakt, en als hij dat niet aanraakt, mag hij de tower niet plaatsen, als hij het wel aanraakt plaatst hij de tower.

#### En als laatste heb ik functies gemaakt om de tower te instantiaten via de buttons.
#### Basicly hij checkt of hij genoeg points heeft, als dat zo is, dan instantiate hij tower en range en removed de points.
#### Ook als je hem plaatst dan removed hij de range.
#### En als je bijv. een kannon pakt, die 50 kost en terwijl je de tower nog niet heb geplaatst dan op de tesla button klikt, removed hij de current tower, geeft het geld terug, en removed het aantal geld dat de tesla kost, hieronder is de functie van de kannon tower.
![Kannon Script Functie](../../Afbeeldingen/1vOORBEELD.png)

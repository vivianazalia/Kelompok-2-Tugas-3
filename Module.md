[Module Character]

*BaseObject ->speed,move(), shoot()
**Character
**Enemy

*Shield

IDameable

- Void TakeDamage ( )
- Void OnDestruct ( )

[Player Status]
- Void ReduceLife ()
- Void AddScore ()


[PowerUp]
- PowerUp

[Save Data]
-DataController
Void Save(nama, score)
Void Load()
-DataView
void DisplayDataLeadeboard()

[Sound]
void PlayBGM()
void Sfx()






oe-selectie-feedback_score
# Oefening op verschillende manieren van selectie
De bedoeling is dat er op basis van de input in lstScores feedback wordt gegeven over het gegeven punt.
Bij elke wijziging in score wordt de tekst in lblFeedback gewist.
## btnOkOfNiet
Een score minder dan 3 is 'Niet OK', vanaf 3 'OK'
## btnOkGoedNietOk
- minder dan 3: 'Niet OK'
- 3: 'OK'
- meer dan 3: 'Goed'
## btnGedetailleerdeFeedback
- 1: Zwak
- 2: Kan beter
- 3: Goed
- 4: Zeer goed
- 5: Uitstekend
Mocht er een andere score gekozen zijn, dan is de feedback: 'Kies een score'
## btnOkGoedNietOkSwitch
Idem als bij **btnOkGoedNietOk**, maar dan met een switch ... case

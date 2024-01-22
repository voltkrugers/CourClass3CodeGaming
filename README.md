# CourClass3CodeGaming

liste des chose a faire durant la scéance : 
  - importé des assets afin de améliorer le visuel du jeux
  - écrire le code PickUpObject en expliquant ligne par ligne ce que l'on fais.
  - Mettre le projet sur un repo GitHub en expliquant si il souhaite le recupérer comment le faire.


étape pour que le code soit fonctionnelle :
  - crée un un empty appelé "Destination" a l'intérieur de la capsule puis placé le de sorte qu'elle se retrouve a l'avant de votre personnage a l'endroit ou on aurais une main dans un JV.
  - a l'interieur de votre main caméra crée un empty appelé trigger.Puis faite addComponent et ajouté un BoxCollider.
  - dans votre box collider cocher la case "is trigger" et éditer le collider pour qu'il soit un long rectangle devant votre caméra.
  - ajouter le code PickUpObject dans l'object IsTrigger puis dans pickUpDest placé votre object destination crée auparavant.
  - sur l'object que vous souhaité prendre dans votre main ajouter le component Boxcollider et rigidbody.
  - dans le component rigidbody cliqué sur constraint et coché toutes les cases.
  - ensuité ajouté un Tag "Obj" sur cette objet.
  - maintenant il reste plus que a tester.


 

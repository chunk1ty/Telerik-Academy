(function () {
  require(['structures'], function (structures) {
    var bulgarianHeroesSection, greekHeroesSection, heroesContainer, superheroesSection;
    heroesContainer = structures.getContainer();

    superheroesSection = structures.getSection('Superheroes');
    heroesContainer.add(superheroesSection);

    superheroesSection.add(structures.getItem('Batman'))
      .add(structures.getItem('Ironman'))
      .add(structures.getItem('Superman'))
      .add(structures.getItem('Wonderwoman'))
      .add(structures.getItem('The Flash'))
      .add(structures.getItem('Spiderman'))
      .add(structures.getItem('Captain America'))
      .add(structures.getItem('The Hulk'))
      .add(structures.getItem('Green arrow'))
      .add(structures.getItem('Green Lantern'));

    greekHeroesSection = structures.getSection('Greek Heroes');
    heroesContainer.add(greekHeroesSection);
    greekHeroesSection.add(structures.getItem('Ajax'));
    greekHeroesSection.add(structures.getItem('Hercules'));
    greekHeroesSection.add(structures.getItem('Jason'));
    greekHeroesSection.add(structures.getItem('Perseus'));
    greekHeroesSection.add(structures.getItem('Odysseus'));

    bulgarianHeroesSection = structures.getSection('Bulgarian Heroes');
    heroesContainer.add(bulgarianHeroesSection);
    bulgarianHeroesSection.add(structures.getItem('Hristo Botev'));
    bulgarianHeroesSection.add(structures.getItem('Vasil Levski'));
    bulgarianHeroesSection.add(structures.getItem('Chavdar Vyivoda'));

    var result = JSON.stringify(heroesContainer.getData());
    var expected = JSON.stringify([{
      "title": "Superheroes",
      "items": [{
        "content": "Batman"
      }, {
        "content": "Ironman"
      }, {
        "content": "Superman"
      }, {
        "content": "Wonderwoman"
      }, {
        "content": "The Flash"
      }, {
        "content": "Spiderman"
      }, {
        "content": "Captain America"
      }, {
        "content": "The Hulk"
      }, {
        "content": "Green arrow"
      }, {
        "content": "Green Lantern"
      }]
    }, {
      "title": "Greek Heroes","items": [{
        "content": "Ajax"
      }, {
        "content": "Hercules"
      }, {
        "content": "Jason"
      }, {
        "content": "Perseus"
      }, {
        "content": "Odysseus"
      }]
    }, {
      "title": "Bulgarian Heroes",
      "items": [{
        "content": "Hristo Botev"
      }, {
        "content": "Vasil Levski"
      }, {
        "content": "Chavdar Vyivoda"
      }]
    }]);

    console.log(result == expected);
  });

  

}).call(this);

//# sourceMappingURL=app.map
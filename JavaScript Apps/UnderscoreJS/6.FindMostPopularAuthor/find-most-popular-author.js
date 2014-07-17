(function () {
    'use strict';

    var books = [
            {name: 'Welcome', author: 'Manol'},
            {name: 'To', author: 'Stoimen'},
            {name: 'Miami', author: 'Manol'},
            {name: 'Amigo', author: 'Ivan'},
            {name: 'Get', author: 'Ivan'},
            {name: 'Jiggy', author: 'Manol'},
            {name: 'With', author: 'Stoimen'},
            {name: 'It', author: 'Manol'},
        ],
        mostPopularAuthor;

    //toz Manol very umen be O.o

    mostPopularAuthor = _.chain(books)
        .groupBy('author')
        .sortBy('author')
        .value()[0][0].author;

    console.log(mostPopularAuthor);
}());

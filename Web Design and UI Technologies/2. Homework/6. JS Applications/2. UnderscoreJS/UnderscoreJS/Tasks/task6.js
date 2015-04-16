var books = data.getAllBooks();

var grouptedBooksByAuthor = _.groupBy(books, '_author');
console.log(grouptedBooksByAuthor);
var mostBooksCount = 0;
var mostPopularAuthor = '';

_.each(grouptedBooksByAuthor, function (booksByAuthor, author) {
    if (mostBooksCount < booksByAuthor.length) {
        mostBooksCount = booksByAuthor.length;
        mostPopularAuthor = author;
    }
});

console.log(mostPopularAuthor + ' has ' + mostBooksCount + ' books.');
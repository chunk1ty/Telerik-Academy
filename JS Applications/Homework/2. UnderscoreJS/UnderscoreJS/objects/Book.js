function Book(author, name) {
    this._author = author;
    this._name = name;
}

Book.prototype.getAuthor = function () {
    return this._author;
}

Book.prototype.getBookName = function () {
    return this._name;
}

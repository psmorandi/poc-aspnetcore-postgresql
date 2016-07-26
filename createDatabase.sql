CREATE TABLE book (
	id	SERIAL,
	title varchar NOT NULL,
	PRIMARY KEY (id)
);

CREATE TABLE author (
	id SERIAL,
	firstName varchar NOT NULL,
	lastName varchar NOT NULL,
	PRIMARY KEY (id)
);

CREATE TABLE author_book (
	book_id integer references book,
	author_id integer references author,
	PRIMARY KEY (book_id, author_id)
);
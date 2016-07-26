INSERT INTO book values (nextval('book_id_seq'), 'The Selfish Gene');
INSERT INTO author values (nextval('author_id_seq'), 'Richard', 'Dawkins');
INSERT INTO author_book values (
(SELECT last_value FROM book_id_seq),
(SELECT last_value FROM author_id_seq));

INSERT INTO book values (nextval('book_id_seq'), 'Clean Code');
INSERT INTO author values (nextval('author_id_seq'), 'Robert C.', 'Martin');
INSERT INTO author_book values (
(SELECT last_value FROM book_id_seq),
(SELECT last_value FROM author_id_seq));

INSERT INTO book values (nextval('book_id_seq'), 'American Gods');
INSERT INTO author values (nextval('author_id_seq'), 'Neil', 'Gaiman');
INSERT INTO author_book values (
(SELECT last_value FROM book_id_seq),
(SELECT last_value FROM author_id_seq));

INSERT INTO book values (nextval('book_id_seq'), 'Design Patterns');
INSERT INTO author values (nextval('author_id_seq'), 'Erich', 'Gamma');
INSERT INTO author_book values (
(SELECT last_value FROM book_id_seq),
(SELECT last_value FROM author_id_seq));

INSERT INTO author values (nextval('author_id_seq'), 'Richard', 'Helm');
INSERT INTO author_book values (
(SELECT last_value FROM book_id_seq),
(SELECT last_value FROM author_id_seq));

INSERT INTO author values (nextval('author_id_seq'), 'Ralph', 'Johnson');
INSERT INTO author_book values (
(SELECT last_value FROM book_id_seq),
(SELECT last_value FROM author_id_seq));

INSERT INTO author values (nextval('author_id_seq'), 'John', 'Vlissides');
INSERT INTO author_book values (
(SELECT last_value FROM book_id_seq),
(SELECT last_value FROM author_id_seq));
CREATE TABLE users(
username VARCHAR(25) NOT NULL PRIMARY KEY,
email VARCHAR(300) NOT NULL,
first_name VARCHAR(75),
last_name VARCHAR(75),
verified BIT DEFAULT 0,
photo VARCHAR(300),
usr_deleted BIT DEFAULT 0
)

CREATE TABLE publications(
publication_id INT NOT NULL PRIMARY KEY,
publisher VARCHAR(25) NOT NULL,
pub_description VARCHAR(500),
price NUMERIC(16, 2),
pub_deleted BIT DEFAULT 0
)

CREATE TABLE publications_photos(
photo_id INT NOT NULL PRIMARY KEY,
publication_id INT,
photo_deleted BIT DEFAULT 0
)

ALTER TABLE publications ADD CONSTRAINT fk_publication_user FOREIGN KEY (publisher) REFERENCES users(username)
ALTER TABLE publications_photos ADD CONSTRAINT fk_publication_photos FOREIGN KEY (publication_id) REFERENCES publications(publication_id)